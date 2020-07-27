using System.Threading.Tasks;
using ServiceReqApp.DataAccess;
using ServiceReqApp.Domain;
using ServiceReqApp.Infrastructure.Interfaces;

namespace ServiceReqApp.Infrastructure.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepository<Request> _requestsRepository;
        private readonly IRepository<Customer> _customersRepository;
        private readonly IRepository<UserProfile> _userProfilesRepository;
        private readonly IRepository<Employee> _employesRepository;

        public UnitOfWork(ApplicationDbContext context, IRepository<Request> requestsRepository,
            IRepository<Customer> customersRepository, IRepository<UserProfile> userProfilesRepository,
            IRepository<Employee> employesRepository)
        {
            _context = context;
            _requestsRepository = requestsRepository;
            _customersRepository = customersRepository;
            _userProfilesRepository = userProfilesRepository;
            _employesRepository = employesRepository;
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