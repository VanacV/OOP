using Microsoft.AspNetCore.Mvc;
using Project.Models.Interface;
using Project.Storage.Entity;

namespace Project.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly IAuthorization _authorization;

        public AuthorizationController(IAuthorization authorization)
        {
            _authorization = authorization;
        }

        [HttpGet]
        [Route("authorizations")]
        public async Task<IActionResult> GetAuthorizations()
        {
            try
            {
                IList<Authorization> authorizations = await _authorization.OutData();
                return Ok(authorizations);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
        [HttpPost]
        [Route("authorizations/api/data")]
        public async Task<IActionResult> AddAuthorization([FromBody] Authorization authorization)
        {
            await _authorization.AddAuthorization(authorization);
            return Ok();
        }

        [HttpGet]

        public async Task<IActionResult> GetUserByAuthorization(string email, string password)
        {
            var user = await _authorization.GetUserByAuthorization(email, password);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
        [HttpPost]
        [Route("authorizations/manual")]
        public async Task<IActionResult> AddAuthorizationManually()
        {
            var authorization = new Authorization
            {
                email = "AHAHAH@exampl3e.com",
                password = "DASDSA",
            };
            try
            {
                await _authorization.AddAuthorization(authorization);
               

                return Ok("Данные успешно добавлены в базу данных.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Произошла ошибка при добавлении данных в базу данных: {ex.Message}");

            }
        }
    }
}
