using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceReqApp.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : class
    { 
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(int id, T entity);
        Task<T> RemoveAsync(int id);
    }
}