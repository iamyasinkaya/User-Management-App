using AutoMapper;
using AutoMapper.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagementApplication.Application.Interfaces;
using UserManagementApplication.Application.Services;

namespace UserManagementApplication.Application
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
           
            

            return services;
        }
    }
}
