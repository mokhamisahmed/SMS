using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Entities
{
    public class Exam
    {
        public int  Id { get; set; }

        public int subjectId { get; set; }
        public int examTypeId { get; set; }


        public DateTime dateTime { get; set; }

        public String DurationExam { get; set; }

        public double FinalGrade { get; set; }

        public Subject subject { get; set; }

      

        public ExamType examType { get; set; }

        public List<StudentRegistrationExam> students { get; set; }



    }
}
