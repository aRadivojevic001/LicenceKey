using LicenceKey.Domain.Entities;
using MediatR;
using MongoDB.Entities;

namespace LicenceKey.Application.Key.Commands;

public record CreateKeyCommand(string Name) : IRequest;

public class CreateKeyHandler : IRequestHandler<CreateKeyCommand>
{
    public async Task Handle(CreateKeyCommand request, CancellationToken cancellationToken)
    {
        
        var vendor = new Vendor("Steam");
        await vendor.SaveAsync(cancellation: cancellationToken);
        
       var data = new Domain.Entities.Key(request.Name);
       await data.SaveAsync(cancellation: cancellationToken);
    }
}