using App.Application.Identity.DTOs;

namespace App.Application.Auth.Interfaces
{
    public interface IAuthService
    {
        LoginResponseDto Login(LoginRequestDto request);
    }
}