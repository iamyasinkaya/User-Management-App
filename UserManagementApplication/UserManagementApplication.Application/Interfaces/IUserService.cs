using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserManagementApplication.Application.Models;

namespace UserManagementApplication.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserModel>> GetAll();

        Task<UserModel> CreateAsync(UserModel userModel);

        Task<UserModel> GetByIdAsync(UserModel userModel);

        Task<UserModel> DeleteAsync(UserModel userModel);

        Task<UserModel> UpdateAsync(UserModel userModel);
    }
}
