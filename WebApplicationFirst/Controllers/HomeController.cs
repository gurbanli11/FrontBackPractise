using Microsoft.AspNetCore.Mvc;

namespace WebApplicationFirst.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContactUs() 
        {
            return View();
        }
    }
}
