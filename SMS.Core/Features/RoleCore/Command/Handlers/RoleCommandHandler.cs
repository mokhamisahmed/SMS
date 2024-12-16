using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SMS.Core.Bases;
using SMS.Core.Features.RoleCore.Command.Entities;
using SMS.Core.UnitOfWorkValidation;
using SMS.Core.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.RoleCore.Command.Handlers
{
    public class RoleCommandHandler : IRequestHandler<AddRoleCommand, RESPONSE<IdentityRole>>
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IMapper mapper;
        private readonly IUnitOfWorkValidation<IdentityRole> unitOfWorkValidation;

        public RoleCommandHandler(RoleManager<IdentityRole> roleManager, IMapper mapper, IUnitOfWorkValidation<IdentityRole> unitOfWorkValidation)
        {
            this.roleManager=roleManager;
            this.mapper = mapper;
            this.unitOfWorkValidation=unitOfWorkValidation;
        }
        public async Task<RESPONSE<IdentityRole>> Handle(AddRoleCommand request, CancellationToken cancellationToken)
        {
        var role=   this.mapper.Map<IdentityRole>(request);
            this.unitOfWorkValidation.setValidation(new RoleValidation());

        var validateResult=    this.unitOfWorkValidation.validator.Validate(role);

            if (!validateResult.IsValid)
            {

                return await RequestHandler<IdentityRole>.BadRequest(role, "there is an error in request", validateResult.Errors);
            }

            try
            {
              await  this.roleManager.CreateAsync(role);

                return await RequestHandler<IdentityRole>.Success(
                    role,
                    "Role Created Successfuly"  
                    );
            }
            catch (Exception ex) {


                return await RequestHandler<IdentityRole>.Error(
                    role,
                    "there is an error while Creating the role",
                    ex
                    );
            }
        }
    }
}
