using System;

namespace TourApi.Models
{
    public class People
    {
        public string FullName { get; set; }
        public string IdentityCardNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirhth { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
    }
}