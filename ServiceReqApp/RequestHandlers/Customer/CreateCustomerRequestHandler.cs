using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ServiceReqApp.Commands.Customer;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Infrastructure.Interfaces;

namespace ServiceReqApp.RequestHandlers.Customer
{
    public class CreateCustomerRequestHandler : IRequestHandler<CreateCustomerCommand, CustomerDto>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CreateCustomerRequestHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }


        public async Task<CustomerDto> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var createdCustomer = _mapper.Map<Domain.Customer>(request.CustomerDto);
            if (createdCustomer != null)
            {
                await _uow.CustomersRepository.CreateAsync(createdCustomer);
                await _uow.SaveAsync();
            }
                
            return _mapper.Map<CustomerDto>(createdCustomer);
        }
    }
}