using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserManagementApplication.Core.Entities.Base;

namespace UserManagementApplication.Core.Interfaces.Base
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Create(T entity);

        Task<T> Update(T entity);

        Task<T> Delete(int id);

        Task<T> GetById(int id);
    }
}
