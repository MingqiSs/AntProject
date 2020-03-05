using Ant.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Domain.Commands
{
   public abstract class UserCommand : Command
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected set; }

        public string Email { get; protected set; }
     
    }
}
