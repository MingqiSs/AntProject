using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Domain.Commands
{
    public class RegisterNewUserCommand : UserCommand
    {
        public RegisterNewUserCommand(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override bool IsValid()
        {
            //ValidationResult = new RegisterNewCustomerCommandValidation().Validate(this);
            //return ValidationResult.IsValid;
            return true;
        }
    }
}
