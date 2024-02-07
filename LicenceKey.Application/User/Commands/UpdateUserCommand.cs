using AutoMapper;
using LicenceKey.Application.Common.Dto.Users;
using LicenceKey.Application.Common.Exceptions;
using MediatR;
using MongoDB.Entities;

namespace LicenceKey.Application.User.Commands;

public record UpdateUserCommand(UpdateUserDto User) : IRequest;

public class UpdateUserHandler : IRequestHandler<UpdateUserCommand>
{
    private readonly IMapper _mapper;

    public UpdateUserHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await DB.Find<LicenceKey.Domain.Entities.User>()
            .OneAsync(request.User.UserId,
                cancellationToken);

        if (user == null)
        {
            throw new NotFoundException("User not exist!");
        }

        _mapper.Map(request.User,
            user);

        await user.SaveAsync(cancellation: cancellationToken);
    }
}