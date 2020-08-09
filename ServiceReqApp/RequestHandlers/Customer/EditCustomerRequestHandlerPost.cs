using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ServiceReqApp.Commands.Customer;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Infrastructure.Interfaces;

namespace ServiceReqApp.RequestHandlers.Customer
{
    public class EditCustomerRequestHandlerPost : IRequestHandler<EditCustomerCommand, CustomerDto>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public EditCustomerRequestHandlerPost(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<CustomerDto> Handle(EditCustomerCommand request, CancellationToken cancellationToken)
        {
            var editedCustomer =
                _uow.CustomersRepository.UpdateAsync(_mapper.Map<Domain.Customer>(request.CustomerDto));
            await _uow.SaveAsync();

            return _mapper.Map<CustomerDto>(editedCustomer.Result);
        }
    }
}