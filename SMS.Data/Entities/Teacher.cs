using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        
        public ApplicationUser teacher { get; set; }
        public String teacherId { get; set; }
        public int departmentId { get; set; }
        public double Salary { get; set; }
        public Department department { get; set; }

       

        
    }
}
