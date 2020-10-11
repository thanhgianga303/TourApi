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
    public class TourPriceController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITourPriceRepository _tourPriceRepository;
        public TourPriceController(IMapper mapper, ITourPriceRepository tourPriceRepository)
        {
            _mapper = mapper;
            _tourPriceRepository = tourPriceRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TourPriceDTO>>> GetAllTourPrice()
        {
            var tourPrices = await _tourPriceRepository.GetAll();
            var tourPricesDTO = _mapper.Map<IEnumerable<TourPrice>, IEnumerable<TourPriceDTO>>(tourPrices);
            return Ok(tourPricesDTO);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<TourPriceDTO>> GetTourPrice(int id)
        {
            var tourPrice = await _tourPriceRepository.GetBy(id);
            var tourPriceDTO = _mapper.Map<TourPrice, TourPriceDTO>(tourPrice);
            return Ok(tourPrice);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTourPrice(TourPriceDTO tourPriceDto)
        {
            var tourPrice = _mapper.Map<TourPriceDTO, TourPrice>(tourPriceDto);
            await _tourPriceRepository.Add(tourPrice);
            return CreatedAtAction(nameof(GetTourPrice), new { id = tourPrice.TourPriceId }, tourPrice);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTourPrice(int id, TourPriceDTO tourPriceDto)
        {
            if (id != tourPriceDto.TourPriceId)
            {
                return BadRequest();
            }
            try
            {
                var tourPrice = _mapper.Map<TourPriceDTO, TourPrice>(tourPriceDto);
                await _tourPriceRepository.Update(id, tourPrice);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await TourPriceExists(id))
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
        public async Task<IActionResult> DeleteTourPrice(int id)
        {
            if (await TourPriceExists(id))
            {
                await _tourPriceRepository.Delete(id);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
        private async Task<bool> TourPriceExists(int id)
        {
            var tourPrice = await _tourPriceRepository.GetBy(id);
            if (tourPrice != null)
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