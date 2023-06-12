using AutoMapper;
using fireflower_backend.Dtos;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace fireflower_backend.Models.Realization
{
    public class ProductModel : IProduct
    {
        private readonly MyDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductModel(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<serviceResponce<List<productDtos>>> GetAllProduct()
        {
            var serviceResponse = new serviceResponce<List<productDtos>>();
            var dbProduct = await _dbContext.Products.ToListAsync();
            serviceResponse.Data = dbProduct.Select(c => _mapper.Map<productDtos>(c)).ToList();
            return serviceResponse;
        }
    }
}