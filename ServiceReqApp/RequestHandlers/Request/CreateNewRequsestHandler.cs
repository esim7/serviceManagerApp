using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ServiceReqApp.Commands.Request;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Infrastructure.Interfaces;

namespace ServiceReqApp.RequestHandlers.Request
{
    public class CreateNewRequestHandler : IRequestHandler<CreateNewRequestCommand, RequestDto>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CreateNewRequestHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<RequestDto> Handle(CreateNewRequestCommand request, CancellationToken cancellationToken)
        {
            var createdRequest = _mapper.Map<Domain.Request>(request.RequestDto);
            if (createdRequest != null)
            {
                await _uow.RequestsRepository.CreateAsync(createdRequest);
                await _uow.SaveAsync();
            }

            return _mapper.Map<RequestDto>(createdRequest);
        }
    }
}