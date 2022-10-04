using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScratchPad3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpService service = new HttpService();
            Console.WriteLine("jefffff");
            var result = await service.Get<PostDTO>($"https://beta.a2b2.org/api/posts/20");

            Console.WriteLine(result.Response.ImageURL);
        }

    }
}
