using MediatR;
using Microsoft.AspNetCore.Identity;
using SMS.Core.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.RoleCore.Command.Entities
{
    public class AddRoleCommand : IRequest<RESPONSE<IdentityRole>>
    {

        public string Name { get; set; }
    }
}
