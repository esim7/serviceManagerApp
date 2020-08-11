using System.Collections.Generic;
using MediatR;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.Requests.Employee
{
    public class GetCurrentUserRequests : IRequest<List<RequestDto>>
    {
        public string CurrentUserId { get; }

        public GetCurrentUserRequests(string currentUserId)
        {
            CurrentUserId = currentUserId;
        }
    }
}