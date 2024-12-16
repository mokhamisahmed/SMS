using MediatR;
using SMS.Core.Bases;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.SubjectCore.Entities
{
    public class AddSubjectCommand : IRequest<RESPONSE<Subject>>
    {

        public string SubjectName { get; set; }

    }
}
