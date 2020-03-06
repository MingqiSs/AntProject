using Ant.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Ant.Infra.Data.EventStore
{
    public class SqlEventStore : IEventStore
    {
        //private readonly IEventStoreRepository _eventStoreRepository;
        //private readonly IUser _user;

        public SqlEventStore()
        {
           // _eventStoreRepository = eventStoreRepository;
            //_user = user;
        }

        public void Save<T>(T theEvent) where T : Event
        {
            //var serializedData = JsonSerializer.Serialize(theEvent);

            //var storedEvent = new StoredEvent(
            //    theEvent,
            //    serializedData
            //    );

            //_eventStoreRepository.Store(storedEvent);
        }
    }
}
