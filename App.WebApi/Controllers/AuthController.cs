
//using  Microsft.
using Microsoft.AspNetCore.Mvc;
using App.Application.Identity.DTOs;
using App.Application.Auth.Interfaces;

namespace App.WebApi.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequestDto request)
        {
            var response = _authService.Login(request);

            if(response.Token == null)
                return Unauthorized(response);

            return Ok(response);
        }
    }
}
