namespace Monitoring_Template.Application.DTO
{
    public class LoginResponseDTO
    {
        public required string NIK { get; set; }
        public required string Name { get; set; }
        public required string Role { get; set; } // Role User
        public required string Token { get; set; } // JWT Token (jika pakai authentication)
    }
}
