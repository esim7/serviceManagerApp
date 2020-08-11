using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ServiceReqApp.Domain;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Infrastructure.Implementations;
using ServiceReqApp.Infrastructure.Interfaces;
using ServiceReqApp.Requests.Employee;
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace ServiceReqApp.RequestHandlers.Employee
{
    public class GetCurrentUserRequestsHandler : IRequestHandler<GetCurrentUserRequests, List<RequestDto>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GetCurrentUserRequestsHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<List<RequestDto>> Handle(GetCurrentUserRequests request, CancellationToken cancellationToken)
        {
            var repository = _uow.RequestsRepository as RequestsRepository;
            var requests = await repository.GetByEmployeeIdAsync(request.CurrentUserId);

            return _mapper.Map<List<RequestDto>>(request);
        }
    }
}