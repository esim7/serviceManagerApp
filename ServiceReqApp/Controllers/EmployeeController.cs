using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServiceReqApp.Domain;
using ServiceReqApp.Requests.Employee;

namespace ServiceReqApp.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IMediator _mediator;
        private readonly UserManager<User> _userManager;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var request = new GetCurrentUserRequests(_userManager.GetUserId(HttpContext.User));
            var response = await _mediator.Send(request);

            return View();
        }
    }
}
