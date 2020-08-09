using MediatR;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Commands.Admin
{
    public class EditUserCommand : IRequest<UserDto>
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