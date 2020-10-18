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
    public class StaffController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IStaffRepository _repository;
        public StaffController(IMapper mapper, IStaffRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StaffDTO>>> GetAllStaff()
        {
            var staffs = await _repository.GetAll();
            var staffsDTO = _mapper.Map<IEnumerable<Staff>, IEnumerable<StaffDTO>>(staffs);
            return Ok(staffsDTO);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<StaffDTO>>> GetStaff(int id)
        {
            var staff = await _repository.GetBy(id);
            var staffDTO = _mapper.Map<Staff, StaffDTO>(staff);
            return Ok(staffDTO);
        }
        [HttpPost]
        public async Task<IActionResult> CreateStaff(StaffDTO staffDto)
        {
            var staff = _mapper.Map<StaffDTO, Staff>(staffDto);
            await _repository.Add(staff);
            return CreatedAtAction(nameof(GetStaff), new { id = staff.StaffId }, staff);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStaff(int id, StaffDTO staffDto)
        {
            if (id != staffDto.StaffId)
            {
                return BadRequest();
            }
            try
            {
                var staff = _mapper.Map<StaffDTO, Staff>(staffDto);
                await _repository.Update(id, staff);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await StaffExists(id))
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
        private async Task<bool> StaffExists(int id)
        {
            var staff = await _repository.GetBy(id);
            if (staff != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            if (await StaffExists(id))
            {
                await _repository.Delete(id);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
        //JobDetails
        [HttpPost]
        public async Task<IActionResult> CreateJobDetails(List<JobDetailsDTO> listJobDetailsDto)
        {
            var listJobDetails = _mapper.Map<IEnumerable<JobDetailsDTO>, IEnumerable<JobDetails>>(listJobDetailsDto);
            await _repository.AddJobDetails(listJobDetails.ToList());
            return Ok(listJobDetails);
        }
    }
}