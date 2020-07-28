using MediatR;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Commands
{
    public class CreateUserCommand : IRequest<UserDto>
    {   
        public UserDto UserDto { get; }
        public CreateUserCommand(UserDto userDto)
        {
            UserDto = userDto;
        }
    }
}