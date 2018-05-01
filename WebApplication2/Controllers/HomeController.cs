using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.wwwroot
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}