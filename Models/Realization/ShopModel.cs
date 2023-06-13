
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
        public async Task<List<Shop>> GetAllShop()
        {
            var shops = await _dbContext.Shop.ToListAsync();
            return shops;
        }
    }
}