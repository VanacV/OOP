using fireflower_backend.Dtos;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Interface
{
    public interface IProduct_Rating
    {
        Task<serviceResponce<productRatingDtos>> AddPruductRating(productRatingDtos productRatingDtos);
        Task<serviceResponce<List<productRatingDtos>>> GetAllProductRating();
    }
}
