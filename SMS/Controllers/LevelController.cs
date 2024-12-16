using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using SMS.Core.Features.LevelCore.Entities;
using System.Diagnostics.CodeAnalysis;

namespace SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        private readonly IMediator mediator;

        public LevelController(IMediator mediator) { 
        
            this.mediator= mediator;

        }
        [HttpPost]

        public async Task<IActionResult> Create([FromBody] AddLevelCommand level)
        {
         var response= await this.mediator.Send(level);
            return Ok(response); 
        }


    }
}
