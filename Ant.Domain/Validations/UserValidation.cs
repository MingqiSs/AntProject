using Ant.Domain.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Domain.Validations
{
    public abstract class UserValidation<T> : AbstractValidator<T> where T : UserCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Please ensure you have entered the Name")
                .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");
        }

        //protected void ValidateBirthDate()
        //{
        //    RuleFor(c => c.BirthDate)
        //        .NotEmpty()
        //        .Must(HaveMinimumAge)
        //        .WithMessage("The customer must have 18 years or more");
        //}

        protected void ValidateEmail()
        {
            RuleFor(c => c.Email)
                .NotEmpty()
                .EmailAddress();
        }

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }

        protected static bool HaveMinimumAge(DateTime birthDate)
        {
            return birthDate <= DateTime.Now.AddYears(-18);
        }
    }
}
