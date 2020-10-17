using TourApi.Infrastructure;
using TourApi.Models;
using TourApi.Models.IRepository;

namespace TourApi.Data.Repository
{
    public class StaffRepository : Repository<Staff>, IStaffRepository
    {
        private readonly TourContext _context;
        public StaffRepository(TourContext context) : base(context)
        {
            _context = context;
        }
    }
}