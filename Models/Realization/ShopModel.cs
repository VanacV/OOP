using Microsoft.EntityFrameworkCore;
using Project.Models.Interface;
using Project.Storage;
using Project.Storage.Entity;

namespace Project.Models.Realization
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
