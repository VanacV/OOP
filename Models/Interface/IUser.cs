using System.Net;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Interface
{
    public interface IUser
    {
        Task AddUser(Users users);
        Task AddUserFromAuthorization(Authorization authorization);
    }
}
