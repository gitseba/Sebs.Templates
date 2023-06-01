using Microsoft.AspNetCore.Mvc;

namespace Sebs.Template.Asp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}