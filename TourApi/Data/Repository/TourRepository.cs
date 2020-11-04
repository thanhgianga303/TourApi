using System.Threading.Tasks;
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
        public async Task AddTourDetails(TourDetails tourDetails)
        {
            await _context.TourDetails.AddAsync(tourDetails);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteTourDetails(int id)
        {
            var tourDetails = await _context.TourDetails.FindAsync(id);
            _context.TourDetails.Remove(tourDetails);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateTourDetails(TourDetails tourDetails)
        {
            _context.TourDetails.Update(tourDetails);
            await _context.SaveChangesAsync();
        }
        public async Task<TourDetails> GetTourDetails(int id)
        {
            var tourDetails = await _context.TourDetails.FindAsync(id);
            return tourDetails;
        }
    }
}