using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagementApplication.Core.Entities;
using UserManagementApplication.Core.Entities.Base;

namespace UserManagementApplication.Infrastucture.Data
{
    public class UserManagementApplicationContext : IdentityDbContext
    {
        public UserManagementApplicationContext(DbContextOptions<UserManagementApplicationContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected  override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
