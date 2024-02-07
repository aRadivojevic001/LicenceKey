 using LicenceKey.Application.Key.Commands;
using LicenceKey.Application.Key.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LicenceKey.Api.Controllers
{
    [Route("key")]
    public class KeyController : ApiControllerBase
    {
        [HttpGet("GetOneKey")]
        public async Task<ActionResult> GetKey([FromQuery] GetOneKeyQuery query) => Ok(await Mediator.Send(query));
        
        [HttpPost("CreateKey")]
        public async Task<ActionResult> CreateKey([FromBody] CreateKeyCommand command)
        { 
            await Mediator.Send(command);
            return Ok();
        }
        
        [HttpDelete("DeleteKey")]
        public async Task<ActionResult> DeleteKey(DeleteKeyCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }
    }
}