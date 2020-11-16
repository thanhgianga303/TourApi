using System;
using System.Collections.Generic;
using System.Linq;
using TourApi.Models;

namespace TourApi.DTOs
{
    public class TouristGroupDTO
    {
        public int TouristGroupId { get; set; }
        public string GroupName { get; set; }
        public int NumberOfMembers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ScheduleDetails { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get; set; }
        public List<CostDetails> CostDetailsList { get; set; }

        public List<TouristGroupDetailsOfStaff> TouristGroupDetailsOfStaffList { get; set; }
        public List<TouristGroupDetailsOfCustomer> TouristGroupDetailsOfCustomerList { get; set; }
        public decimal TotalCost { get; set; }
        public decimal PriceForTouristGroup { get; set; }
        public decimal Proceeds { get; set; }
        public decimal Profit { get; set; }
        public decimal methodTotalCost()
        {
            return Math.Round(CostDetailsList.Sum(x => x.Price));
        }
        public decimal methodPriceForTouristGroup()
        {
            DateTime startDate = this.StartDate;
            var tourPrice = Tour.TourPriceList.FirstOrDefault(x => startDate >= x.StartDate && startDate <= x.EndDate);
            return tourPrice.Price;
        }
        public decimal methodProceeds()
        {
            var price = this.methodPriceForTouristGroup();
            var proceeds = price * this.NumberOfMembers;
            return proceeds;
        }
        public decimal methodProfit()
        {
            var profit = this.methodProceeds() - this.methodTotalCost();
            return profit;
        }
    }
}