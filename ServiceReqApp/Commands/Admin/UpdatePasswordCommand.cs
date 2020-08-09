using MediatR;
using Microsoft.AspNetCore.Identity;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Commands.Admin
{
    public class UpdatePasswordCommand : IRequest<IdentityResult>
    {
        public string UserId { get; }
        public ChangePasswordDto ChangePasswordDto { get; }

        public UpdatePasswordCommand(string userId, ChangePasswordDto changePasswordDto)
        {
            UserId = userId;
            ChangePasswordDto = changePasswordDto;
        }
    }
}