using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Core.Features.ClassCore.Command.Entities;

namespace SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IMediator mediator;

        public ClassController(IMediator mediator) { 
        
            this.mediator = mediator;
        }
        [HttpPost]

        public async Task<IActionResult> Create([FromBody] AddClassCommand c )
        {
            var response=await this.mediator.Send(c);

            return Ok(response);
        }


    }
}
