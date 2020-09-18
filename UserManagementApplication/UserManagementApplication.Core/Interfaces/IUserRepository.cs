using System;
using System.Collections.Generic;
using System.Text;
using UserManagementApplication.Core.Entities;
using UserManagementApplication.Core.Interfaces.Base;

namespace UserManagementApplication.Core.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
