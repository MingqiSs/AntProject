using Ant.Domain.Commands;
using Ant.Domain.Core.Bus;
using Ant.Domain.Core.Notifications;
using Ant.Domain.Events;
using Ant.Domain.Interfaces;
using Ant.Domain.Models;
using Equinox.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ant.Domain.CommandHandlers
{
    public class UserCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMediatorHandler Bus;
        public UserCommandHandler(IUserRepository userRepository,
                                  IUnitOfWork uow,
                                  IMediatorHandler bus,
                                  INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
            _userRepository = userRepository;
            Bus = bus;
        }
        public Task<bool> Handle(RegisterNewUserCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }
            var user = new User(Guid.NewGuid(), message.Name, message.Email,DateTime.Now);

            if (_userRepository.GetByEmail(user.Email) != null)
            {
                Bus.RaiseEvent(new DomainNotification(message.MessageType, "The customer e-mail has already been taken."));
                return Task.FromResult(false);
            }

            _userRepository.Add(user);

            if (Commit())
            {
               Bus.RaiseEvent(new UserRegisteredEvent(user.Id, user.Name, user.Email, user.CreateTime));
            }
            return Task.FromResult(true);
        }
    }
}
