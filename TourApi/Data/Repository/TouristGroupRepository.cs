using TourApi.Infrastructure;
using TourApi.Models;
using TourApi.Models.IRepository;

namespace TourApi.Data.Repository
{
    public class TouristGroupRepository : Repository<TouristGroup>, ITouristGroupRepository
    {
        private readonly TourContext _context;
        public TouristGroupRepository(TourContext context) : base(context)
        {
            _context = context;
        }
    }
}