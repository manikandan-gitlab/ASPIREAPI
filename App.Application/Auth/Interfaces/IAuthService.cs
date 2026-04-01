namespace App.Application.Auth.Interfaces
{
    public interface IAuthService
    {
        LoginResponseDto Login(LoginRequestDto request);
    }
}