using AutoMapper;
using fireflower_backend.Dtos;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Realization
{
   public class MallingModel:IMalling
   {
      private MyDbContext _dbContext;
      private IMapper _mapper;

      public MallingModel(MyDbContext dbContext,IMapper mapper)
      {
         _dbContext = dbContext;
         _mapper = mapper;
      }
      public async Task<serviceResponce<userMailingDtos>> AddMailing(userMailingDtos userMailingDtos)
      {
         var serviceResponse = new serviceResponce<userMailingDtos>();
         try
         {
            var mailing = _mapper.Map<Users_With_Mailing>(userMailingDtos);

            _dbContext.Users_Withs_Mailing.Add(mailing);
            await _dbContext.SaveChangesAsync();

            serviceResponse.Data = new List<userMailingDtos> { _mapper.Map<userMailingDtos>(mailing) };
            serviceResponse.Success = true;
            serviceResponse.Message = "mailing added successfully.";
         }
         catch (Exception ex)
         {
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
            Exception innerException = ex.InnerException;
            while (innerException != null)
            {
               Console.WriteLine(innerException.Message);
               innerException = innerException.InnerException;
            }
         }
         return serviceResponse;
      }
   }
}
