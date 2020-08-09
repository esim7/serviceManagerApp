using System.Threading.Tasks.Dataflow;
using MediatR;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Commands.Customer
{
    public class DeleteCustomerCommandPost : IRequest<CustomerDto>
    {
        public int? CustomerId { get; }

        public DeleteCustomerCommandPost(int? customerId)
        {
            CustomerId = customerId;
        }
    }
}