using System.Collections.Generic;
using System.Threading.Tasks;
using TourApi.Infrastructure;

namespace TourApi.Model.IRepository
{
    public interface ICostRepository : IRepository<Cost>
    {
        //Xóa chi tiết chi phí theo costId
        Task DeleteCostDetails(int CostId);
    }
}