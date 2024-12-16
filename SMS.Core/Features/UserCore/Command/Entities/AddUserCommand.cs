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
    public class AddUserCommand : IRequest<RESPONSE<ApplicationUser>>
    {

        public string UserName { get; set; }

        public string Email { get; set; }

        public String Phone { get; set; }
        public string Password { get; set; }


    }
}
