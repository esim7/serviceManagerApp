using MediatR;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Commands.Request
{
    public class CreateNewRequestCommand : IRequest<RequestDto>
    {
        public RequestDto RequestDto { get; }

        public CreateNewRequestCommand(RequestDto requestDto)
        {
            RequestDto = requestDto;
        }
    }
}