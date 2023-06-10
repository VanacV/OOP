using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace fireflower_backend.Controllers
{
    public class PaymentController : Controller
    {
        
        private readonly MyDbContext _dbContext;

        public PaymentController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("api/payment")]
        public async Task<IActionResult> AddPayment([FromBody] Payment payment)
        {
            try
            {
                _dbContext.Payment.Add(payment);
                await _dbContext.SaveChangesAsync();
            
                return Ok(payment);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while adding the payment: {ex.Message}");
            }
        }
    }
}
