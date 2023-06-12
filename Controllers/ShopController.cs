using fireflower_backend.Dtos;
using fireflower_backend.Models;
using Microsoft.AspNetCore.Mvc;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage.Entity;
using Project.Models;

namespace fireflower_backend.Controllers
{
    public class ShopController : Controller
    {
       
        private readonly IShop _shopModel;

        public ShopController(IShop shopModel)
        {
            _shopModel = shopModel;
        }

        [HttpGet("GetAllShop")]
        public async Task<ActionResult<serviceResponce<List<productDtos>>>>GetAllShop()
        {
            return Ok(await _shopModel.GetAllShop());
        }
    }

}
 
