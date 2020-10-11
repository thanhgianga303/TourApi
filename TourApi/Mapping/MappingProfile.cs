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

            CreateMap<TourPrice, TourPriceDTO>();
            CreateMap<TourPriceDTO, TourPrice>();

            CreateMap<Location, LocationDTO>();
            CreateMap<LocationDTO, Location>();

            CreateMap<TypesOfTourism, TypesOfTourismDTO>();
            CreateMap<TypesOfTourismDTO, TypesOfTourism>();
        }
    }
}