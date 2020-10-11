using TourApi.Infrastructure;
using TourApi.Models;
using TourApi.Models.IRepository;

namespace TourApi.Data.Repository
{
    public class LocationRepository : Repository<Location>, ILocationRepository
    {
        private readonly TourContext _context;
        public LocationRepository(TourContext context) : base(context)
        {
            _context = context;
        }
    }
}