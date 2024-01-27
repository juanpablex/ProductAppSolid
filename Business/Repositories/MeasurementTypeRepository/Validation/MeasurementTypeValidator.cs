using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.MeasurementTypeRepository.Validation
{
    public class MeasurementTypeValidator:AbstractValidator<MeasurementType>
    {
        public MeasurementTypeValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}