using Monitoring_Template.Application.DTO;

namespace Monitoring_Template.Application.Services.Interface
{
    public interface IAuthService
    {
        Task<bool> LoginAsync(LoginRequestDTO request);
        Task LogoutAsync();
    }
}
