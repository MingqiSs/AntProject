using Ant.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Domain.Events
{
  public  class UserRegisteredEvent:Event
    {
        public UserRegisteredEvent(Guid id, string name, string email, DateTime createTime)
        {
            Id = id;
            Name = name;
            Email = email;
            CreateTime = createTime;
            AggregateId = id;
        }
        public Guid Id { get; set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public DateTime CreateTime { get; private set; }
    }
}
