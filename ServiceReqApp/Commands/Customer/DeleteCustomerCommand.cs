using MediatR;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Commands.Customer
{
    public class DeleteCustomerCommand : IRequest<CustomerDto>
    {
        public int CustomerId { get;}

        public DeleteCustomerCommand(int customerId)
        {
            CustomerId = customerId;
        }
    }
}