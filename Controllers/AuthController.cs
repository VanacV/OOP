using System.Net;
using fireflower_backend.Models.Interface;
using fireflower_backend.Storage;
using Microsoft.AspNetCore.Mvc;
using fireflower_backend.Storage.Entity;
using Auth = fireflower_backend.Storage.Entity.Auth;

namespace fireflower_backend.Controllers
{
    public class AuthController : Controller
    {
        private readonly MyDbContext _dbContext;
        private readonly IAuth _auth;

        public AuthController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost]
        [Route("authorizations/api/data")]
        public async Task<IActionResult> AddAuth( Auth authorization)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(authorization.email) || string.IsNullOrWhiteSpace(authorization.password))
                {
                    return BadRequest("Login and password are required.");
                }

                _dbContext.Auth.Add(authorization);
                await _dbContext.SaveChangesAsync();

                return Ok(authorization);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while adding the authorization: {ex.Message}");
            }
        }
        [HttpGet]
        [Route("auth/api/out")]
        public async Task<ActionResult<List<Auth>>> GetAllAuth()
        {
            try
            {
                List<Auth> auths = await _auth.GetAllAuth();
                return auths;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed" + ex.Message);
            }
        }
    }
}
