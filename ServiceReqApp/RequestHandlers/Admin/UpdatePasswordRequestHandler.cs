using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using ServiceReqApp.Commands.Admin;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Requests.Admin;

namespace ServiceReqApp.RequestHandlers.Admin
{
    public class UpdatePasswordRequestHandler : IRequestHandler<UpdatePasswordRequest, ChangePasswordDto>
    {
        private readonly UserManager<Domain.User> _userManager;
        private readonly IMapper _mapper;

        public UpdatePasswordRequestHandler(UserManager<Domain.User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<ChangePasswordDto> Handle(UpdatePasswordRequest request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);

            return _mapper.Map<ChangePasswordDto>(user);
        }
    }
}