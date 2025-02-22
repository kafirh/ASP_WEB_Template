using Microsoft.EntityFrameworkCore;
using Monitoring_Template.Core.Entities;
using Monitoring_Template.Core.Interfaces;

namespace Monitoring_Template.Infrastructure.Persistence.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DatabaseContext _databaseContext;
        public RoleRepository(DatabaseContext databaseContext) 
        {
            _databaseContext = databaseContext;
        }

        public async Task<RoleModel?> GetRoleModelById(string roleId)
        {
            return await _databaseContext.AspNetRoles
                .FirstOrDefaultAsync(r => r.Id == roleId);
        }
    }
}
