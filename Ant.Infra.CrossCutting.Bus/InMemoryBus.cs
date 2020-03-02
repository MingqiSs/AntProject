using Ant.Domain.Core.Bus;
using Ant.Domain.Core.Commands;
using Ant.Domain.Core.Events;
using MediatR;
using System;
using System.Threading.Tasks;

namespace Ant.Infra.CrossCutting.Bus
{
    public class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;
        private readonly IEventStore _eventStore;
        public InMemoryBus(IEventStore eventStore, IMediator mediator)
        {
            _eventStore = eventStore;
            _mediator = mediator;
        }
        public Task RaiseEvent<T>(T @event) where T : Event
        {
            if (!@event.MessageType.Equals("DomainNotification"))
                _eventStore?.Save(@event);

            return _mediator.Publish(@event);
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}
