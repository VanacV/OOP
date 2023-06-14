using AutoMapper;
using fireflower_backend.Dtos;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using Microsoft.EntityFrameworkCore;
using fireflower_backend.Storage.Entity;
using Microsoft.AspNetCore.Http.HttpResults;

namespace fireflower_backend.Models.Realization
{
    
    public class AuthModel: IAuth
    {
        private readonly MyDbContext _dbContext;
        private readonly IMapper _mapper;

        public AuthModel(MyDbContext dbContext,IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<serviceResponce<authDtos>> Register(authDtos authDtos)
        {
            var serviceResponce = new serviceResponce<authDtos>();

            try
            {
                string password = BCrypt.Net.BCrypt.HashPassword(authDtos.password);
                var newAuth = new Auth
                {
                    email = authDtos.email,
                    password = password
                };
                var newUser = new Users
                {
                    Auth = newAuth,
                    Auth_id = newAuth.Id,
                    email = authDtos.email,
                    password = password
                };
                _dbContext.Auth.Add(newAuth);
                _dbContext.Users.Add(newUser);
                await _dbContext.SaveChangesAsync();
                serviceResponce.Success = true;
                serviceResponce.Message = "Регистрация успешна.";
            }
            catch (Exception ex)
            {
                serviceResponce.Success = false;
                serviceResponce.Message = "Bad";
            }

            return serviceResponce;
        }

        public async Task<serviceResponce<authDtos>> Login(authDtos authDtos)
        {
            var serviceResponce = new serviceResponce<authDtos>();

            try
            {
                var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.email == authDtos.email);
                
                if (user != null && BCrypt.Net.BCrypt.Verify(authDtos.password, user.password))
                {
                    serviceResponce.Success = true;
                    serviceResponce.Message = "Вход выполнен успешно.";
                }
                else
                {
                    serviceResponce.Success = false;
                    serviceResponce.Message = "Неверный email или пароль.";
                }
            }
            catch (Exception ex)
            {
                serviceResponce.Success = false;
                serviceResponce.Message = "Ошибка входа.";
            }

            return serviceResponce;
        }
    }
}
