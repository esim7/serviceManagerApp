using System.Threading.Tasks;

namespace ServiceReqApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveAsync();

        Task BeginTransactionAsync();

        Task CommitAsync();

        Task RollbackAsync();
    }
}