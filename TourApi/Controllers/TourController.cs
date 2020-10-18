using System.Collections.Generic;
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
    public class TourController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITourRepository _repository;
        public TourController(IMapper mapper, ITourRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TourDTO>>> GetAllTour()
        {
            var tours = await _repository.GetAll();
            var toursDTO = _mapper.Map<IEnumerable<Tour>, IEnumerable<TourDTO>>(tours);
            return Ok(toursDTO);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<TourDTO>> GetTour(int id)
        {
            var tour = await _repository.GetBy(id);
            var tourDTO = _mapper.Map<Tour, TourDTO>(tour);
            return Ok(tour);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTour(TourDTO tourDto)
        {
            var tour = _mapper.Map<TourDTO, Tour>(tourDto);
            await _repository.Add(tour);
            return CreatedAtAction(nameof(GetTour), new { id = tour.TourId }, tour);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTour(int id, TourDTO tourDto)
        {
            if (id != tourDto.TourId)
            {
                return BadRequest();
            }
            try
            {
                var tour = _mapper.Map<TourDTO, Tour>(tourDto);
                await _repository.Update(id, tour);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await TourExists(id))
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
        public async Task<IActionResult> DeleteTour(int id)
        {
            if (await TourExists(id))
            {
                await _repository.Delete(id);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
        private async Task<bool> TourExists(int id)
        {
            var tour = await _repository.GetBy(id);
            if (tour != null)
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