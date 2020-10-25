using System.Collections.Generic;

namespace TourApi.Models
{
    public class TypesOfTourism
    {
        public int TypesOfTourismId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public virtual List<Tour> TourList { get; set; }
    }
}