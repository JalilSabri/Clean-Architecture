using Microsoft.AspNetCore.Mvc;

namespace CleanArch.MVCUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
