using Monitoring_Template.Core.Entities;

namespace Monitoring_Template.Core.Interfaces
{
    public interface IUserRoleRepository
    {
        public Task<UserRoleModel?> GetUserRoleModelByNIK (string NIKName);
    }
}
