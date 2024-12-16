using MediatR;
using SMS.Core.Bases;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.DepartmentCore.Command.Entities
{
    public class AddDepartmentCommand : IRequest<RESPONSE<Department>>
    {

        public string Name { get; set; }
    }
}
