using LicenceKey.Application.User.Commands;
using Microsoft.AspNetCore.Mvc;

namespace LicenceKey.Api.Controllers;


[Microsoft.AspNetCore.Components.Route("user")]
public class UserController : ApiControllerBase
{
    [HttpPost("CreateUser")]
    public async Task<ActionResult> CreateUser(CreateUserCommand command)
    {
        await Mediator.Send(command);
        return Ok();
    }
    
    [HttpDelete("DeleteUser")]
    public async Task<ActionResult> DeleteUser(DeleteUserCommand command)
    {
        await Mediator.Send(command);
        return Ok();
    }
    
    [HttpPut("UpdateUser")]
    public async Task<ActionResult> Update(UpdateUserCommand command)
    {
        await Mediator.Send(command);
        return Ok();
    }
}