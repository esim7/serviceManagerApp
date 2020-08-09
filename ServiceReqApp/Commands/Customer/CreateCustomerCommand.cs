using MediatR;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Commands.Customer
{
    public class CreateCustomerCommand : IRequest<CustomerDto>
    {
        public CustomerDto CustomerDto { get; }

        public CreateCustomerCommand(CustomerDto customerDto)
        {
            CustomerDto = customerDto;
        }
    }
}