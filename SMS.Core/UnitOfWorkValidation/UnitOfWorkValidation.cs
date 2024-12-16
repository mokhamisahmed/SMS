using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.UnitOfWorkValidation
{
    public class UnitOfWorkValidation<T> : IUnitOfWorkValidation<T>
    {
        public IValidator<T> validator { get; set; }

      
        public UnitOfWorkValidation()
        {
            
        }

        public void setValidation(IValidator<T> validator)
        {
            this.validator = validator;
        }
    }
}
