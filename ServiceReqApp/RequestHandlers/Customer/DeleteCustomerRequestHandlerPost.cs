using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ServiceReqApp.Commands.Customer;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Infrastructure.Interfaces;

namespace ServiceReqApp.RequestHandlers.Customer
{
    public class DeleteCustomerRequestHandlerPost : IRequestHandler<DeleteCustomerCommandPost, CustomerDto>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public DeleteCustomerRequestHandlerPost(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<CustomerDto> Handle(DeleteCustomerCommandPost request, CancellationToken cancellationToken)
        {
            var deletedCustomer = await _uow.CustomersRepository.RemoveAsync(request.CustomerId);
            await _uow.SaveAsync();

            return _mapper.Map<CustomerDto>(deletedCustomer);
        }
    }
}