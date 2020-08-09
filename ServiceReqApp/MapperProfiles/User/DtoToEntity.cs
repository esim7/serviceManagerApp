using AutoMapper;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.MapperProfiles.User
{
    public class DtoToEntity : Profile
    {
        public DtoToEntity()
        {
            CreateMap<UserDto, Domain.User>();
            CreateMap<ChangePasswordDto, Domain.User>();
        }
    }
}