using MediatR;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Requests.Customer
{
    public class EditCustomerRequest : IRequest<CustomerDto>
    {
        public int? CustomerId { get; }

        public EditCustomerRequest(int? customerId)
        {
            CustomerId = customerId;
        }
    }
}