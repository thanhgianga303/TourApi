using System.Collections.Generic;
using System.Threading.Tasks;
using TourApi.Infrastructure;

namespace TourApi.Models.IRepository
{
    public interface ITourRepository : IRepository<Tour>
    {
        //Lấy tất cả Tour Details theo tour id
        //Task<TourDetails> GetAllTourDetailsByTourId(int tourID);
        //Thêm các Tour Details(thêm các địa điểm trong lịch trình của tour)
        //Task AddRangeTourDetails(List<TourDetails> listTourDetails);
        //Xóa tất cả TourDetails theo tour id khi xóa tour đó
        //Task DeleteAllTourDetailsByTourId(int tourId);
        //Xóa các tour details(loại bỏ các địa điểm bị unchecked) đã bi unchecked
        //Task DeleteRangeTourDetails(List<TourDetails> listTourDetails);
    }
}