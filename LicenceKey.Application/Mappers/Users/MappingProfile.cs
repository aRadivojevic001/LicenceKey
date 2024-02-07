using AutoMapper;
using LicenceKey.Application.Common.Dto.Users;

namespace LicenceKey.Application.Mappers.Users;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
       //Definisanje mape 
       CreateMap<CreateUserDto, Domain.Entities.User>().ReverseMap();
       CreateMap<UpdateUserDto, Domain.Entities.User>().ReverseMap();
    }
}
