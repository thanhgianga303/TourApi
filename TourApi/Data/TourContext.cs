using Microsoft.EntityFrameworkCore;
using TourApi.Models;

namespace TourApi.Data
{
    public class TourContext : DbContext
    {
        public TourContext(DbContextOptions<TourContext> options) : base(options)
        {

        }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<CostDetails> CostDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<JobDetails> JobDetails { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourDetails> TourDetails { get; set; }
        public DbSet<TourDetailsOfCustomer> TourDetailsOfCustomer { get; set; }
        public DbSet<TourDetailsOfStaff> TourDetailsOfStaff { get; set; }
        public DbSet<TouristGroup> TouristGroups { get; set; }
        public DbSet<TouristGroup> TourPrices { get; set; }
        public DbSet<TouristGroup> TypesOfTourism { get; set; }
    }
}