using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.NewFolder
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
