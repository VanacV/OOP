using AutoMapper;
using fireflower_backend.Dtos;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using Microsoft.EntityFrameworkCore;


namespace fireflower_backend.Models.Realization;

public class ProductModel : IProduct
{
    private readonly MyDbContext _dbContext;
    private readonly IMapper _mapper;

    public ProductModel(MyDbContext dbContext,IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<serviceResponce<List<productDtos>>> GetAllProduct()
    {
        var serviceResponse = new serviceResponce<List<productDtos>>();

        try
        {
            var dbProduct = await _dbContext.Products.ToListAsync();
            serviceResponse.Data = new List<List<productDtos>> {dbProduct.Select(c => _mapper.Map<productDtos>(c)).ToList()};
            return serviceResponse;
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

            return serviceResponse;
        }
    }
}