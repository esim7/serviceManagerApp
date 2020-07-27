using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceReqApp.DataAccess;
using ServiceReqApp.Domain;
using ServiceReqApp.Infrastructure.Interfaces;

namespace ServiceReqApp.Infrastructure.Implementations
{
    public class CustomersRepository : IRepository<Customer>
    {
        private readonly ApplicationDbContext _context;

        public CustomersRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Customer>> GetAllAsync()
        {
            return await _context.Customers.Include(c => c.Request).ToListAsync();
        }

        public Task<Customer> GetByIdAsync(int id)
        {
            return _context.Customers.Include(c => c.Request).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Customer> CreateAsync(Customer entity)
        {
            var createdCustomer = await _context.Customers.AddAsync(entity);
            return createdCustomer.Entity;
        }

        public async Task<Customer> UpdateAsync(int id, Customer entity)
        {
            var updatedCustomer = _context.Customers.Update(entity);
            return updatedCustomer.Entity;
        }

        public async Task<Customer> RemoveAsync(int id)
        {
            var deletedCustomer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(deletedCustomer);
            return deletedCustomer;
        }
    }
}