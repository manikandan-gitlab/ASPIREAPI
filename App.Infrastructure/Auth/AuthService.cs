using App.Application.Auth.Interfaces;
using App.Application.Identity.DTOs;

namespace App.Infrastructure.Auth
{
    public class AuthService : IAuthService
    {
        public LoginResponseDto Login(LoginRequestDto request)
        {
            if(request.UserName == "Admin" && request.Password == "Admin@123")
            {
                return new LoginResponseDto{
                    Token = "dummy-jwt-token",
                    Message = "Login Success"
                };
            }

            return new LoginResponseDto{
                Token = null,
                Message = "Invalid Credentials"
            };
        }
    }
}