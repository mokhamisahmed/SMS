using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Core.Features.StudentRegistrationCore.Command.Entities;

namespace SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentExamController : ControllerBase
    {
        private readonly IMediator mediator;

        public StudentExamController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] AddStudentExamCommand studentExam)
        {


         var response=  await this.mediator.Send(studentExam);


         return Ok(response);


        }
        //[HttpGet]

        //public async Task<IActionResult> GetStudentExam()
        //{


        //}
          




    }
}
