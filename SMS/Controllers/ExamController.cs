using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {

        private readonly IMediator mediator;

        public ExamController(IMediator mediator)
        {

            this.mediator = mediator;
        }


        //public Task<IActionResult> Create()
        //{



        //}

    }
}
