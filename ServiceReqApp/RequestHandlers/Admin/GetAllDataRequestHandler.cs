using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Infrastructure.Interfaces;
using ServiceReqApp.Requests.Admin;

namespace ServiceReqApp.RequestHandlers.Admin
{
    public class GetAllDataRequestHandler : IRequestHandler<GetAllDataRequest, AdminDto>
    {
        private readonly UserManager<Domain.User> _userManager;
        private readonly IUnitOfWork _uow;

        public GetAllDataRequestHandler(UserManager<Domain.User> userManager, IUnitOfWork uow)
        {
            _userManager = userManager;
            _uow = uow;
        }

        public async Task<AdminDto> Handle(GetAllDataRequest request, CancellationToken cancellationToken)
        {
            var users = await _userManager.Users.ToListAsync(cancellationToken: cancellationToken);
            var customers = await _uow.CustomersRepository.GetAllAsync();

            return new AdminDto(users, customers);
        }
    }
}