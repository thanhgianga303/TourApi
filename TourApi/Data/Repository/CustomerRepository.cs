using TourApi.Infrastructure;
using TourApi.Models;
using TourApi.Models.IRepository;

namespace TourApi.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly TourContext _context;
        public CustomerRepository(TourContext context) : base(context)
        {
            _context = context;
        }
    }
}