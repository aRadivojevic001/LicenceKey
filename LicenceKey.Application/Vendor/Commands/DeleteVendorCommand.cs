using AutoMapper;
using MediatR;
using MongoDB.Entities;

namespace LicenceKey.Application.Vendor.Commands;


public record DeleteVendorCommand(string Id) : IRequest;

public class DeleteVendorHandler : IRequestHandler<DeleteVendorCommand>

{
    private readonly IMapper _mapper;

    public DeleteVendorHandler(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public async Task Handle(DeleteVendorCommand request, CancellationToken cancellationToken)
    {
        await DB.DeleteAsync<Domain.Entities.Vendor>(x => x.ID != null && x.ID.Equals(request.Id),
            cancellation: cancellationToken);
    }
}