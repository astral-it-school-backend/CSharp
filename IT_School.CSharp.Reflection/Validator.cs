using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace IT_School.CSharp.Reflection
{
    public static class Validator
    {
        public static bool Validate(object obj)
        {
            var type = obj.GetType();

            foreach (var field in type.GetFields())
            {
                if (field.GetCustomAttribute<RequiredAttribute>() != null)
                {
                    var value = field.GetValue(obj);
                    if (value == null)
                    {
                        return false;
                    }

                    if (value is string str)
                    {
                        if (string.IsNullOrEmpty(str))
                        {
                            return false;
                        }
                    }

                    if (value is int n)
                    {
                        if (n == 0)
                        {
                            return false;
                        }
                    }
                }

                if (field.GetCustomAttribute<PositiveAttribute>() != null)
                {
                    var value = field.GetValue(obj);
                    if (value is int n)
                    {
                        if (n < 1)
                        {
                            return false;
                        }
                    }
                }

                if (field.GetCustomAttribute<IsKolyaAttribute>() != null)
                {
                    var value = field.GetValue(obj);

                    if (value is string str)
                    {
                        if (str.ToLower() != "коля" || str.ToLower() != "kolya")
                            return false;
                    }
                }
            }

            return true;
        }
    }
}