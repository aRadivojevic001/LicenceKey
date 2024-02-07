using FluentValidation;
using LicenceKey.Application.Common.Validators.Users;

namespace LicenceKey.Application.User.Commands;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.User).SetValidator(new CreateUserDtoValidator());
    }
}