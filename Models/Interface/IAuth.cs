using fireflower_backend.Dtos;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Interface
{
    public interface IAuth
    {
        Task<authDtos> AddAuth(authDtos authorization);
        Task<List<Auth>> GetAllAuth();
    }   
}
