using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Entities
{
    public class Parent
    {
        public int Id { get; set; }
        public Student student { get; set; }
        public int studentId    { get; set; }

       
        public string Phone { get; set; }

        public String Email { get; set; }

    }
}
