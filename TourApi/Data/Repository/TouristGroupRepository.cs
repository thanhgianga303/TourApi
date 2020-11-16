using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
        public async Task UpdateTouristGroupDetailsOfStaff(int touristGroupId, List<TouristGroupDetailsOfStaff> newList)
        {
            var listTouristGroupDetailsOfStaff = _context.TouristGroupDetailsOfStaff.Where(t => t.TouristGroupId == touristGroupId);
            _context.TouristGroupDetailsOfStaff.RemoveRange(listTouristGroupDetailsOfStaff);
            await _context.TouristGroupDetailsOfStaff.AddRangeAsync(newList);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateTouristGroupDetailsOfCustomer(int touristGroupId, List<TouristGroupDetailsOfCustomer> newList)
        {
            var listTouristGroupDetailsOfCustomer = _context.TouristGroupDetailsOfCustomer.Where(t => t.TouristGroupId == touristGroupId);
            _context.TouristGroupDetailsOfCustomer.RemoveRange(listTouristGroupDetailsOfCustomer);
            await _context.TouristGroupDetailsOfCustomer.AddRangeAsync(newList);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<TouristGroup>> GetAllTouristGroupByTourId(int id)
        {
            var TouristGroups = await _context.TouristGroups.Where(x => x.TourId == id).ToListAsync();
            return TouristGroups;
        }
        public async Task AddCostDetails(CostDetails costDetails)
        {
            await _context.AddAsync(costDetails);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteCostDetails(int id)
        {
            var costDetails = await _context.CostDetails.FindAsync(id);
            _context.CostDetails.Remove(costDetails);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateCostDetails(CostDetails costDetails)
        {
            _context.CostDetails.Update(costDetails);
            await _context.SaveChangesAsync();
        }
        public async Task<CostDetails> GetCostDetails(int id)
        {
            var costDetails = await _context.CostDetails.FindAsync(id);
            return costDetails;
        }
    }
}