using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using SMS.Core.Features.SubjectCore.Entities;

namespace SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly IMediator mediator;

        public SubjectController(IMediator mediator)
        {
            this.mediator=mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] AddSubjectCommand subject) {

         var response=  await this.mediator.Send(subject);

         return Ok(response);
        

        }



    }
}
