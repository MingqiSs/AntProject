using Ant.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByEmail(string email);
    }
}
