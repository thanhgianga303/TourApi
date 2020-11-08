using System.Collections.Generic;
using System.Threading.Tasks;
using TourApi.Infrastructure;

namespace TourApi.Models.IRepository
{
    public interface ITouristGroupRepository : IRepository<TouristGroup>
    {
        // Cập nhật chi tiết chi phí
        // Task Update(CostDetails costDetails);
        //Cập nhật chi tiết TourDetailsOfStaff
        Task UpdateTouristGroupDetailsOfStaff(int touristGroupId, List<TouristGroupDetailsOfStaff> newListTouristGroupDetailsOfStaff);
        Task UpdateTouristGroupDetailsOfCustomer(int touristGroupId, List<TouristGroupDetailsOfCustomer> newListTouristGroupDetailsOfCustomer);
        Task AddCostDetails(CostDetails costDetails);
        Task DeleteCostDetails(int id);
        Task UpdateCostDetails(CostDetails costDetails);
        Task<CostDetails> GetCostDetails(int id);
    }
}