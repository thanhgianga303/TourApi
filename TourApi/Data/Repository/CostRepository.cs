using System.Linq;
using TourApi.Infrastructure;
using System.Threading.Tasks;
using TourApi.Model;
using TourApi.Model.IRepository;

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
    }
}