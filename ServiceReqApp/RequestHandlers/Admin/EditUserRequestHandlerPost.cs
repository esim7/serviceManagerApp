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
    public class EditUserRequestHandlerPost : IRequestHandler<EditUserCommand, UserDto>
    {
        private readonly UserManager<Domain.User> _userManager;
        private readonly IMapper _mapper;

        public EditUserRequestHandlerPost(UserManager<Domain.User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(EditUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            user.FirstName = request.UserDto.FirstName;
            user.LastName = request.UserDto.LastName;

            //если при редактировании данных пользователя поле новый пароль не пустое,
            //изменяем пароль, если пустое то пароль остается без изменений
            if (request.UserDto.PasswordCandidate != String.Empty)
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                var result = await _userManager.ResetPasswordAsync(user, token, request.UserDto.PasswordCandidate);
            }
            await _userManager.UpdateAsync(user);

            return _mapper.Map<UserDto>(user);
        }
    }
}