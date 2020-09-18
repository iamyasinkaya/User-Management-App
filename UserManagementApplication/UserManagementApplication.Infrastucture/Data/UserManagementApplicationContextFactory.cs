using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementApplication.Infrastucture.Data
{
    public class UserManagementApplicationContextFactory : IDesignTimeDbContextFactory<UserManagementApplicationContext>
    {
        public UserManagementApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UserManagementApplicationContext>();

            optionsBuilder.UseSqlServer("Data Source=LAPTOP-238S8LGK\\MSSQLSERVER1;Initial Catalog=UserManagementDb;Integrated Security=True");
            return new UserManagementApplicationContext(optionsBuilder.Options);
        }
    }
}
