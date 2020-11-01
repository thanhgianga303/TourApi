using System.Collections.Generic;
using System.Threading.Tasks;
using TourApi.Infrastructure;

namespace TourApi.Models.IRepository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task AddTourDetailsOfCustomer(TouristGroupDetailsOfCustomer touristGroupDetailsOfCustomer);
        Task DeleteTourDetailsOfCustomer(int id);
        Task<TouristGroupDetailsOfCustomer> GetTouristGroupDetailsOfCustomer(int id);
    }
}