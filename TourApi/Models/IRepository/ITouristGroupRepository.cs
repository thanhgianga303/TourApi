using System.Collections.Generic;
using System.Threading.Tasks;
using TourApi.Infrastructure;

namespace TourApi.Models.IRepository
{
    public interface ITouristGroupRepository : IRepository<TouristGroup>
    {
        //Lấy danh sách chi tiết chi phí theo touristGroupId
        // Task<IEnumerable<CostDetails>> GetCostDetails(int touristGroupId);
        //Xóa chi tiết chi phí theo touristGroupId
        //Task DeleteCostDetails(int touristGroupId);
        //Thêm chi tiết chi phí
        //Task Add(CostDetails costDetails);
        //Cập nhật chi tiết chi phí
        //Task Update(CostDetails costDetails);
    }
}