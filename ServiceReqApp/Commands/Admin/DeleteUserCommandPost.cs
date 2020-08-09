using MediatR;
using Microsoft.AspNetCore.Identity;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Commands.Admin
{
    public class DeleteUserCommandPost : IRequest<IdentityResult>
    {
        public string UserId { get; set; }

        public DeleteUserCommandPost(string userId)
        {
            UserId = userId;
        }
    }
}