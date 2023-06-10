using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Interface
{
    public interface IAuth
    {
        Task<Auth> AddAuth(Auth authorization);
        Task<List<Auth>> GetAllAuth();
    }   
}
