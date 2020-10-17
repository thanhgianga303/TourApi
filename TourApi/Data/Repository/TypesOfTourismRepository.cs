using TourApi.Infrastructure;
using TourApi.Models;
using TourApi.Models.IRepository;

namespace TourApi.Data.Repository
{
    public class TypesOfTourismRepository : Repository<TypesOfTourism>, ITypesOfTourismRepository
    {
        private readonly TourContext _context;
        public TypesOfTourismRepository(TourContext context) : base(context)
        {
            _context = context;
        }
    }
}