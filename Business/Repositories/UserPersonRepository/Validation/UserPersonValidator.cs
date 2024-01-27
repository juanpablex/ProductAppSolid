using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.UserPersonRepository.Validation
{
    public class UserPersonValidator:AbstractValidator<UserPerson>
    {
        public UserPersonValidator()
        {
            RuleFor(p => p.UserId).NotEmpty().WithMessage("UserId cannot be null");
            RuleFor(p => p.PersonId).NotEmpty().WithMessage("PersonId cannot be null");
        }
    }
}