using MediatR;
using SMS.Core.Bases;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.ParentCore.Entities
{
    public class AddParentCommand:IRequest<RESPONSE<Parent>>
    {
        public int studentId { get; set; }

        public string Phone { get; set; }

        public String Email { get; set; }
    }
}
