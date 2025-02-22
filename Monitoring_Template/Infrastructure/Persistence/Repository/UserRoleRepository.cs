using Microsoft.EntityFrameworkCore;
using Monitoring_Template.Core.Entities;
using Monitoring_Template.Core.Interfaces;

namespace Monitoring_Template.Infrastructure.Persistence.Repository
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly DatabaseContext _databaseContext;
        public UserRoleRepository(DatabaseContext databaseContext) 
        {
            _databaseContext = databaseContext;
        }

        public async Task<UserRoleModel?> GetUserRoleModelByNIK(string NIKName)
        {
           return await _databaseContext.AspNetUserRole
                .FirstOrDefaultAsync(ur => ur.UserNik == NIKName);
        }
    }
}
