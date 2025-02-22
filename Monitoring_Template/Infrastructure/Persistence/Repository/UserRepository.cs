using Microsoft.EntityFrameworkCore;
using Monitoring_Template.Core.Entities;
using Monitoring_Template.Core.Interfaces;

namespace Monitoring_Template.Infrastructure.Persistence.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _databaseContext;
        public UserRepository(DatabaseContext databaseContext) 
        {
            _databaseContext = databaseContext;
        }

        public async Task<UserModel?> GetUserByNIK(string NIKName)
        {
            return await _databaseContext.AspNetUsers
                .FirstOrDefaultAsync(user => user.NIK == NIKName);
        }
    }
}
