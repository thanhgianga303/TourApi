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
    public class JobController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IJobRepository _repository;
        public JobController(IMapper mapper, IJobRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobDTO>>> GetAllJob()
        {
            var jobs = await _repository.GetAll();
            var jobsDTO = _mapper.Map<IEnumerable<Job>, IEnumerable<JobDTO>>(jobs);
            return Ok(jobsDTO);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<JobDTO>>> GetJob(int id)
        {
            var job = await _repository.GetBy(id);
            var jobDTO = _mapper.Map<Job, JobDTO>(job);
            return Ok(jobDTO);
        }
        [HttpPost]
        public async Task<IActionResult> CreateJob(JobDTO jobDto)
        {
            var job = _mapper.Map<JobDTO, Job>(jobDto);
            await _repository.Add(job);
            return CreatedAtAction(nameof(GetJob), new { id = job.JobId }, job);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJob(int id, JobDTO jobDto)
        {
            if (id != jobDto.JobId)
            {
                return BadRequest();
            }
            try
            {
                var job = _mapper.Map<JobDTO, Job>(jobDto);
                await _repository.Update(id, job);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await JobExists(id))
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
        private async Task<bool> JobExists(int id)
        {
            var job = await _repository.GetBy(id);
            if (job != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            if (await JobExists(id))
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