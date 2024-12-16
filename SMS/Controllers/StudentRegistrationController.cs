using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Core.Features.StudentCore.Command.Entities;
using SMS.Data.Entities;

namespace SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRegistrationController : ControllerBase
    {

        private readonly IMediator mediator;

        public StudentRegistrationController(IMediator mediator)
        {
            this.mediator=mediator;

        }


        public async Task<IActionResult> Create([FromForm] AddStudentCommand  student )
        {
        var response=   await this.mediator.Send(student);

         return Ok(response);

        }


    }
}
