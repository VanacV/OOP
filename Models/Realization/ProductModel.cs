using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace fireflower_backend.Models.Realization
{
    public class ProductModel : IProduct
    {
        private readonly MyDbContext _dbContext;

        public ProductModel(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetAllProduct()
        {
            List<Product> products = await _dbContext.Products.Include(p => p.Payment)
                .Include(p => p.Shop).Include(p => p.Product_Rating).ToListAsync();
            return products;
        }
    }
}
