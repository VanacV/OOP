using System.Net;
using Project.Storage.Entity;

namespace fireflower_backend.Models.Interface
{
    public interface IAuthorization
    {
        Task<IList<Authorization>> OutData();//Вывод БД Авторизация
        Task AddAuthorization(Authorization authorization);
        // Task<Users> GetUserByAuthorization(string email, string password);
        Task CheckMethod();
    }
}
