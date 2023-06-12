using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Interface
{
    public interface IProduct_Rating
    {
        Task<List<Product_Rating>> GetAllProductRaiting();
    }
}
