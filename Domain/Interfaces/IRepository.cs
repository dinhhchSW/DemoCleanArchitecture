using System.Collections.Generic;
using System.Threading.Tasks;
//using Domain.Common;
using Domain.Entities;

namespace Domain.Interfaces
{

    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangesAsync();
    }


}
