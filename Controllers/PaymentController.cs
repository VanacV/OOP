using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
