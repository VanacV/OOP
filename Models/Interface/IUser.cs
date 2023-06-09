using Project.Storage.Entity;

namespace Project.Models.Interface
{
    public interface IUser
    {
        Task AddUser(Users users);
        Task AddUserFromAuthorization(Authorization authorization);
    }
}
