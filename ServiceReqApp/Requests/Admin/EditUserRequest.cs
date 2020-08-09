using MediatR;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Requests.Admin
{
    public class EditUserRequest : IRequest<UserDto>
    {
        public string UserId { get; set; }

        public EditUserRequest(string id)
        {
            UserId = id;
        }
    }
}