using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourApi.Infrastructure;
using TourApi.Models;
using TourApi.Models.IRepository;

namespace TourApi.Data.Repository
{
    public class LocationRepository : Repository<Location>, ILocationRepository
    {
        private readonly TourContext _context;
        public LocationRepository(TourContext context) : base(context)
        {
            _context = context;
        }

    }
}