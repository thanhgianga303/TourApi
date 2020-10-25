using System.Collections.Generic;
using System.Threading.Tasks;
using TourApi.Infrastructure;

namespace TourApi.Models.IRepository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task AddTourDetailsOfCustomer(TourDetailsOfCustomer tourDetailsOfCustomer);
        Task DeleteTourDetailsOfCustomer(int id);
        Task<TourDetailsOfCustomer> GetTourDetailsOfCustomer(int id);
    }
}