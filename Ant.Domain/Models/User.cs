using Ant.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Domain.Models
{
    public class User : Entity
    {
        public User(Guid id, string name, string email, DateTime createTime)
        {
            Id = id;
            Name = name;
            Email = email;
            CreateTime = createTime;
        }

        // Empty constructor for EF
        protected User() { }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public DateTime CreateTime { get; private set; }
    }
}
