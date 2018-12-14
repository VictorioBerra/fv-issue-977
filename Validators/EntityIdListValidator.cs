using FluentValidation;
using FV_Iss_977.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FV_Iss_977.Validators
{
    public class EntityIdListValidator : AbstractValidator<EntityIdList>
    {
        public EntityIdListValidator()
        {
            RuleFor(x => x).NotEmpty();
        }
    }
}
