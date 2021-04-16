using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TravelIn.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(Guid id);
        Task Create(T item);
        Task Delete(Guid id);
        Task<IEnumerable<T>> Get();
        Task Update(T item);
    }
}
