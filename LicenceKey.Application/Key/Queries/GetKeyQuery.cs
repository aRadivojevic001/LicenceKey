using MediatR;

namespace LicenceKey.Application.Key.Queries;

public record GetKeyQuery(string KeyName) : IRequest<string>;

public class GetKeyQueryHandler : IRequestHandler<GetKeyQuery, string>
{
    public Task<string> Handle(GetKeyQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(request.KeyName);
    }
}