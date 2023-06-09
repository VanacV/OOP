using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Interface
{
    public interface IAuth
    {
        Task<IList<Auth>> OutData();//Вывод БД Авторизация
        Task AddAuth(Auth authorization);
        Task<Users> GetUserByAuth(string email, string password);
        Task CheckMethod();
    }
}
