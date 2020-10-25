using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
        public async Task AddTourDetailsOfCustomer(TourDetailsOfCustomer tourDetailsOfCustomer)
        {
            await _context.AddAsync(tourDetailsOfCustomer);
            await _context.SaveChangesAsync();
        }
        public async Task<TourDetailsOfCustomer> GetTourDetailsOfCustomer(int id)
        {
            var tourDetailsOfCustomer = _context.TourDetailsOfCustomer.Where(t => t.Id == id);
            return await tourDetailsOfCustomer.FirstOrDefaultAsync();
        }
        public async Task DeleteTourDetailsOfCustomer(int id)
        {
            var tourDetailsOfCustomer = await _context.TourDetailsOfCustomer.FindAsync(id);
            _context.TourDetailsOfCustomer.Remove(tourDetailsOfCustomer);
            await _context.SaveChangesAsync();
        }
    }
}