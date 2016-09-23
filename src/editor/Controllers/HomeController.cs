using Microsoft.AspNetCore.Mvc;

namespace editor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
