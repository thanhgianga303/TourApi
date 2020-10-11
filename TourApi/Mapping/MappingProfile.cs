using System.Collections.Generic;
using AutoMapper;
using TourApi.DTOs;
using TourApi.Models;

namespace TourApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CostDTO, Cost>();
            CreateMap<Cost, CostDTO>();

            CreateMap<CostDetailsDTO, CostDetails>();
            CreateMap<CostDetails, CostDetailsDTO>();

            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();

            CreateMap<Location, LocationDTO>();
            CreateMap<LocationDTO, Location>();

            CreateMap<Hotel, HotelDTO>();
            CreateMap<HotelDTO, Hotel>();

            CreateMap<Job, JobDTO>();
            CreateMap<JobDTO, Job>();

            CreateMap<JobDetails, JobDetailsDTO>();
            CreateMap<JobDetailsDTO, JobDetails>();

            CreateMap<Staff, StaffDTO>();
            CreateMap<StaffDTO, Staff>();

            CreateMap<Tour, TourDTO>();
            CreateMap<TourDTO, Tour>();

            CreateMap<TourDetails, TourDetailsDTO>();
            CreateMap<TourDetailsDTO, TourDetails>();

            CreateMap<TourDetailsOfCustomer, TourDetailsOfCustomerDTO>();
            CreateMap<TourDetailsOfCustomerDTO, TourDetailsOfCustomer>();

            CreateMap<TourDetailsOfStaff, TourDetailsOfStaffDTO>();
            CreateMap<TourDetailsOfStaffDTO, TourDetailsOfStaff>();

            CreateMap<TouristGroup, TouristGroupDTO>();
            CreateMap<TouristGroupDTO, TouristGroup>();

            CreateMap<TourPrice, TourPriceDTO>();
            CreateMap<TourPriceDTO, TourPrice>();

            CreateMap<TypesOfTourism, TypesOfTourismDTO>();
            CreateMap<TypesOfTourismDTO, TypesOfTourism>();


        }
    }
}