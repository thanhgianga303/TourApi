using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
        public async Task<Hotel> GetHotel(int hotelId)
        {
            return await _context.Hotels.FindAsync(hotelId);
        }
        public async Task AddHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateHotel(Hotel hotel)
        {
            _context.Hotels.Update(hotel);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteHotel(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAllHotelByLocationId(int locationId)
        {
            var hotels = _context.Hotels.Where(h => h.LocationId == locationId).ToList();
            _context.Hotels.RemoveRange(hotels);
            await _context.SaveChangesAsync();
        }


    }
}