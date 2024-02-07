using MediatR;
using MongoDB.Entities;

namespace LicenceKey.Application.Vendor.Commands;

public record CreateVendorCommand(string Name, bool Active) : IRequest;

public class CreateVendorHandler : IRequestHandler<CreateVendorCommand>
{
    public async Task Handle(CreateVendorCommand request, CancellationToken cancellationToken)
    {
        var vendor = new Domain.Entities.Vendor(request.Name,request.Active);
        await vendor.SaveAsync(cancellation: cancellationToken);
        
    }
}