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
        [HttpGet("GetAllProduct")]
        public async Task<ActionResult<List<Product>>> GetAllProduct()
        {
            try
            {
                List<Product> products = await _product.GetAllProduct();
                return products;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed" + ex.Message);
            }
        }
    }
}
