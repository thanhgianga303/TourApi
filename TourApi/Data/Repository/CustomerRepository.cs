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
        public async Task AddTourDetailsOfCustomer(TouristGroupDetailsOfCustomer touristGroupDetailsOfCustomer)
        {
            await _context.AddAsync(touristGroupDetailsOfCustomer);
            await _context.SaveChangesAsync();
        }
        public async Task<TouristGroupDetailsOfCustomer> GetTouristGroupDetailsOfCustomer(int id)
        {
            var touristGroupDetailsOfCustomer = _context.TouristGroupDetailsOfCustomer.Where(t => t.Id == id);
            return await touristGroupDetailsOfCustomer.FirstOrDefaultAsync();
        }
        public async Task DeleteTourDetailsOfCustomer(int id)
        {
            var touristGroupDetailsOfCustomer = await _context.TouristGroupDetailsOfCustomer.FindAsync(id);
            _context.TouristGroupDetailsOfCustomer.Remove(touristGroupDetailsOfCustomer);
            await _context.SaveChangesAsync();
        }
    }
}