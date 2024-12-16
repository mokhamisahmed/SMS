using MediatR;
using SMS.Core.Bases;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.ClassCore.Command.Entities
{
    public class DeleteClassCommand:IRequest<RESPONSE<Class>>
    {
        public int Id { get; set; }

    }
}
