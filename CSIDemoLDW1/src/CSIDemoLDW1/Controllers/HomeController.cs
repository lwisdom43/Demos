using Microsoft.AspNet.Mvc;

namespace CSIDemoLDW1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Hello(string name)
        {
            return "Hello, " + name + "!";
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
