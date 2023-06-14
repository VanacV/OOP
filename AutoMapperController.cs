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
        CreateMap<productDtos, Product>();
        CreateMap<Shop_Rating, RatingShopDtos>();
        CreateMap<RatingShopDtos,Shop_Rating>();
        CreateMap<Product_Rating, productRatingDtos>();
        CreateMap<productRatingDtos, Product_Rating>();
        CreateMap<Auth, authDtos>();
        CreateMap<authDtos, Auth>();
    }
}