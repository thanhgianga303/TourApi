using System.Collections.Generic;
using AutoMapper;
using TourApi.DTOs;
using TourApi.Model;

namespace TourApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CostDTO, Cost>();
            CreateMap<Cost, CostDTO>();
        }
    }
}