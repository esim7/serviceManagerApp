using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ServiceReqApp.Commands.Customer;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Infrastructure.Interfaces;

namespace ServiceReqApp.RequestHandlers.Customer
{
    public class DeleteCustomerRequestHandler : IRequestHandler<DeleteCustomerCommand, CustomerDto>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public DeleteCustomerRequestHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<CustomerDto> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _uow.CustomersRepository.GetByIdAsync(request.CustomerId);

            return _mapper.Map<CustomerDto>(customer);
        }
    }
}