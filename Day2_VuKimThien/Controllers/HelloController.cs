using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Day2_VuKimThien.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {
            return "Hello, World!";
        }

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

    }
}
