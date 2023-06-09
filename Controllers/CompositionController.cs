using Microsoft.AspNetCore.Mvc;
using Project.Models.Interface;
using Project.Storage.Entity;

namespace Project.Controllers
{
    public class CompositionController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
    }
}
