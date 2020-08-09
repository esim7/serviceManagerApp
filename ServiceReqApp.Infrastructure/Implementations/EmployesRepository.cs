using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceReqApp.DataAccess;
using ServiceReqApp.Domain;
using ServiceReqApp.Infrastructure.Interfaces;

namespace ServiceReqApp.Infrastructure.Implementations
{
    public class EmployesRepository : IRepository<Employee>
    {
        private readonly ApplicationDbContext _context;

        public EmployesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Employee>> GetAllAsync()
        {
            return await _context.Employees
                .Include(e => e.Requests)
                .Include(e => e.User).ToListAsync();
        }

        public async Task<Employee> GetByIdAsync(int? id)
        {
            return await _context.Employees
                .Include(e => e.Requests)
                .Include(e => e.User)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Employee> CreateAsync(Employee entity)
        {
            var createdEmployee = await _context.Employees.AddAsync(entity);
            return createdEmployee.Entity;
        }

        public async Task<Employee> UpdateAsync(Employee entity)
        {
            var updatedEmployee = _context.Employees.Update(entity);
            return updatedEmployee.Entity;
        }

        public async Task<Employee> RemoveAsync(int? id)
        {
            var deletedEmployee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(deletedEmployee);
            return deletedEmployee;
        }
    }
}