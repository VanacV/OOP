using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using Microsoft.EntityFrameworkCore;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Realization
{
    
    public class AuthModel: IAuth
    {
        private readonly MyDbContext _dbContext;
        public AuthModel(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Auth> AddAuth(Auth auth)
        {
           
            int maxUserId= _dbContext.Users.Max(p => p.id);
            var user = new Users
            {
                id = maxUserId+1,
                password = auth.password,
                email = auth.email,
                Auth_id = auth.Id+1
            };
            auth.Users = user;
            int maxId = _dbContext.Auth.Max(p => p.Id);
            auth.Id = maxId + 1;
            _dbContext.Auth.Add(auth);
            await _dbContext.SaveChangesAsync();
            return auth;
        }

        public async Task<List<Auth>> GetAllAuth()
        {
            List<Auth> auth = await _dbContext.Auth.ToListAsync();
            return auth;
        }
    }
}
