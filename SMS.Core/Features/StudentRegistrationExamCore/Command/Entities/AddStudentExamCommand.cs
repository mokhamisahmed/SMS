using MediatR;
using SMS.Core.Bases;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.StudentRegistrationCore.Command.Entities
{
    public class AddStudentExamCommand : IRequest<RESPONSE<StudentRegistrationExam>>
    {


        public int studentId { get; set; }

        public int examId { get; set; }

        public double? grade { get; set; }


    }
}
