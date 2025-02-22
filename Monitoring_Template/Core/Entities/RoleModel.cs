using System.ComponentModel.DataAnnotations;

namespace Monitoring_Template.Core.Entities
{
    public class RoleModel
    {
        [Key]
        public required string Id { get; set; }
        required public string Name { get; set; }
    }
}
