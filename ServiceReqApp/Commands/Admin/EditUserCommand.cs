using MediatR;
using Microsoft.AspNetCore.Identity;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Commands.Admin
{
    public class EditUserCommand : IRequest<IdentityResult>
    {
        public string UserId { get; set; }
        public UserDto UserDto { get; }
        public EditUserCommand(string id, UserDto userDto)
        {
            UserId = id;
            UserDto = userDto;
        }
    }
}