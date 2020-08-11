using AutoMapper;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.MapperProfiles.Request
{
    public class EntityToDto : Profile
    {
        public EntityToDto()
        {
            CreateMap<Domain.Request, RequestDto>();
        }
    }
}