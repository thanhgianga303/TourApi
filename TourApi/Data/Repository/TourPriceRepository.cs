using TourApi.Infrastructure;
using TourApi.Models;
using TourApi.Models.IRepository;

namespace TourApi.Data.Repository
{
    public class TourPriceRepository : Repository<TourPrice>, ITourPriceRepository
    {
        private readonly TourContext _context;
        public TourPriceRepository(TourContext context) : base(context)
        {
            _context = context;
        }
    }
}