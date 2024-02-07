using AutoMapper;
using MediatR;
using MongoDB.Entities;

namespace LicenceKey.Application.Key.Commands;

public record DeleteKeyCommand(string Id) : IRequest;

public class DeleteKeyHandler : IRequestHandler<DeleteKeyCommand>
{
    //Pravljenje objekta mapera
    private readonly IMapper _mapper;

    public DeleteKeyHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task Handle(DeleteKeyCommand request, CancellationToken cancellationToken)
    {
        await DB.DeleteAsync<Domain.Entities.Key>(x => x.ID != null && x.ID.Equals(request.Id),
            cancellation: cancellationToken);
    }
}