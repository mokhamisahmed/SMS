using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Core.Features.UserCore.Command.Entities;

namespace SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator mediator;

        public AccountController(IMediator mediator)
        {
            this.mediator= mediator;
        }
        [HttpPost]

        public async Task<IActionResult> Create([FromForm] AddUserCommand user)
        {

         var response=  await this.mediator.Send(user);

         return Ok(response);

        }

        [HttpPost("LogIn")]

        public async Task<IActionResult> LogIn(LogInCommand user)
        {

            var response= this.mediator.Send(user);

            return Ok(response);

        }





    }
}
