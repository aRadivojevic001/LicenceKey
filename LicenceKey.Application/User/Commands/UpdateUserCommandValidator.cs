using FluentValidation;
using LicenceKey.Application.User.Commands;

namespace LicenceKey.Application.User.Commands;

public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(x => x.User.Username)
            .MaximumLength(512)
            .MinimumLength(3);
        // RuleFor(x => x.User.Email)
        //     .EmailAddress();
        RuleFor(x => x.User.Active);
        RuleFor(x => x.User.balance)
            .NotNull();
        RuleFor(x => x.User.moneySpend)
            .NotNull();
    }
}
