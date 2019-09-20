using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace IT_School.CSharp.HTTP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (HttpClient client = new HttpClient())
            {
                Uri uri = new Uri("https://westcentralus.api.cognitive.microsoft.com/vision/v2.0/");
                client.BaseAddress = uri;
                string header = "ocp-apin-subscription-key";
                client.DefaultRequestHeaders.Add(header,"f90b5b11e7914de2a8628f07c8c4b2a5");
                //client.DefaultRequestHeaders.Add("Content-Type","application/octet-stream");
                string imageUrl =
                    "https://pbs.twimg.com/media/DY-0BhFXcAAwqXZ.jpg";

                using (var image = ImageLoader.Load(imageUrl).Result)
                {

                    using (StreamContent content = new StreamContent(image))
                    {
                        
                        content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream"); 
                        var post = client.PostAsync("detect/?subscription-key=f90b5b11e7914de2a8628f07c8c4b2a5", content).Result;
                        var result = post.Content.ReadAsStringAsync().Result;
                        Console.WriteLine(result);
                    }

                }
                
            }
            Console.Read();
        }
    }
}