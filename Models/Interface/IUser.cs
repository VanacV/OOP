using System.Net;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage.Entity;
using Auth = fireflower_backend.Storage.Entity.Auth;

namespace fireflower_backend.Models.Interface
{
    public interface IUser
    {
        Task AddUser(Users users);
        Task AddUserFromAuth(Auth authorization);
    }
}
