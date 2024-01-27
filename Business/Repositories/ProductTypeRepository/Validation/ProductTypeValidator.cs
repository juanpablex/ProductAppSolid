using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.ProductTypeRepository.Validation
{
    public class ProductTypeValidator : AbstractValidator<ProductType>
    {
        public ProductTypeValidator() 
        { 
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Category Id cannot be empty");
        }
    }
}
