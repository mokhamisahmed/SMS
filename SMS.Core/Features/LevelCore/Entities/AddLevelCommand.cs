using MediatR;
using SMS.Core.Bases;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.LevelCore.Entities
{
    public  class AddLevelCommand:IRequest<RESPONSE<Level>>
    {
        public string LevelName { get; set; }
    }
}
