using FluentValidation;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Validations
{
     public class RoleValidation:AbstractValidator<IdentityRole>
    {

        public RoleValidation() {

            RuleFor(r => r.Name).NotEmpty().WithMessage("Role Name is required");

        }
    }
}
