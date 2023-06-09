using Microsoft.EntityFrameworkCore;
using Project.Models.Interface;
using Project.Storage;
using Project.Storage.Entity;

namespace Project.Models.Realization
{
    public class AuthorizationModel : IAuthorization
    {
        private readonly MyDbContext _dbContext;
        
        public AuthorizationModel(MyDbContext dbContext, MyDbContext userContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAuthorization(Authorization authorization)
        {
            _dbContext.Authorization.Add(authorization);
            await _dbContext.SaveChangesAsync();
            var user = new Users
            {
                email = authorization.email,
                password = authorization.password,
            };
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }
       
        public async Task<Users> GetUserByAuthorization(string email, string password)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.email == email && u.password == password);
        }

        public async Task<IList<Authorization>> OutData()
        {
            return await _dbContext.Authorization.ToListAsync();
        }
       

    }
}
