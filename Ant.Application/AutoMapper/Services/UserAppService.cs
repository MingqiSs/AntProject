using Ant.Application.Interfaces;
using Ant.Application.ViewModels;
using Ant.Domain.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Application.AutoMapper.Services
{
    public class UserAppService : IUserAppService
    {
        //数据库操作
        public IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserAppService(IUserRepository userRepository, IMapper mapper) {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public IEnumerable<UserViewModel> GetAll()
        {
            return _userRepository.GetAll().ProjectTo<UserViewModel>(_mapper.ConfigurationProvider);
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
