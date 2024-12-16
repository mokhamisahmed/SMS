using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Entities
{
    public class Subject
    {
        public int Id { get; set; }

        public string SubjectName { get; set; }

        public List<Level> levels { get; set; }

        public List<Exam> exams { get; set; }
    }
}
