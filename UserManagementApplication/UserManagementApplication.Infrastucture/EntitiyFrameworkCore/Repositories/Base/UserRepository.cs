using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserManagementApplication.Core.Entities;
using UserManagementApplication.Core.Interfaces;
using UserManagementApplication.Infrastucture.Data;

namespace UserManagementApplication.Infrastucture.EntitiyFrameworkCore.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManagementApplicationContext _userManagementApplicationContext;

        public UserRepository(UserManagementApplicationContext userManagementApplicationContext)
        {
            _userManagementApplicationContext = userManagementApplicationContext ?? throw new ArgumentNullException(nameof(userManagementApplicationContext));
        }

        public async Task<User> Create(User entity)
        {
            await _userManagementApplicationContext.Users.AddAsync(entity);
            await _userManagementApplicationContext.SaveChangesAsync();

            return entity;
        }

        public async Task<User> Delete(int id)
        {
            var entity = await _userManagementApplicationContext.Users.FindAsync(id);
            _userManagementApplicationContext.Users.Remove(entity);
            await _userManagementApplicationContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _userManagementApplicationContext.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _userManagementApplicationContext.Users.FindAsync(id);
        }

        public async Task<User> Update(User entity)
        {
            _userManagementApplicationContext.Entry(entity).State = EntityState.Modified;
            await _userManagementApplicationContext.SaveChangesAsync();
            return entity;
        }
    }
}
