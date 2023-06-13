global using Project.Models;
using System.Runtime.CompilerServices;
using AutoMapper;
using fireflower_backend.Controllers;
using fireflower_backend.Dtos;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;
using Microsoft.EntityFrameworkCore;


namespace fireflower_backend.Models.Realization
{
    
    public class PaymentModel:IPayment
    {
        private MyDbContext _dbContext;
        private readonly IMapper _mapper;
        
        public PaymentModel(MyDbContext myDbContext,IMapper mapper)
        {
            _dbContext = myDbContext;
            _mapper = mapper;
        }

        public PaymentModel(IMapper mapper )
        {
            _mapper = mapper;   
        }
        public async Task<serviceResponce<paymentDtos>> AddPayment(paymentDtos newPayment)
        {
            var serviceResponse = new serviceResponce<paymentDtos>();
            try
            {
                var payment = _mapper.Map<Payment>(newPayment);

                _dbContext.Payment.Add(payment);
                await _dbContext.SaveChangesAsync();

                serviceResponse.Data = new List<paymentDtos> { _mapper.Map<paymentDtos>(payment) };
                serviceResponse.Success = true;
                serviceResponse.Message = "Payment added successfully.";
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
