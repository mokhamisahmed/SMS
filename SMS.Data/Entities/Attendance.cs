
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Entities
{
    public class Attendance
    {
        public int Id { get; set; }

        public int personId  { get; set; }

        public ApplicationUser person { get; set; }

        public bool isAttendance { get; set; } = false;


      
    }
}
