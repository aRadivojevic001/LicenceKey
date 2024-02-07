using AutoMapper;
using MediatR;
using MongoDB.Entities;

namespace LicenceKey.Application.User.Commands;

public record DeleteUserCommand(string Id) : IRequest;

public class DeleteUserHandler : IRequestHandler<DeleteUserCommand>
{
    //Pravljenje objekta mapera
    private readonly IMapper _mapper;

    public DeleteUserHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        await DB.DeleteAsync<Domain.Entities.User>(x => x.ID != null && x.ID.Equals(request.Id),
            cancellation: cancellationToken);

    }
}