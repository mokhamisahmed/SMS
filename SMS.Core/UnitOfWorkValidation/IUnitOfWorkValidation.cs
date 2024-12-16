using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.UnitOfWorkValidation
{
    public interface IUnitOfWorkValidation<T>
    {
        public IValidator<T> validator { get; }

        public void setValidation(IValidator<T> validator);

    }
}
