using MediatR;
using SMS.Core.Bases;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.ExamTypeCore.Entities
{
     public class AddExamTypeCommand:IRequest<RESPONSE<ExamType>>
    {

        public String type { get; set; }

    }
}
