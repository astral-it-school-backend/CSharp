using System;
using System.Linq;

namespace IT_School.CSharp.Static
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Орангутан";
            
            Console.WriteLine(str.SetRandomCharacter(3));
            Console.ReadKey();
        }
    }
    
    public static class StringExtension
    {
        public static bool IsNullOrWhitespace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static string SetRandomCharacter(this string str, int count)
        {
            int[] positions = new int[count];
            Random rnd = new Random();

            for (int i = 0; i < positions.Length; i++)
            {
                positions[i] = rnd.Next(str.Length);
            }

            char[] characters = new char[count];
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i] = (char)rnd.Next(95,127);
            }

            char[] newStr = new char[str.Length];    
            
            for (int i = 0, j = 0; i < str.Length; i++)
            {
                if (positions.Contains(i))
                {
                    newStr[i] = characters[j];
                    j++;
                }
                else
                {
                    newStr[i] = str[i];
                }
                
            }
            return newStr.ToStringLine();
        }

        public static string ToStringLine(this char[] characters)
        {
            return new string(characters);
        }
    }
}