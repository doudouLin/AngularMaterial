using Microsoft.AspNetCore.Mvc;

namespace MVCAngular1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Spa()
        {
            return View();
        }
        public IActionResult Events()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
