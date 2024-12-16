using MediatR;
using SMS.Core.Bases;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.StudentCore.Command.Entities
{
    public class AddStudentCommand:IRequest<RESPONSE<Student>>
    {

        public String studentId { get; set; }

        public int ClassId { get; set; }

    }
}
