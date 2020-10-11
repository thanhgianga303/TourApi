using System.Linq;
using TourApi.Infrastructure;
using System.Threading.Tasks;
using TourApi.Models;
using TourApi.Models.IRepository;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TourApi.Data.Repository
{
    public class CostRepository : Repository<Cost>, ICostRepository
    {
        private readonly TourContext _context;
        public CostRepository(TourContext context) : base(context)
        {
            _context = context;
        }
        public async Task DeleteCostDetails(int costId)
        {
            var CostDetailsList = _context.CostDetails.Where(m => m.CostId == costId);
            _context.CostDetails.RemoveRange(CostDetailsList);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<CostDetails>> GetAllCostDetails(int costId)
        {
            var CostDetailsList = _context.CostDetails.Where(m => m.CostId == costId);
            return await CostDetailsList.ToListAsync();
        }
    }
}