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

            if (response.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }
            return BadRequest();
        }

        public async Task<IActionResult> UpdatePassword(string id)
        {
            if (id == null)
                return NotFound();

            var request = new UpdatePasswordRequest(id);
            var response = await _mediator.Send(request);

            return View(response);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePassword(string id, ChangePasswordDto passwordDto)
        {
            if (id != passwordDto.Id)
            {
                return NotFound();
            }
            var request = new UpdatePasswordCommand(id, passwordDto);
            var response = await _mediator.Send(request);

            if (response.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }
            return BadRequest();
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var request = new DeleteUserCommand(id);
            var response = await _mediator.Send(request);
            
            return View(response);
        }

        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var request = new DeleteUserCommandPost(id);
            var response = await _mediator.Send(request);

            if (response.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }
            return BadRequest();
        }

        public IActionResult CreateCustomer()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(Note note)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == HttpContext.User.Identity.Name);
        //        note.IdentityUser = currentUser;
        //        _context.Add(note);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(note);
        //}

    }
}
