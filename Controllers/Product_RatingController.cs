using fireflower_backend.Dtos;
using fireflower_backend.Models;
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
        [HttpGet("api/GetAllProductRating")]
        public async Task<ActionResult<List<productRatingDtos>>> GetAllProductRaiting()
        {
            return Ok(await _productRating.GetAllProductRating());
        }

        [HttpPost("api/AddProductRating")]
        public async Task<ActionResult<serviceResponce<productRatingDtos>>> AddPruductRating([FromBody] productRatingDtos productRatingDtos)
        {
            return Ok(await _productRating.AddPruductRating(productRatingDtos));
        }
    }
}
