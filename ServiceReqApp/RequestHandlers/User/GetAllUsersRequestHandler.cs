using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Requests.User;

namespace ServiceReqApp.RequestHandlers.User
{

    public class GetAllUsersRequestHandler : IRequestHandler<GetAllUsersRequest, ICollection<UserDto>>
    {
        private readonly UserManager<Domain.User> _userManager;
        private readonly IMapper _mapper;

        public GetAllUsersRequestHandler(UserManager<Domain.User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<ICollection<UserDto>> Handle(GetAllUsersRequest request, CancellationToken cancellationToken)
        {
            var users = _mapper.Map<List<UserDto>>(await _userManager.Users.ToListAsync(cancellationToken: cancellationToken));
            return users;
        }
    }
}