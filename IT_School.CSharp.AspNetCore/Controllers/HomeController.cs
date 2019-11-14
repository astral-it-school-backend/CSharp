using System;
using System.Dynamic;
using System.Net.Mime;
using System.Threading.Tasks;
using IT_School.CSharp.AspNetCore.ViewModels;
using IT_School.CSharp.EFCore.Serivces;
using Microsoft.AspNetCore.Mvc;

namespace IT_School.CSharp.AspNetCore.Controllers
{
//    [Route("")]
//    [Route("swagger")]
//    public class HomeController : ControllerBase
//    {
//        [HttpGet]
//        public IActionResult Index()
//        {
//            return Redirect("~/api/help");
//        }
//    }

//    [Route("")]
//    public class HomeController : ControllerBase
//    {
//        [HttpGet]
//        public IActionResult Index()
//        {
//            return File("index.html",MediaTypeNames.Text.Html);
//        }
//    }
    [Route("")]
    public class HomeController : Controller
    {
        private readonly FlatService _flatService;

        public HomeController(FlatService flatService)
        {
            _flatService = flatService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
//            dynamic d = new ExpandoObject();
//
//            d.MyProp = 1;
//            d.Str = "sdfsdf";
//
//            var myprop = d.MyProp;

            ViewBag.MyString = "My string";

            var persons = await _flatService.GetRoomers(Guid.Parse("31b1e492-278e-4b57-80ed-805cced59fdf"), 0, 10);
            
            return View("Index", new IndexViewModel(persons));
        }
    }
}