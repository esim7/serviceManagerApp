using System.Threading.Tasks;
using ServiceReqApp.Domain;

namespace ServiceReqApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Request> RequestsRepository { get; set; }
        IRepository<Customer> CustomersRepository { get; set; }
        IRepository<UserProfile> UserProfilesRepository { get; set; }
        IRepository<Employee> EmployesRepository { get; set; }

        Task SaveAsync();

        Task BeginTransactionAsync();

        Task CommitAsync();

        Task RollbackAsync();
    }
}