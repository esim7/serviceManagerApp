using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Infrastructure.Interfaces;
using ServiceReqApp.Requests.Request;

namespace ServiceReqApp.RequestHandlers.Request
{
    public class GetDataToCreateNewRequestHandler : IRequestHandler<GetDataToCreateNewRequest, EmployeeCustomerDto>
    {
        private readonly IUnitOfWork _uow;

        public GetDataToCreateNewRequestHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<EmployeeCustomerDto> Handle(GetDataToCreateNewRequest request, CancellationToken cancellationToken)
        {
            var employees = await _uow.EmployesRepository.GetAllAsync();
            var customers = await _uow.CustomersRepository.GetAllAsync();

            return new EmployeeCustomerDto(customers, employees);
        }
    }
}