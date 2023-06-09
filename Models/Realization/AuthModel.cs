using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using Microsoft.EntityFrameworkCore;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Realization
{
    public class AuthModel: IAuth
    {
        private readonly MyDbContext _dbContext;
        private IAuth _authorizationImplementation;

        public AuthModel(MyDbContext dbContext, MyDbContext userContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAuth(Auth authorization)
        {
            _dbContext.Auth.Add(authorization);
            await _dbContext.SaveChangesAsync();
            // var user = new Users
            // {
            //     email = authorization.email,
            //     password = authorization.password,
            // };
            // _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public Task<Users> GetUserByAuth(string email, string password)
        {
            throw new NotImplementedException();
        }

        Task<IList<Auth>> IAuth.OutData()
        {
            return OutData();
        }

        Task IAuth.AddAuth(Auth authorization)
        {
            return AddAuth(authorization);
        }

        public Task CheckMethod()
        {
            throw new NotImplementedException();
        }

        // public async Task<Users> GetUserByAuth(string email, string password)
        // {
        //     // return await _dbContext.Users.FirstOrDefaultAsync(u => u.email == email && u.password == password);
        // }

        public async Task<IList<Auth>> OutData()
        {
            return await _dbContext.Auth.ToListAsync();
        }
       

    }
}
