using AutoMapper;
using fireflower_backend.Dtos;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace fireflower_backend.Models.Realization;

public class Product_RatingModel:IProduct_Rating
{
    private readonly MyDbContext _dbContext;
    private readonly IProduct_Rating _productRating;
    private readonly IMapper _mapper;

    public Product_RatingModel(MyDbContext dbContext,IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }
    public async Task<serviceResponce<productRatingDtos>> AddPruductRating(productRatingDtos productRatingDtos)
    {
        var serviceResponce = new serviceResponce<productRatingDtos>();
        try
        {
            var rating = _mapper.Map<Product_Rating>(productRatingDtos);

            _dbContext.Product_Ratings.Add(rating);
            await _dbContext.SaveChangesAsync();

            serviceResponce.Data = new List<productRatingDtos> { _mapper.Map<productRatingDtos>(rating) };
            serviceResponce.Success = true;
            serviceResponce.Message = " added successfully.";
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
               

        }
        return serviceResponce;
    }

    public async Task<serviceResponce<List<productRatingDtos>>> GetAllProductRating()
    {
        var serviceResponce = new serviceResponce<List<productRatingDtos>>();
        try
        {
            var rating = await _dbContext.Product_Ratings.ToListAsync();
            serviceResponce.Data = new List<List<productRatingDtos>>{rating.Select(c =>_mapper.Map<productRatingDtos>(c)).ToList()};
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
}