using System.Threading.Tasks;
using ServiceReqApp.DataAccess;
using ServiceReqApp.Domain;
using ServiceReqApp.Infrastructure.Interfaces;

namespace ServiceReqApp.Infrastructure.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IRepository<Request> RequestsRepository { get; set; }
        public IRepository<Customer> CustomersRepository { get; set; }
        public IRepository<UserProfile> UserProfilesRepository { get; set; }
        public IRepository<Employee> EmployesRepository { get; set; }

        public UnitOfWork(ApplicationDbContext context, IRepository<Request> requestsRepository,
            IRepository<Customer> customersRepository, IRepository<UserProfile> userProfilesRepository,
            IRepository<Employee> employesRepository)
        {
            _context = context;
            RequestsRepository = requestsRepository;
            CustomersRepository = customersRepository;
            UserProfilesRepository = userProfilesRepository;
            EmployesRepository = employesRepository;
        }


        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task BeginTransactionAsync()
        {
            await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            if (_context.Database.CurrentTransaction != null)
            {
                await _context.Database.CurrentTransaction.CommitAsync();
            }
        }

        public async Task RollbackAsync()
        {
            if (_context.Database.CurrentTransaction != null)
            {
                await _context.Database.CurrentTransaction.RollbackAsync();
            }
        }
    }
}