using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TourApi.DTOs;
using TourApi.Models;
using TourApi.Models.IRepository;

namespace TourApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LocationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILocationRepository _locationRepository;
        public LocationController(IMapper mapper, ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationDTO>>> GetAllLocation()
        {
            var locations = await _locationRepository.GetAll();
            var locationsDTO = _mapper.Map<IEnumerable<Location>, IEnumerable<LocationDTO>>(locations);
            return Ok(locationsDTO);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LocationDTO>> GetLocation(int id)
        {
            var location = await _locationRepository.GetBy(id);

            var locationDTO = _mapper.Map<Location, LocationDTO>(location);
            return Ok(locationDTO);
        }
        [HttpPost]
        public async Task<IActionResult> CreateLocation(LocationDTO locationDTO)
        {
            var location = _mapper.Map<LocationDTO, Location>(locationDTO);
            await _locationRepository.Add(location);
            return CreatedAtAction(nameof(GetLocation), new { id = location.LocationId }, location);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLocation(int id, LocationDTO locationDTO)
        {
            if (id != locationDTO.LocationId)
            {
                return BadRequest();
            }
            try
            {
                var location = _mapper.Map<LocationDTO, Location>(locationDTO);
                await _locationRepository.Update(id, location);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await LocationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            if (await LocationExists(id))
            {
                await _locationRepository.Delete(id);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
        private async Task<bool> LocationExists(int id)
        {
            var location = await _locationRepository.GetBy(id);
            if (location != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}