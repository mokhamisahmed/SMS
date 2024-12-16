
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Entities
{
  
    public class Student
    {
       
        public int Id { get; set; }
        
        public String studentId { get; set; }

        public int ClassId { get; set; }
        public ApplicationUser student {  get; set; }

      


        public Class Class { get; set; }

    }

}
