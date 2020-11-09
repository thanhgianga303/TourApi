using System.Collections.Generic;
using System.Threading.Tasks;
using TourApi.Infrastructure;

namespace TourApi.Models.IRepository
{
    public interface ILocationRepository : IRepository<Location>
    {
        Task<IEnumerable<Location>> GetAllLocation(string cityName);
    }
}