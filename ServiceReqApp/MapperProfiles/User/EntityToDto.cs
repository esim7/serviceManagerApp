using AutoMapper;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.MapperProfiles.User
{
    public class EntityToDto : Profile
    {
        public EntityToDto()
        {
            CreateMap<Domain.User, UserDto>();
            CreateMap<Domain.User, ChangePasswordDto>();
        }
    }
}