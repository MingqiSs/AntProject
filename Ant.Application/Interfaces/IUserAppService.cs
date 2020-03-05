using Ant.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Application.Interfaces
{
    public interface IUserAppService
    {
        void Register(UserViewModel userViewModel);
        IEnumerable<UserViewModel> GetAll();
        UserViewModel GetById(Guid id);
        void Update(UserViewModel userViewModel);
        void Remove(Guid id);
        IList<UserViewModel> GetAllHistory(Guid id);
    }
}
