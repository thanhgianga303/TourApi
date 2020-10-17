using TourApi.Infrastructure;
using TourApi.Models;
using TourApi.Models.IRepository;

namespace TourApi.Data.Repository
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        private readonly TourContext _context;
        public JobRepository(TourContext context) : base(context)
        {
            _context = context;
        }
    }
}