using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task AddJobDetails(List<JobDetails> listJob)
        {
            await _context.JobDetails.AddRangeAsync(listJob);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAllJobDetails(int staffId)
        {
            var listJobDetails = _context.JobDetails.Where(j => j.StaffId == staffId);
            _context.JobDetails.RemoveRange(listJobDetails);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateJobDetails(int staffId, List<JobDetails> newListJob)
        {
            var listOldJobDetails = _context.JobDetails.Where(j => j.StaffId == staffId);
            _context.JobDetails.RemoveRange(listOldJobDetails);

            await _context.JobDetails.AddRangeAsync(newListJob);
            await _context.SaveChangesAsync();
        }
    }
}