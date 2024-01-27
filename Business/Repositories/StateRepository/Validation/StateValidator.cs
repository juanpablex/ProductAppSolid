using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.StateRepository.Validation
{
    public class StateValidator:AbstractValidator<State>
    {
        public StateValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(p => p.TypeId).NotEmpty().WithMessage("TypeId cannot be null");
        }
    }
}