using AutoMapper;
using LicenceKey.Application.Common.Dto.Keys;
using MediatR;
using MongoDB.Entities;

namespace LicenceKey.Application.Key.Queries;

public record GetOneKeyQuery(string KeyId) : IRequest<KeyDetailsDto>;

public class GetOneKeyQueryHandler : IRequestHandler<GetOneKeyQuery, KeyDetailsDto>
{
    private readonly IMapper _mapper;

    public GetOneKeyQueryHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<KeyDetailsDto> Handle(GetOneKeyQuery request, CancellationToken cancellationToken)
    {
        //Da pokupim osve podatke iz relacije 
        var key = await DB.Find<Domain.Entities.Key>().OneAsync(request.KeyId, cancellationToken);

        if (key == null) throw new Exception("Key does not exist!");

        return await _mapper.Map<Task<KeyDetailsDto>>(key);
    }
}