using FluentValidation;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Validations
{
    public class DepartmentValidation:AbstractValidator<Department>
    {
        public DepartmentValidation()
        {

            RuleFor(d => d.Name).NotEmpty().WithMessage("Name is required");

        }



    }
}
