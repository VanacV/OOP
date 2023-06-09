using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class MallingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
