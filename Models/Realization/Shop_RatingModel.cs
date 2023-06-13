using AutoMapper;
using fireflower_backend.Dtos;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace fireflower_backend.Models.Realization;

public class Shop_RatingMode:IShop_Rating
{
    private IShop_Rating _shopImplementation;
    private MyDbContext _dbContext;
    private IMapper _mapper;

    public Shop_RatingMode(MyDbContext dbContext,IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }
        
    public  async Task<serviceResponce<List<RatingShopDtos>>> GetShopRating()
    {
        var serviceResponce = new serviceResponce<List<RatingShopDtos>>();
        try
        {
            var dbRatingShop = await _dbContext.Shop_Rating.ToListAsync();
            serviceResponce.Data = new List<List<RatingShopDtos>>{dbRatingShop.Select(c =>_mapper.Map<RatingShopDtos>(c)).ToList()};
            return serviceResponce;
        }
        catch (Exception ex)
        {
            serviceResponce.Success = false;
            serviceResponce.Message = ex.Message;
        
            var innerException = ex.InnerException;
            while (innerException != null)
            {
                Console.WriteLine(innerException.Message);
                innerException = innerException.InnerException;
            }

            return serviceResponce;
        }
    }

    public async Task<serviceResponce<RatingShopDtos>> AddShopRating(RatingShopDtos ratingShopDtos)
    {
        var serviceResponse = new serviceResponce<RatingShopDtos>();
        try
        {
            var rating = _mapper.Map<Shop_Rating>(ratingShopDtos);

            _dbContext.Shop_Rating.Add(rating);
            await _dbContext.SaveChangesAsync();

            serviceResponse.Data = new List<RatingShopDtos> { _mapper.Map<RatingShopDtos>(rating) };
            serviceResponse.Success = true;
            serviceResponse.Message = "Payment added successfully.";
        }
        catch (Exception ex)
        {
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
            Exception innerException = ex.InnerException;
            while (innerException != null)
            {
                Console.WriteLine(innerException.Message);
                innerException = innerException.InnerException;
            }
        }
        return serviceResponse;
    }
}