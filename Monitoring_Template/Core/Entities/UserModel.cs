using System.ComponentModel.DataAnnotations;

namespace Monitoring_Template.Core.Entities
{
    public class UserModel
    {
        [Key]
        public required string NIK {  get; set; }
        public required string PasswordHash { get; set; }
        public required string Name { get; set; }
    }
}
