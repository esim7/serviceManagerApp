using AutoMapper;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.MapperProfiles.Request
{
    public class DtoToEntity : Profile
    {
        public DtoToEntity()
        {
            CreateMap<RequestDto, Domain.Request>();
        }
    }
}