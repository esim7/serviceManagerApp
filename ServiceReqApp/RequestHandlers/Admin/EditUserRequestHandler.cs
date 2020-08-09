using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Infrastructure.Interfaces;
using ServiceReqApp.Requests.Admin;

namespace ServiceReqApp.RequestHandlers.Admin
{
    public class EditUserRequestHandler : IRequestHandler<EditUserRequest, UserDto>
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Domain.User> _userManager;

        public EditUserRequestHandler(IMapper mapper, IUnitOfWork uow, UserManager<Domain.User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<UserDto> Handle(EditUserRequest request, CancellationToken cancellationToken)
        {
            var user = _userManager.Users.First(u => u.Id == request.UserId);
            return _mapper.Map<UserDto>(user);
        }
    }
}