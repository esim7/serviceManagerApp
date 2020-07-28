using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using ServiceReqApp.Commands;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.RequestHandlers.User
{
    public class CreateUserRequestHadler : IRequestHandler<CreateUserCommand, UserDto>
    {
        private readonly UserManager<Domain.User> _userManager;
        private readonly IMapper _mapper;

        public CreateUserRequestHadler(UserManager<Domain.User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Domain.User>(request.UserDto);
            if (user != null)
            {
                var createdUser = _userManager.CreateAsync(user);
                return _mapper.Map<UserDto>(user);
            }

            return _mapper.Map<UserDto>(user);
        }
    }
}