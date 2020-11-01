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

            CreateMap<TouristGroupDetailsOfCustomer, TouristGroupDetailsOfCustomerDTO>();
            CreateMap<TouristGroupDetailsOfCustomerDTO, TouristGroupDetailsOfCustomer>();

            CreateMap<TouristGroupDetailsOfStaff, TouristGroupDetailsOfStaffDTO>();
            CreateMap<TouristGroupDetailsOfStaffDTO, TouristGroupDetailsOfStaff>();

            CreateMap<TouristGroup, TouristGroupDTO>();
            CreateMap<TouristGroupDTO, TouristGroup>();

            CreateMap<TourPrice, TourPriceDTO>();
            CreateMap<TourPriceDTO, TourPrice>();

            CreateMap<TypesOfTourism, TypesOfTourismDTO>();
            CreateMap<TypesOfTourismDTO, TypesOfTourism>();


        }
    }
}