using MediatR;
using SMS.Core.Bases;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.StudentRegistrationExamCore.Query.Entities
{
    public class GetStudentsExamQuery:IRequest<RESPONSE<List<StudentRegistrationExam>>>
    {

        public int examId { get; set; }


    }
}
