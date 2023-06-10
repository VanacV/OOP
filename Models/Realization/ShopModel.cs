
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;
using Microsoft.EntityFrameworkCore;


namespace fireflower_backend.Models.Realization
{
    public class ShopModel : IShop
    {
        private readonly MyDbContext _dbContext;

        public ShopModel(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Shop>> GetAllShop()
        {
            List<Shop> shops = await _dbContext.Shop.Include(s => s.Products)
                .Include(s => s.Shop_Rating).ToListAsync();
            return shops;
        }
    }
}