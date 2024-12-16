using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Bases
{
    public class RESPONSE<T>
    {
        public T Data { get; set; }

        public String Message { get; set; }

        public bool isSuccessful { get; set; }

       public List<ValidationFailure> Errors { get; set; }

    }
}
