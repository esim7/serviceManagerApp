using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Infrastructure.Interfaces;
using ServiceReqApp.Requests.Request;

namespace ServiceReqApp.RequestHandlers.Request
{
    public class GetDataRequestHandler : IRequestHandler<GetDataRequest, RequestDto>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GetDataRequestHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<RequestDto> Handle(GetDataRequest request, CancellationToken cancellationToken)
        {
            var requests = await _uow.RequestsRepository.GetAllAsync();

            return _mapper.Map<RequestDto>(request);
        }
    }
}