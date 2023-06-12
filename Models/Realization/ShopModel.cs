
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;
using Microsoft.EntityFrameworkCore;
using Project.Models;


namespace fireflower_backend.Models.Realization
{
    public class ShopModel : IShop
    {
        private readonly MyDbContext _dbContext;

        public ShopModel(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<serviceResponce<List<Shop>>> GetAllShop()
        {
            var serviceResponce = new serviceResponce<List<Shop>>();
            List<Shop> shops = await _dbContext.Shop.Include(s => s.Products)
                .Include(s => s.Shop_Rating).ToListAsync();
           // serviceResponce.Data = shops;
            return serviceResponce;
        }
    }
}