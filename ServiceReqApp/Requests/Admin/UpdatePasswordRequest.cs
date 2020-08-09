using MediatR;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Requests.Admin
{
    public class UpdatePasswordRequest : IRequest<ChangePasswordDto>
    {
        public string UserId { get; set; }

        public UpdatePasswordRequest(string userId)
        {
            UserId = userId;
        }
    }
}