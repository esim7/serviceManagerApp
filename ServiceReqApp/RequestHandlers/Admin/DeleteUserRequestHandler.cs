using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using ServiceReqApp.Commands.Admin;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.RequestHandlers.Admin
{
    public class DeleteUserRequestHandler : IRequestHandler<DeleteUserCommand, UserDto>
    {
        private readonly UserManager<Domain.User> _userManager;
        private readonly IMapper _mapper;

        public DeleteUserRequestHandler(UserManager<Domain.User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            return _mapper.Map<UserDto>(user);
        }
    }
}