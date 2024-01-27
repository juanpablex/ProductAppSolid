using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.GroupRepository.Validation
{
    public class GroupValidator:AbstractValidator<Group>
    {
        public GroupValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(p => p.Description).NotEmpty().WithMessage("Description cannot be empty");
            RuleFor(p => p.StateId).NotEmpty().WithMessage("StateId cannot be null");
        }
    }
}