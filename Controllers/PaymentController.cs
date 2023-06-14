using fireflower_backend.Dtos;
using fireflower_backend.Models;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using fireflower_backend.Storage.Entity;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace fireflower_backend.Controllers
{
    public class PaymentController : Controller
    {

        private readonly IPayment _payment;

        public PaymentController(IPayment payment)
        {
            _payment = payment;
        }

        [HttpPost("api/addPayment")]
        public async Task<ActionResult<serviceResponce<paymentDtos>>> AddPayment([FromBody] paymentDtos newPayment)
        {
            return Ok(await _payment.AddPayment(newPayment));
        }
    }
}

