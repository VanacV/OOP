
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace fireflower_backend.Controllers
{
    public class ProductController : Controller
    {
       
        private readonly IProduct _product;

        public ProductController(IProduct product)
        {
            _product = product;
           
        }
        [HttpGet("api/GetAllProduct")]
        public async Task<ActionResult<List<Product>>> GetAllProduct()
        {
            return Ok(await _product.GetAllProduct());
        }
    }
}

