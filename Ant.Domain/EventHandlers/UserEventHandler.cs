using Ant.Domain.Events;
using DotNetCore.CAP;
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
        ICapPublisher _capPublisher;
        public UserEventHandler(ICapPublisher capPublisher)
        {
            _capPublisher = capPublisher;
        }
        public async Task Handle(UserRegisteredEvent notification, CancellationToken cancellationToken)
        {
            // Send some notification e-mail
            await _capPublisher.PublishAsync("OrderCreated", DateTime.Now);
          
        }
    }
}
