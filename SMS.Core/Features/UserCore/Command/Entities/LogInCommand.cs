using MediatR;
using SMS.Core.Bases;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.UserCore.Command.Entities
{
     public  class LogInCommand:IRequest<RESPONSE<ApplicationUser>>
    {

        public String UserName { get; set; }

        public String Password { get; set; }


    }
}
