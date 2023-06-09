using fireflower_backend.Storage;
using Microsoft.EntityFrameworkCore;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Realization
{
    public class ShopModel : IShop
    {
        private MyDbContext _dbContext;
        public ShopModel(MyDbContext dbConxetx)
        {
            _dbContext = dbConxetx;
        }

        public async Task<IList<Shop>> OutputShop() => await _dbContext.Shop.ToListAsync();
        
    }
}
