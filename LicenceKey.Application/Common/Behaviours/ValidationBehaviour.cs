using FluentValidation;
using MediatR;
using LicenceKey.Application.Common.Extensions;
using Exceptions_ValidationException = LicenceKey.Application.Common.Exceptions.ValidationException;
using ValidationException = LicenceKey.Application.Common.Exceptions.ValidationException;

namespace LicenceKey.Application.Common.Behaviours;

public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (_validators.Any())
        {
            var context = new ValidationContext<TRequest>(request);

            var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context,
                cancellationToken)));

            var failures = validationResults.Where(r => r.Errors.Any())
                .SelectMany(r => r.Errors)
                .ToList();

            if (failures.Any())
                throw new Exceptions_ValidationException(failures.ToGroup());
        }

        return await next();
    }
}
