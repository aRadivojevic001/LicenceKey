// using AutoMapper;
// using MediatR;
//
// namespace LicenceKey.Application.User.Commands;
//
// public record CreateUserCommand(string Username,  string Password, string Email, decimal Balance, string Status) : IRequest;
//
// public class CreateUserHandler : IRequestHandler<CreateUserCommand>
// {
//     
//     public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
//     {
//         //procves dodavanja user-a 
//
//         var user = new Domain.Entities.User(request.Username, request.Password, request.Email, request.Balance, request.Status);
//         await user.SaveAsync(cancelation: cancellationToken);
//     }
// }