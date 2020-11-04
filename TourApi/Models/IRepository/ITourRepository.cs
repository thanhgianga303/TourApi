using System.Collections.Generic;
using System.Threading.Tasks;
using TourApi.Infrastructure;

namespace TourApi.Models.IRepository
{
    public interface ITourRepository : IRepository<Tour>
    {
        Task AddTourDetails(TourDetails tourDetails);
        Task DeleteTourDetails(int id);
        Task UpdateTourDetails(TourDetails tourDetails);
        Task<TourDetails> GetTourDetails(int id);
    }
}