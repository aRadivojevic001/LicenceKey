using AutoMapper;
using LicenceKey.Application.Common.Dto.Keys;

namespace LicenceKey.Application.Mappers.Keys;

public class MappingProfile : Profile
{
      public MappingProfile()
      {
            CreateMap<Domain.Entities.Key, Task<KeyDetailsDto>>().ConstructUsing(x => GetKeyDetails(x));
      }
      private static async Task<KeyDetailsDto> GetKeyDetails(Domain.Entities.Key key)
      {
            return new KeyDetailsDto(
                  key.Name,
                  (await key.Vendor.ToEntityAsync())!.Name,
                  new List<string>(key.Users.Select(x=>x.Email).ToList()),
                  key.KeyType,
                  key.Price,
                  key.Status,
                  key.Category
            );
                 
      }
}