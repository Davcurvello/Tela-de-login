using Microsoft.AspNetCore.Mvc;

namespace LoginNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View();

        }
    }
}