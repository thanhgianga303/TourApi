using System.Collections.Generic;
using System.Threading.Tasks;
using TourApi.Infrastructure;

namespace TourApi.Models.IRepository
{
    public interface ILocationRepository : IRepository<Location>
    {
        //Lấy khách sạn
        Task<Hotel> GetHotel(int hotelId);
        //Thêm khách sạn
        Task AddHotel(Hotel hotel);
        //Update khách sạn
        Task UpdateHotel(Hotel hotel);
        //Xóa khách sạn
        Task DeleteHotel(int id);
        //Xóa tất cả khách sạn khi location của khách sạn đó bị xóa
        Task DeleteAllHotelByLocationId(int locationId);

    }
}