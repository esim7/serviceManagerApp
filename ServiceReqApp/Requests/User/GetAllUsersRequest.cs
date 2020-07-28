using System.Collections;
using System.Collections.Generic;
using MediatR;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Requests.User
{
    public class GetAllUsersRequest : IRequest<ICollection<UserDto>>
    {
        
    }
}