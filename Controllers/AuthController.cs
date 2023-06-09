using System.Net;
using fireflower_backend.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using fireflower_backend.Storage.Entity;
using Auth = fireflower_backend.Storage.Entity.Auth;

namespace fireflower_backend.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuth _authorization;

        public AuthController(IAuth authorization)
        {
            _authorization = authorization;
        }

        [HttpGet]
        [Route("authorization")]
        public async Task<IActionResult> GetAuths()
        {
            try
            {
                IList<Auth> authorizations = await _authorization.OutData();
                return Ok(authorizations);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
        [HttpPost]
        [Route("authorizations/api/data")]
        public async Task<IActionResult> AddAuth([FromBody] Auth authorization)
        {
            await _authorization.AddAuth(authorization);
            return Ok();
        }

        [HttpGet]

        public async Task<IActionResult> GetUserByAuth(string email, string password)
        {
            // var user = await _authorization.GetUserByAuth(email, password);
            // if (user == null)
            // {
            //     return NotFound();
            // }

            return Ok();
        }
        [HttpPost]
        [Route("authorizations/manual")]
        public async Task<IActionResult> AddAuthManually()
        {
            // var authorization = new Auth
            // {
            //     email = "AHAHAH@exampl3e.com",
            //     password = "DASDSA",
            // };
            try
            {
                // await _authorization.AddAuth(authorization);
               

                return Ok("Данные успешно добавлены в базу данных.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Произошла ошибка при добавлении данных в базу данных: {ex.Message}");

            }
        }

        [HttpGet]
        [Route("checkin")]

        public async Task<IActionResult> CheckMethod()
        {
            await _authorization.CheckMethod();
            try
            {
                return Ok("ok");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "ЕРОР БЛЯТЬ");
            }
        }
        
    }
}
