using AutoMapper;
using fireflower_backend.Dtos;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace fireflower_backend.Models.Realization
{
    public class UserModel : IUser
    {
        private readonly MyDbContext _dbContext;
        private readonly IMapper _mapper;
        public UserModel(MyDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
            public async Task<serviceResponce<userDtos>> getData()
            {
                var service = new serviceResponce<userDtos>();
                try
                {
                    var dbUserData = await _dbContext.Users.ToListAsync();
                    service.Data = dbUserData.Select(c => _mapper.Map<userDtos>(c)).ToList();
                    service.Success = true;
                    service.Message = "Данные успешно получены.";
                }
                catch (Exception ex)
                {
                    service.Success = false;
                    service.Message = "Ошибка при получении данных: " + ex.Message;
                }
        
                return service;
            }
    }
}
