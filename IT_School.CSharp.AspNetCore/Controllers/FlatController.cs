using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IT_School.CSharp.EFCore.Entities;
using IT_School.CSharp.EFCore.Serivces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace IT_School.CSharp.AspNetCore.Controllers
{
    [Route("Flat")]
    public class FlatController : ControllerBase
    {
        private readonly FlatService _flatService;

        public FlatController(FlatService flatService)
        {
            _flatService = flatService;
        }

        [HttpGet]
        [Route("{addressId}")]
        public async Task<List<Person>> GetRoomers([FromRoute]Guid addressId, [FromQuery]int offset, [FromQuery]int count = 10)
        {
            var result = await _flatService.GetRoomers(addressId, offset, count);
            
            throw new InvalidOperationException("Ошибка");

//            return JsonConvert.SerializeObject(result, new JsonSerializerSettings
//            {
//                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
//                NullValueHandling = NullValueHandling.Ignore
//            });

            return result;
        }

        [HttpGet]
        [Route("address/{addressId}")]
        public async Task<Address> GetAddressInfo([FromRoute]Guid addressId)
        {
            return await _flatService.GetAddressInfo(addressId);
        }
    }
}