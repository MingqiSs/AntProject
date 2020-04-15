using Ant.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ant.Application.Interfaces
{
    public interface IUserAppService
    {
        Task<bool> Register(UserViewModel userViewModel);
        IEnumerable<UserViewModel> GetAll();
        UserViewModel GetById(Guid id);
        void Update(UserViewModel userViewModel);
        void Remove(Guid id);
        IList<UserViewModel> GetAllHistory(Guid id);
    }
}
