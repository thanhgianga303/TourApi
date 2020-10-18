using TourApi.Infrastructure;
using TourApi.Models;
using TourApi.Models.IRepository;

namespace TourApi.Data.Repository
{
    public class TourRepository : Repository<Tour>, ITourRepository
    {
        private readonly TourContext _context;
        public TourRepository(TourContext context) : base(context)
        {
            _context = context;
        }
    }
}