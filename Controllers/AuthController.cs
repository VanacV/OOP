using System.Net;
using fireflower_backend.Dtos;
using fireflower_backend.Models;
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

        public AuthController(IAuth auth)
        {
            _auth = auth;
        }
        [HttpPost]
        [Route("api/register")]
        public async Task<ActionResult<serviceResponce<authDtos>>> Register(authDtos authDtos)
        {
            return Ok(await _auth.Register(authDtos));
        }

        [HttpPost]
        [Route("api/Login")]
        public async Task<ActionResult<serviceResponce<authDtos>>> Login(authDtos authDtos)
        {
            return Ok(await _auth.Login(authDtos));
        }

    }
}
