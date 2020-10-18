using System.Collections.Generic;
using System.Threading.Tasks;
using TourApi.Infrastructure;

namespace TourApi.Models.IRepository
{
    public interface IStaffRepository : IRepository<Staff>
    {
        //Thêm các công việc cho nhân viên
        Task AddJobDetails(List<JobDetails> listJob);
        //Xóa tất cả các jobdetails khi xóa nhân viên
        Task DeleteAllJobDetails(int staffId);
        Task UpdateJobDetails(int staffId, List<JobDetails> newListJob);
    }
}