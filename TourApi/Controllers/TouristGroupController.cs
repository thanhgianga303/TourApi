using System.Collections.Generic;
using System.Linq;
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
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TouristGroupDTO>>> GetAllTouristGroupByTourId(int id)
        {
            var touristGroups = await _repository.GetAllTouristGroupByTourId(id);
            var touristGroupsDTO = _mapper.Map<IEnumerable<TouristGroup>, IEnumerable<TouristGroupDTO>>(touristGroups);
            foreach (var item in touristGroupsDTO)
            {
                item.TotalCost = item.methodTotalCost();
                item.Proceeds = item.methodProceeds();
                item.Profit = item.methodProfit();
                item.PriceForTouristGroup = item.methodPriceForTouristGroup();
            }
            return Ok(touristGroupsDTO);
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
        [HttpPut("{touristgroupid}")]
        public async Task<IActionResult> UpdateTourDetailsOfStaff(int touristgroupid, List<TouristGroupDetailsOfStaffDTO> newListTouristGroupDetailsOfStaffDto)
        {
            if (await TouristGroupExists(touristgroupid))
            {
                var newListTouristGroupDetailsOfStaff = _mapper.Map<IEnumerable<TouristGroupDetailsOfStaffDTO>, IEnumerable<TouristGroupDetailsOfStaff>>(newListTouristGroupDetailsOfStaffDto);
                await _repository.UpdateTouristGroupDetailsOfStaff(touristgroupid, newListTouristGroupDetailsOfStaff.ToList());
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPut("{touristgroupid}")]
        public async Task<IActionResult> UpdateTourDetailsOfCustomer(int touristgroupid, List<TouristGroupDetailsOfCustomerDTO> newListTouristGroupDetailsOfCustomerDto)
        {
            if (await TouristGroupExists(touristgroupid))
            {
                var newListTouristGroupDetailsOfCustomer = _mapper.Map<IEnumerable<TouristGroupDetailsOfCustomerDTO>, IEnumerable<TouristGroupDetailsOfCustomer>>(newListTouristGroupDetailsOfCustomerDto);
                await _repository.UpdateTouristGroupDetailsOfCustomer(touristgroupid, newListTouristGroupDetailsOfCustomer.ToList());
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
        private async Task<bool> costDetailsExists(int id)
        {
            var costDetails = await _repository.GetCostDetails(id);
            if (costDetails != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateCostDetails(CostDetailsDTO costDetailsDto)
        {
            var costDetails = _mapper.Map<CostDetailsDTO, CostDetails>(costDetailsDto);
            await _repository.AddCostDetails(costDetails);
            return Ok(costDetails);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCostDetails(int id, CostDetailsDTO costDetailsDTO)
        {
            if (id != costDetailsDTO.Id)
            {
                return BadRequest();
            }
            try
            {
                var costDetails = _mapper.Map<CostDetailsDTO, CostDetails>(costDetailsDTO);
                await _repository.UpdateCostDetails(costDetails);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await costDetailsExists(id))
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
        public async Task<IActionResult> DeleteCostDetails(int id)
        {
            if (await costDetailsExists(id))
            {
                await _repository.DeleteCostDetails(id);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}