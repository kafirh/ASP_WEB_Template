using Monitoring_Template.Application.DTO;
using Monitoring_Template.Application.Services.Interface;
using Monitoring_Template.Core.Interfaces;

namespace Monitoring_Template.Application.Services
{
    public class AuthService: IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IAuthSessionService _authSessionService;

        public AuthService(
            IUserRepository userRepository,
            IUserRoleRepository userRoleRepository,
            IRoleRepository roleRepository,
            IAuthSessionService authSessionService) // Inject CookieAuthService
        {
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _roleRepository = roleRepository;
            _authSessionService = authSessionService;
        }
        public async Task<bool> LoginAsync(LoginRequestDTO request)
        {
            // 1. Ambil user berdasarkan NIK
            var user = await _userRepository.GetUserByNIK(request.NIK);
            if (user == null) return false;

            // 2. Validasi password
            if (!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash)) return false;

            // 3. Ambil Role User
            var userRole = await _userRoleRepository.GetUserRoleModelByNIK(user.NIK);
            if (userRole == null) return false;

            var role = await _roleRepository.GetRoleModelById(userRole.RoleId);
            if (role == null) return false;

            // 4. Simpan session dengan claims menggunakan CookieAuthService
            await _authSessionService.SignInAsync(user.NIK, user.Name, role.Name);

            return true; // Login berhasil
        }

        public async Task LogoutAsync()
        {
            await _authSessionService.SignOutAsync();
        }
    }
}
