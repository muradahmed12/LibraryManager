using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
