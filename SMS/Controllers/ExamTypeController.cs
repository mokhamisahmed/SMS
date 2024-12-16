using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Core.Features.ExamTypeCore.Entities;

namespace SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamTypeController : ControllerBase
    {

        private readonly IMediator mediator;

        public ExamTypeController(IMediator mediator) { 
        
        this.mediator = mediator;


        }

        [HttpPost]

        public async Task<IActionResult> Create([FromForm] AddExamTypeCommand examType)
        {
          var response= await this.mediator.Send(examType);

            return Ok(response);
        }
             

    }
}
