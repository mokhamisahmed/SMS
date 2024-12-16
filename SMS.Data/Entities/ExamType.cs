using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Entities
{
    public class ExamType
    {
        public int Id { get; set; }
        public String type {  get; set; }

        public List<Exam> exams { get; set; }

    }
}
