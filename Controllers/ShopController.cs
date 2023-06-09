using Microsoft.AspNetCore.Mvc;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Controllers
{
    public class ShopController : Controller
    {
       
        private readonly IShop _shopModel;

        public ShopController(IShop shopModel)
        {
            _shopModel = shopModel;
        }

        [HttpGet]
        [Route("shop")]
        public async Task<IActionResult> OutputShop()
        {
            IList<Shop> shops = await _shopModel.OutputShop();
            return Ok("shops");
        }
    }


}

