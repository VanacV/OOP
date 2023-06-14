using fireflower_backend.Dtos;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Interface
{
    public interface IAuth
    {
        Task<serviceResponce<authDtos>> Register(authDtos authDtos);
        Task<serviceResponce<authDtos>> Login(authDtos authDtos);
    }   
}
    