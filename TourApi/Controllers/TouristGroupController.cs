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
    public class TouristGroupController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITouristGroupRepository _repository;
        public TouristGroupController(IMapper mapper, ITouristGroupRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TouristGroupDTO>>> GetAllTouristGroup()
        {
            var touristGroups = await _repository.GetAll();
            var touristGroupsDTO = _mapper.Map<IEnumerable<TouristGroup>, IEnumerable<TouristGroupDTO>>(touristGroups);
            return Ok(touristGroupsDTO);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TouristGroupDTO>>> GetTouristGroup(int id)
        {
            var touristGroup = await _repository.GetBy(id);
            var touristGroupDTO = _mapper.Map<TouristGroup, TouristGroupDTO>(touristGroup);
            return Ok(touristGroupDTO);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTouristGroup(TouristGroupDTO touristGroupDto)
        {
            var touristGroup = _mapper.Map<TouristGroupDTO, TouristGroup>(touristGroupDto);
            await _repository.Add(touristGroup);
            return CreatedAtAction(nameof(GetTouristGroup), new { id = touristGroup.TouristGroupId }, touristGroup);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTouristGroup(int id, TouristGroupDTO touristGroupDto)
        {
            if (id != touristGroupDto.TouristGroupId)
            {
                return BadRequest();
            }
            try
            {
                var touristGroup = _mapper.Map<TouristGroupDTO, TouristGroup>(touristGroupDto);
                await _repository.Update(id, touristGroup);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await TouristGroupExists(id))
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
        private async Task<bool> TouristGroupExists(int id)
        {
            var touristGroup = await _repository.GetBy(id);
            if (touristGroup != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTouristGroup(int id)
        {
            if (await TouristGroupExists(id))
            {
                await _repository.Delete(id);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}