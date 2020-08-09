using MediatR;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Commands.Customer
{
    public class EditCustomerCommand : IRequest<CustomerDto>
    {
        public int? CustomerId { get;}
        public CustomerDto CustomerDto { get; }

        public EditCustomerCommand(int? id, CustomerDto customerDto)
        {
            CustomerId = id;
            CustomerDto = customerDto;
        }
    }
}