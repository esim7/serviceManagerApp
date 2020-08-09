using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using ServiceReqApp.Commands.Admin;
using ServiceReqApp.Infrastructure.DTO;

namespace ServiceReqApp.RequestHandlers.Admin
{
    public class EditUserRequestHandlerPost : IRequestHandler<EditUserCommand, IdentityResult>
    {
        private readonly UserManager<Domain.User> _userManager;

        public EditUserRequestHandlerPost(UserManager<Domain.User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(EditUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            user.FirstName = request.UserDto.FirstName;
            user.LastName = request.UserDto.LastName;

            return await _userManager.UpdateAsync(user);
        }
    }
}