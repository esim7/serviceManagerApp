using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using ServiceReqApp.Commands.Request;
using ServiceReqApp.DataAccess;
using ServiceReqApp.Domain;
using ServiceReqApp.Infrastructure.DTO;
using ServiceReqApp.Infrastructure.Interfaces;
using ServiceReqApp.Requests.Request;

namespace ServiceReqApp.Controllers
{
    public class RequestsController : Controller
    {
        private readonly IMediator _mediator;

        public RequestsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var request = new GetDataRequest();
            var response = await _mediator.Send(request);

            return View(response);
        }

        public async Task<IActionResult> Create()
        {
            var request = new GetDataToCreateNewRequest();
            var response = await _mediator.Send(request);

            ViewBag.Customers = new SelectList(response.Customers, "Id", "Name");
            ViewBag.Employees = new SelectList(response.Employees, "Id", "User.FirstName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RequestDto requestDto)
        {
            if (ModelState.IsValid)
            {
                var request = new CreateNewRequestCommand(requestDto);
                var response = await _mediator.Send(request);

                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
