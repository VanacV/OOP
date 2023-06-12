using fireflower_backend.Dtos;
using fireflower_backend.Storage.Entity;
using Project.Models;

namespace fireflower_backend.Models.Interface
{
    public interface IPayment
    {
        Task<serviceResponce<paymentDtos>> AddPayment(paymentDtos newPayment);
    }
}
