using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace fireflower_backend.Models.Realization
{
    public class Product_RatingModel:IProduct_Rating
    {
        private readonly MyDbContext _dbContext;

        public Product_RatingModel(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Product_Rating>> GetAllProduct_Raiting()
        {
            List<Product_Rating> productRatings = await _dbContext.Product_Ratings.ToListAsync();
            return productRatings;

        }
    }
}
