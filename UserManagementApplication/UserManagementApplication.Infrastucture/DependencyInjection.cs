using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserManagementApplication.Core.Interfaces;
using UserManagementApplication.Core.Interfaces.Base;
using UserManagementApplication.Core.Interfaces.Logger;
using UserManagementApplication.Infrastucture.Data;
using UserManagementApplication.Infrastucture.EntitiyFrameworkCore.Repositories;
using UserManagementApplication.Infrastucture.EntitiyFrameworkCore.Repositories.Base;
using UserManagementApplication.Infrastucture.Logging;

namespace UserManagementApplication.Infrastucture
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastucture(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserManagementApplicationContext>(options => options.UseSqlServer(configuration.GetConnectionString("UserManagementApplication")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));


            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
               .AddEntityFrameworkStores<UserManagementApplicationContext>();

            return services;
        }
    }
}
