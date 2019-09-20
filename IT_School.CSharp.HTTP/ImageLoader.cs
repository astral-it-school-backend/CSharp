using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace IT_School.CSharp.HTTP
{
    public static class ImageLoader
    {
        public static async Task<MemoryStream> Load(string url)
        {
            MemoryStream stream = new MemoryStream();
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync(url))
                {
                    await response.Content.CopyToAsync(stream);
                }
            }

            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }
    }
}