namespace IT_School.CSharp.AspNetCore.Options
{
    public class ApplicationOptions
    {
        public string PinterstApiKey { get; set; }

        public ApplicationOptions(string pinterstApiKey)
        {
            PinterstApiKey = pinterstApiKey;
        }
    }
}