using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Day2_VuKimThien.Controllers
{
    [Route("test")]
    public class HelloController : Controller
    {
        [HttpGet("Trang_chu")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Hello")]
        public IActionResult Welcome(string name = "Thien", int ID = 1)
        {
            ViewData["name"] = "Hello " + name;
            ViewData["Id"] = ID;
            return View();
        }
        [HttpGet("Hi")]
        public IActionResult Hi(int ID =1 , string name = "Vu Kim Thien" , int age = 22)
        {
            ViewBag.ID = ID; 
            ViewBag.Name = name;
            ViewBag.Age = age;

            return View();
        }

    }
}
