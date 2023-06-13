using fireflower_backend.Dtos;

namespace fireflower_backend.Models.Interface
{
    public interface IShop_Rating
    {
        Task<serviceResponce<List<RatingShopDtos>>> GetShopRating();
        Task<serviceResponce<RatingShopDtos>> AddShopRating(RatingShopDtos ratingShopDtos);
    }
}
