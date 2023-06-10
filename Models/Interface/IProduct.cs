using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Interface
{
    public interface IProduct
    {
        Task<List<Product>> GetAllProduct();
    }
}
