using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServiceReqApp.DataAccess;
using ServiceReqApp.Domain;
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

        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var request = await _uow.RequestsRepository.GetByIdAsync(id);
        //    if (request == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(request);
        //}

        //// GET: Requests/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Requests/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Description,CreationDate,CompletedDate,RequestType,IsCompleted,CustomerId,EmployeeId")] Request request)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _uow.RequestsRepository.CreateAsync(request);
        //        await _uow.SaveAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(request);
        //}

        // GET: Requests/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var request = await _uow.RequestsRepository.GetByIdAsync(id);
        //    if (request == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(request);
        //}

        //// POST: Requests/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Description,CreationDate,CompletedDate,RequestType,IsCompleted,CustomerId,EmployeeId")] Request request)
        //{
        //    if (id != request.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            await _uow.RequestsRepository.UpdateAsync(request);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!RequestExists(request.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", request.CustomerId);
        //    ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id", request.EmployeeId);
        //    return View(request);
        //}

        // GET: Requests/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var request = await _context.Requests
        //        .Include(r => r.Customer)
        //        .Include(r => r.Employee)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (request == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(request);
        //}

        //// POST: Requests/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var request = await _context.Requests.FindAsync(id);
        //    _context.Requests.Remove(request);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool RequestExists(int id)
        //{
        //    return _context.Requests.Any(e => e.Id == id);
        //}
    }
}
