using Project.Storage.Entity;

namespace Project.Models.Interface
{
    public interface IAuthorization
    {
        Task<IList<Authorization>> OutData();//Вывод БД Авторизация
        Task AddAuthorization(Authorization authorization);
        Task<Users> GetUserByAuthorization(string email, string password);
    }
}
