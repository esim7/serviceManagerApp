using System.Collections.Generic;
using MediatR;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Requests.Request
{
    public class GetDataRequest : IRequest<List<RequestDto>>
    {
        
    }
}