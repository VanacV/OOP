using fireflower_backend.Dtos;
using fireflower_backend.Models;
using fireflower_backend.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Auth = fireflower_backend.Storage.Entity.Auth;

namespace fireflower_backend.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser _user;

        public UserController(IUser user)
        {
            _user = user;
        }
        [HttpGet("api/getData")]
        public async Task<ActionResult<serviceResponce<userDtos>>> getData()
        {
            return Ok(await _user.getData());
        }
    }
}
