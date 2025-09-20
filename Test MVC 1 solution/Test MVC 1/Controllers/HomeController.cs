using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test_MVC_1.Models;

namespace Test_MVC_1.Controllers
{
    public class HomeController : Controller
    {


        //Method public 
        //can't be static 
        //can't be overload
        public ContentResult ShowMsg()
        {
            ContentResult Result = new ContentResult();
            Result.Content = "Hello";
            return Result;
        }

        public ViewResult ShowView()
        {
            //declare
            ViewResult result = new ViewResult();
            //initial
            result.ViewName = "View1";
            // return
            return result;
        }
        ///home/showmix?id=1  == Hello Rowad
        public IActionResult ShowMix(int id)
        {
            if (id % 2 == 0)
            {
                return View("View1");
            }
            else
            {
                return Content("Hello Rowad !");
            }
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
