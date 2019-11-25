using System.Collections.Generic;
using System.Threading.Tasks;
using IT_School.CSharp.AspNetCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace IT_School.CSharp.AspNetCore.Controllers
{
    [Route("api/pins")]
    public class PinsController : ControllerBase
    {
        
        private readonly PinterestClient _pinterestClient;

        public PinsController(PinterestClient pinterestClient)
        {
            _pinterestClient = pinterestClient;
        }

        [HttpGet]
        public async Task<IEnumerable<string>> GetPins([FromQuery]string boardName, [FromQuery]int count)
        {
            return await _pinterestClient.GetPins(boardName, count);
        }
    }
}