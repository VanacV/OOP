using fireflower_backend.Dtos;
using fireflower_backend.Models;
using fireflower_backend.Models.Interface;
using Microsoft.AspNetCore.Mvc;

namespace fireflower_backend.Controllers
{
    public class MallingController : Controller
    {
        private readonly IMalling _malling;

        public MallingController(IMalling malling)
        {
            _malling = malling;
        }

        [HttpPost("api/mailing")]
        public async Task<ActionResult<serviceResponce<userMailingDtos>>> AddMailing(userMailingDtos userMailingDtos)
        {
            return Ok(await _malling.AddMailing(userMailingDtos));
        }
    }
}
