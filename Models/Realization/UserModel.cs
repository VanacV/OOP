using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Realization
{
    public class UserModel : IUser
    {
        private readonly MyDbContext _dbcontext;
        public UserModel(MyDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task AddUser(Users users)
        {
           _dbcontext.Users.Add(users);
            await _dbcontext.SaveChangesAsync();  
        }

        public async Task AddUserFromAuth(Auth authorization)
        {
            var user = new Users
            {
                email = authorization.email,
               // password = authorization.password
                // Дополнительные поля для заполнения
            };

            // Добавление пользователя в базу данных
            _dbcontext.Users.Add(user);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
