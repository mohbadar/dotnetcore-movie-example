using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // [Microsoft.AspNetCore.Mvc.NonAction]
        public IActionResult Welcome(string name)
        {
            ViewData["message"] = "Hello " + name;
            return View();
        }
    }
}