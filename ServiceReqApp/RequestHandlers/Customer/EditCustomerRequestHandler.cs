using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Infrastructure.Interfaces;
using ServiceReqApp.Requests.Admin;
using ServiceReqApp.Requests.Customer;

namespace ServiceReqApp.RequestHandlers.Customer
{
    public class EditCustomerRequestHandler : IRequestHandler<EditCustomerRequest, CustomerDto>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public EditCustomerRequestHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<CustomerDto> Handle(EditCustomerRequest request, CancellationToken cancellationToken)
        {
            var editedCustomer = await _uow.CustomersRepository.GetByIdAsync(request.CustomerId);
            return _mapper.Map<CustomerDto>(editedCustomer);
        }
    }
}