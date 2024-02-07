using AutoMapper;
using LicenceKey.Application.Common.Dto.Users;
using MediatR;
using MongoDB.Entities;

namespace LicenceKey.Application.User.Commands;

public record CreateUserCommand(CreateUserDto User) : IRequest;

public class CreateUserHandler : IRequestHandler<CreateUserCommand>
{
    //Pravljenje objekta mapera
    private readonly IMapper _mapper;

    public CreateUserHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<Domain.Entities.User>(request.User);
        await user.SaveAsync(cancellation: cancellationToken);
    }
}