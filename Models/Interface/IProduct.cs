using fireflower_backend.Dtos;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Interface
{
    public interface IProduct
    {
        Task<serviceResponce<List<productDtos>>> GetAllProduct();
    }
}
