using Monitoring_Template.Core.Entities;

namespace Monitoring_Template.Core.Interfaces
{
    public interface IRoleRepository
    {
        public Task<RoleModel?> GetRoleModelById(string roleId);
    }
}
