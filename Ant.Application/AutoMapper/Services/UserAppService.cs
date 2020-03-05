using Ant.Application.Interfaces;
using Ant.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Application.AutoMapper.Services
{
    public class UserAppService : IUserAppService
    {
        public IEnumerable<UserViewModel> GetAll()
        {
            return new List<UserViewModel>()
            {
                new UserViewModel
                { Id=Guid.NewGuid(),
                  BirthDate=DateTime.Now,
                  Email="1111",Name="ant"
                }
            };
        }

        public IList<UserViewModel> GetAllHistory(Guid id)
        {
            throw new NotImplementedException();
        }

        public UserViewModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Register(UserViewModel userViewModel)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserViewModel userViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
