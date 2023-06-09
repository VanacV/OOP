using Microsoft.AspNetCore.Mvc;
using Project.Models.Interface;
using Project.Storage.Entity;

namespace Project.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("user/authorization")]
        public async Task<IActionResult> AddUserFromAuthorization(Authorization authorization)
        {
            try
            {
                await _user.AddUserFromAuthorization(authorization);
                return Ok("Пользователь успешно добавлен.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Произошла ошибка при добавлении пользователя: {ex.Message}");
            }
        }
    }
}
