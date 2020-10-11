using System.Collections.Generic;
using System.Threading.Tasks;
using TourApi.Infrastructure;

namespace TourApi.Models.IRepository
{
    public interface ICostRepository : IRepository<Cost>
    {
        //Lấy tất cả chi tiết chi phí theo costId
        Task<IEnumerable<CostDetails>> GetAllCostDetails(int costId);
        //Xóa chi tiết chi phí theo costId
        Task DeleteCostDetails(int CostId);
    }
}