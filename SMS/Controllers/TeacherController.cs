using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Core.Features.TeacherCore.Entities;

namespace SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IMediator mediator;

        public TeacherController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpPost]

        public async Task<IActionResult> Create([FromForm] AddTeacherCommand teacher)
        {

          var response=  await this.mediator.Send(teacher);

            return Ok(response);
        }


    }
}
