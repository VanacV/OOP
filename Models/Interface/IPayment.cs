using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Interface
{
    public interface IPayment
    {
        Task<Payment> AddPayment(Payment payment);
    }
}
