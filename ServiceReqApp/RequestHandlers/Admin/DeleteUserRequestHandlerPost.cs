using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Identity;
using ServiceReqApp.Commands.Admin;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.RequestHandlers.Admin
{
    public class DeleteUserRequestHandlerPost : IRequestHandler<DeleteUserCommandPost, IdentityResult>
    {
        private readonly UserManager<Domain.User> _userManager;

        public DeleteUserRequestHandlerPost(UserManager<Domain.User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(DeleteUserCommandPost request, CancellationToken cancellationToken)
        {
            var deletedUser = await _userManager.FindByIdAsync(request.UserId);
            return await _userManager.DeleteAsync(deletedUser);
        }
    }
}