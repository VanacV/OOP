using fireflower_backend.Models;
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

        [HttpGet("GetAllShop")]
        public async Task<ActionResult<List<Shop>>> GetAllShop()
        {
            try
            {
                List<Shop> shops = await _shopModel.GetAllShop();
                return shops;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed" + ex.Message);
            }
        }
    }

}
 
