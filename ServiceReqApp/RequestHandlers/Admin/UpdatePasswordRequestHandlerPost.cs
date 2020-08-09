using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Identity;
using ServiceReqApp.Commands.Admin;

namespace ServiceReqApp.RequestHandlers.Admin
{
    public class UpdatePasswordRequestHandlerPost : IRequestHandler<UpdatePasswordCommand, IdentityResult>
    {
        private readonly UserManager<Domain.User> _userManager;

        public UpdatePasswordRequestHandlerPost(UserManager<Domain.User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(UpdatePasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            return await _userManager.ResetPasswordAsync(user, token, request.ChangePasswordDto.PasswordCandidate);
        }
    }
}