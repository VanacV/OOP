using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;

namespace fireflower_backend.Models.Realization
{
    public class PaymentModel:IPayment
    {
        private MyDbContext _dbContext;

        public PaymentModel(MyDbContext myDbContext)
        {
            _dbContext = myDbContext;
        }
        public async Task<Payment> AddPayment(Payment payment)
        {
            int maxId = _dbContext.Payment.Max(p => p.Id);
            payment.Id = maxId + 1;
            _dbContext.Payment.Add(payment);
            await _dbContext.SaveChangesAsync();
            return payment;
        }
    }
}
