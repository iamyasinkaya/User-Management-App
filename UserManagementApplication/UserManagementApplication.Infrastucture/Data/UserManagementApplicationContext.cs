using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagementApplication.Core.Entities;
using UserManagementApplication.Core.Entities.Base;

namespace UserManagementApplication.Infrastucture.Data
{
    public class UserManagementApplicationContext : DbContext
    {
        public UserManagementApplicationContext(DbContextOptions<UserManagementApplicationContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected  override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            

        }
    }
}
