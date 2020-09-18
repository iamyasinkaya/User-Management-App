using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserManagementApplication.Core.Entities.Base;
using UserManagementApplication.Core.Interfaces.Base;
using UserManagementApplication.Infrastucture.Data;

namespace UserManagementApplication.Infrastucture.EntitiyFrameworkCore.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly UserManagementApplicationContext _userManagementApplicationContext;

        public Repository(UserManagementApplicationContext userManagementApplicationContext)
        {
            _userManagementApplicationContext = userManagementApplicationContext ?? throw new ArgumentNullException(nameof(userManagementApplicationContext));
        }

        public async Task<T> Create(T entity)
        {
            await _userManagementApplicationContext.Set<T>().AddAsync(entity);

            await _userManagementApplicationContext.SaveChangesAsync();

            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await _userManagementApplicationContext.Set<T>().FindAsync(id);

             _userManagementApplicationContext.Set<T>().Remove(entity);
            await _userManagementApplicationContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _userManagementApplicationContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _userManagementApplicationContext.Set<T>().FindAsync(id);
        }

        public async Task<T> Update(T entity)
        {
            _userManagementApplicationContext.Entry(entity).State = EntityState.Modified;
            await _userManagementApplicationContext.SaveChangesAsync();
            return entity;
        }
    }
}
