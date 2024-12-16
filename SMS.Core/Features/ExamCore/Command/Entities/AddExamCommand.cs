using MediatR;
using SMS.Core.Bases;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.ExamCore.Command.Entities
{
    public class AddExamCommand:IRequest<RESPONSE<Exam>>
    {

        public int subjectId { get; set; }
        public int examTypeId { get; set; }

        public DateTime dateTime { get; set; }

        public String DurationExam { get; set; }

        public double FinalGrade { get; set; }
    }
}
