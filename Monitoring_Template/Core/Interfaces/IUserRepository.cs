using Monitoring_Template.Core.Entities;

namespace Monitoring_Template.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<UserModel?> GetUserByNIK (string NIKName);
    }
}
