using fireflower_backend.Dtos;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace fireflower_backend.Controllers;

public class Shop_RatingController : Controller
{
    private readonly IShop_Rating _shopRating;

    public Shop_RatingController(IShop_Rating shopRating)
    {
        _shopRating = shopRating;
    }
    [HttpGet("api/GetRatingShop")]
    public async Task<ActionResult<List<RatingShopDtos>>> GetShopRating()
    {
        return Ok(await _shopRating.GetShopRating());
    }

    [HttpPost("api/AddRatingShop")]
    public async Task<ActionResult<RatingShopDtos>> AddShopRating([FromBody] RatingShopDtos ratingShopDtos)
    {
        return Ok(await _shopRating.AddShopRating(ratingShopDtos));
    }
        
}