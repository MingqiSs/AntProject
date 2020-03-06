using Ant.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Domain.Validations
{
    public class RegisterNewUserCommandValidation : UserValidation<RegisterNewUserCommand>
    {
        public RegisterNewUserCommandValidation()
        {
            ValidateName();
            ValidateEmail();
        }
    }
}
