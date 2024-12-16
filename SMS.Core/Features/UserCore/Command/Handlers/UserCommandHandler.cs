using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SMS.Core.Bases;
using SMS.Core.Features.UserCore.Command.Entities;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.UserCore.Command.Handlers
{
    public class UserCommandHandler :
        IRequestHandler<AddUserCommand, RESPONSE<ApplicationUser>>,
        IRequestHandler<LogInCommand,RESPONSE<ApplicationUser>>
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IMapper mapper;
        public UserCommandHandler(UserManager<ApplicationUser> userManager,IMapper mapper)
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }

        public async Task<RESPONSE<ApplicationUser>> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
          var applicationUser=  this.mapper.Map<ApplicationUser>(request);

       var result=  await this.userManager.CreateAsync(applicationUser,request.Password);
            if (result.Succeeded)
            {
                return await RequestHandler<ApplicationUser>.Success(applicationUser, "User is created successful");
            }

            return await RequestHandler<ApplicationUser>.Error(applicationUser, "there are errors ");
        }

        public async Task<RESPONSE<ApplicationUser>> Handle(LogInCommand request, CancellationToken cancellationToken)
        {
           var user=  this.mapper.Map<ApplicationUser>(request);

            var checkUser = this.userManager.FindByNameAsync(user.UserName);

            if (checkUser != null) {
                var checkPassword = await this.userManager.CheckPasswordAsync(user,request.Password);

                if (!checkPassword) {

                    return await RequestHandler<ApplicationUser>.BadRequest(user,"UserName or Password is not correct");
                }

                return null;   // make jwt and return it with data
            }
            else
            {
                return await RequestHandler<ApplicationUser>.BadRequest(user, "UserName or Password is not correct");

            }




        }
    }
}
