using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagementApplication.Core.Entities;
using UserManagementApplication.Core.Interfaces;
using UserManagementApplication.Core.Interfaces.Base;
using UserManagementApplication.Infrastucture.Data;
using UserManagementApplication.Infrastucture.EntitiyFrameworkCore.Repositories;
using UserManagementApplication.Infrastucture.EntitiyFrameworkCore.Repositories.Base;

namespace UserManagementApplication.Infrastucture
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastucture(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserManagementApplicationContext>(options => options.UseSqlServer(configuration.GetConnectionString("UserManagementApplication")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
               .AddEntityFrameworkStores<UserManagementApplicationContext>();

            return services;
        }
    }
}
