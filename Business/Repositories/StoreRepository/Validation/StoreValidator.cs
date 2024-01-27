using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.StoreRepository.Validation
{
    public class StoreValidator:AbstractValidator<Store>
    {
        public StoreValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(p => p.Location).NotEmpty().WithMessage("Location cannot be empty");
            RuleFor(p => p.Phone).NotEmpty().WithMessage("Phone is required");
            RuleFor(p => p.Nit).NotEmpty().WithMessage("Nit cannot be empty");
            RuleFor(p => p.TypeId).NotEmpty().WithMessage("TypeId cannot be null");
            RuleFor(p => p.StateId).NotEmpty().WithMessage("StateId cannot be null");
        }
    }
}