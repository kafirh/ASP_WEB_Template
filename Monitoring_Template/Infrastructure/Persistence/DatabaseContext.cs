using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Monitoring_Template.Core.Entities;

namespace Monitoring_Template.Infrastructure.Persistence
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        // Tambahkan DbSet agar bisa diakses dari repository
        public DbSet<UserModel> AspNetUsers { get; set; }
        public DbSet<RoleModel> AspNetRoles { get; set; }
        public DbSet<UserRoleModel> AspNetUserRole { get; set; }
    }
}
