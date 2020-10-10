using System.Collections.Generic;
using System.Threading.Tasks;
namespace TourApi.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetBy(int id);
        Task Add(T entity);
        Task Update(int id, T entity);
        Task Delete(int id);
    }
}