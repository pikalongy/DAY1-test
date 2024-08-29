using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.NewFolder
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
