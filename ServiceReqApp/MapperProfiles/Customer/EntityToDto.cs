using AutoMapper;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.MapperProfiles.Customer
{
    public class EntityToDto : Profile
    {
        public EntityToDto()
        {
            CreateMap<Domain.Customer, CustomerDto>();
        }
    }
}