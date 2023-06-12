using AutoMapper;
using fireflower_backend.Dtos;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend;

public class AutoMapperController : Profile
{
    public AutoMapperController(){
        
        CreateMap<Payment, paymentDtos>();
        CreateMap<paymentDtos, Payment>();
        CreateMap<Product, productDtos>();
    }
}