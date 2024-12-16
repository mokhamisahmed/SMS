using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Entities
{
   public class StudentRegistrationExam
    {

        public Student student { get; set; }

        public Exam exam { get; set; }
        public int studentId { get; set; }

        public int ExamId { get; set; }

        public double? grade { get; set; }

    }
}
