using Microsoft.AspNetCore.Mvc;

namespace fireflower_backend.Controllers
{
    public class ProductController : Controller
    {
        
        [HttpGet]
        [Route("/api/Product")]
        public async Task<ActionResult> GetAll()
        {
            return Ok("Ok");
        }
    }
}
