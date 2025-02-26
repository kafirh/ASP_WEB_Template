using System;
using Microsoft.EntityFrameworkCore;
using Monitoring_Template.Application.Services;
using Monitoring_Template.Application.Services.Interface;
using Monitoring_Template.Core.Interfaces;
using Monitoring_Template.Infrastructure.Auth;
using Monitoring_Template.Infrastructure.Persistence;
using Monitoring_Template.Infrastructure.Persistence.Repository;

namespace Monitoring_Template.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            // Registrasi DatabaseContext
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(connectionString));

            // Registrasi repository agar bisa digunakan di Application Layer
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>(); 
            services.AddScoped<IRoleRepository, RoleRepository>(); 
            services.AddScoped<IResultPackingLabelRepository, ResultPackingLabelRepository>();

            // Registrasi untuk mengakses HttpContext (dibutuhkan untuk CookieAuth)
            services.AddHttpContextAccessor();

            // Registrasi Auth Session Service untuk menangani login menggunakan Cookie
            services.AddScoped<IAuthSessionService, CookieAuthService>();

            //  Registrasi Auth Service
            services.AddScoped<IAuthService,AuthService>();
            services.AddScoped<IHomeService,HomeService>();



            return services;
        }
    }
}
