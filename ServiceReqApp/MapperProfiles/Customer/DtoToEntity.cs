using AutoMapper;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.MapperProfiles.Customer
{
    public class DtoToEntity : Profile
    {
        public DtoToEntity()
        {
            CreateMap<CustomerDto, Domain.Customer>();
        }
    }
}