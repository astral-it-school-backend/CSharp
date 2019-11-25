using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IT_School.CSharp.AspNetCore.Options;
using PinSharp;

namespace IT_School.CSharp.AspNetCore.Services
{
    public class PinterestClient
    {
        private readonly PinSharpClient _client;

        public PinterestClient(ApplicationOptions options)
        {
            _client = new PinSharpClient(options.PinterstApiKey);
        }

        public async Task<IEnumerable<string>> GetPins(string boardName, int count)
        {
            var pins = await _client.Boards.GetPinsAsync(boardName, count);

            return pins.Select(a => a.Link);
        }
    }
}