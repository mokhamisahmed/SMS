using MediatR;
using SMS.Core.Bases;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.TeacherCore.Entities
{
    public class AddTeacherCommand:IRequest<RESPONSE<Teacher>>
    {
        public String teacherId { get; set; }
        public int departmentId { get; set; }
        public double Salary { get; set; }



    }
}
