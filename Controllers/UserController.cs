using System.Net;
using fireflower_backend.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using fireflower_backend.Storage.Entity;
using Auth = fireflower_backend.Storage.Entity.Auth;

namespace Project.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }
        
        [HttpPost]
        [Route("user/authorization")]
        public async Task<IActionResult> AddUserFromAuth(Auth authorization)
        {
            try
            {
                await _user.AddUserFromAuth(authorization);
                return Ok("Пользователь успешно добавлен.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Произошла ошибка при добавлении пользователя: {ex.Message}");
            }
        }
    }
}
