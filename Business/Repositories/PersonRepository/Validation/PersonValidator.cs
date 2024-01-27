using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.PersonRepository.Validation
{
    public class PersonValidator:AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(p => p.Created).NotEmpty().WithMessage("Created cannot be empty");
            RuleFor(p => p.StateId).NotEmpty().WithMessage("StateId cannot be null");
        }
    }
}