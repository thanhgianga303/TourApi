using System.Collections.Generic;
using TourApi.Models;

namespace TourApi.DTOs
{
    public class TypesOfTourismDTO
    {
        public int TypesOfTourismId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public List<Tour> TourList { get; set; }
    }
}