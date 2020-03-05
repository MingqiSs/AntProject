using Ant.Application.Interfaces;
using Ant.Application.ViewModels;
using Ant.Domain.Commands;
using Ant.Domain.Core.Bus;
using Ant.Domain.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Application.Services
{
    public class UserAppService : IUserAppService
    {
        //数据库操作
        public IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _bus;
        public UserAppService(IUserRepository userRepository, IMapper mapper, IMediatorHandler bus) {
            _userRepository = userRepository;
            _mapper = mapper;
            _bus = bus;
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
            return _mapper.Map<UserViewModel>(_userRepository.GetById(id));
        }

        public void Register(UserViewModel userViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewUserCommand>(userViewModel);
            _bus.SendCommand(registerCommand);
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
