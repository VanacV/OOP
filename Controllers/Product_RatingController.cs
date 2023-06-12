using fireflower_backend.Models.Interface;
using fireflower_backend.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace fireflower_backend.Controllers
{
    public class Product_RatingController : Controller
    {
        private readonly IProduct_Rating _productRating;

        public Product_RatingController(IProduct_Rating productRating)
        {
            _productRating = productRating;
        }
        [HttpGet("GetAllProductRaiting")]
        public async Task<ActionResult<List<Product_Rating>>> GetAllProductRaiting()
        {
            try
            {
                List<Product_Rating> productRatings = await _productRating.GetAllProductRaiting();
                return productRatings;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed" + ex.Message);
            }
        }
    }
}
