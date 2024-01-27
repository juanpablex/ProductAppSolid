using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.ProductStoreRepository.Validation
{
    public class ProductStoreValidator:AbstractValidator<ProductStore>
    {
        public ProductStoreValidator()
        {
            RuleFor(p => p.ProductId).NotEmpty().WithMessage("ProductId cannot be null");
            RuleFor(p => p.StoreId).NotEmpty().WithMessage("StoreId cannot be null");
        }
    }
}