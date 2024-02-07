using LicenceKey.Application.Vendor.Commands;
using Microsoft.AspNetCore.Mvc;

namespace LicenceKey.Api.Controllers;


[Microsoft.AspNetCore.Components.Route("vendor")]
public class VendorController : ApiControllerBase
{
    [HttpPost("CreateVendor")]
    public async Task<ActionResult> CreateVendor(CreateVendorCommand command)
    {
        await Mediator.Send(command);
        return Ok();
    }
    
    [HttpDelete("DeleteVendor")]
    public async Task<ActionResult> DeleteVendor(DeleteVendorCommand command)
    {
        await Mediator.Send(command);
        return Ok();
    }
}