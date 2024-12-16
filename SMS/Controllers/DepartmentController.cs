using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Core.Features.DepartmentCore.Command;
using SMS.Core.Features.DepartmentCore.Command.Entities;
namespace SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator mediator;

        public DepartmentController(IMediator mediator)
        {

            this.mediator= mediator;

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddDepartmentCommand department )
        {


          var response = await this.mediator.Send(department);

            if (response.Errors!=null) {
                return StatusCode(500, response);
            }
            return Ok(response);

        }



    }
}
