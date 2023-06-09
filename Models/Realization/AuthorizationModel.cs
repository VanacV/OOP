using System.Net;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Realization
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
            // var user = new Users
            // {
            //     email = authorization.email,
            //     password = authorization.password,
            // };
            // _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public Task CheckMethod()
        {
            throw new NotImplementedException();
        }

        // public async Task<Users> GetUserByAuthorization(string email, string password)
        // {
        //     // return await _dbContext.Users.FirstOrDefaultAsync(u => u.email == email && u.password == password);
        // }

        public async Task<IList<Authorization>> OutData()
        {
            return await _dbContext.Authorization.ToListAsync();
        }
       

    }
}
