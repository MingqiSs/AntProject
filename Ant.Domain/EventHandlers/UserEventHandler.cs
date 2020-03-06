using Ant.Domain.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ant.Domain.EventHandlers
{
    public class UserEventHandler :
          INotificationHandler<UserRegisteredEvent>
    {
        public Task Handle(UserRegisteredEvent notification, CancellationToken cancellationToken)
        {
            // Send some notification e-mail

            return Task.CompletedTask;
        }
    }
}
