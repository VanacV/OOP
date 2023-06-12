using fireflower_backend.Dtos;
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
        public async Task<authDtos> AddAuth(authDtos auth)
        {
            
            int maxId = _dbContext.Auth.Max(p => p.Id);
            auth.Id = maxId + 1;
            //_dbContext.Auth.Add(auth);
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
