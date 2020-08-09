using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ServiceReqApp.Commands.Admin;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Requests.Admin;

namespace ServiceReqApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var request = new GetAllDataRequest();
            var response = await _mediator.Send(request);

            return View(response);
        }


        public async Task<IActionResult> EditUser(string id)
        {
            if (id == null)
                return NotFound();

            var request = new EditUserRequest(id);
            var response = await _mediator.Send(request);

            return View(response);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(string id, UserDto userDto)
        {
            if (id != userDto.Id)
            {
                return NotFound();
            }
            var request = new EditUserCommand(id, userDto);
            var response = await _mediator.Send(request);

            return RedirectToAction(nameof(Index));
        }
    }
}
