using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.ProductRepository.Validation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(p => p.TypeId).NotEmpty().WithMessage("TypeId cannot be null");
            RuleFor(p => p.StateId).NotEmpty().WithMessage("StateId cannot be null");
            RuleFor(p => p.MeasurementId).NotEmpty().WithMessage("MeasurementId cannot be null");
        }
    }
}