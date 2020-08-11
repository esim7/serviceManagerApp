using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceReqApp.DataAccess;
using ServiceReqApp.Domain;
using ServiceReqApp.Infrastructure.Interfaces;

namespace ServiceReqApp.Infrastructure.Implementations
{
    public class RequestsRepository : IRepository<Request>
    {
        private readonly ApplicationDbContext _context;

        public RequestsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Request>> GetAllAsync()
        {
            return await _context.Requests
                .Include(c => c.Customer)
                .Include(e => e.Employee)
                .ToListAsync();
        }

        public async Task<Request> GetByIdAsync(int? id)
        {
            return await _context.Requests
                .Include(c=>c.Customer)
                .Include(e=>e.Employee)
                .FirstOrDefaultAsync(r=>r.Id == id);
        }

        public async Task<List<Request>> GetByEmployeeIdAsync(string id)
        {
            return await _context.Requests
                .Include(c => c.Customer)
                .Include(e => e.Employee)
                .Where(r => r.Employee.UserId == id).ToListAsync();
        }

        public async Task<Request> CreateAsync(Request entity)
        {
            var createdRequest = await _context.Requests.AddAsync(entity);
            return createdRequest.Entity;
        }

        public async Task<Request> UpdateAsync(Request entity)
        {
            var updatedRequest = _context.Requests.Update(entity);
            return updatedRequest.Entity;
        }

        public async Task<Request> RemoveAsync(int? id)
        {
            var deletedRequest = await _context.Requests.FindAsync(id);
            _context.Requests.Remove(deletedRequest);
            return deletedRequest;
        }
    }
}