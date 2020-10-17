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
    public class TypesOfTourismController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITypesOfTourismRepository _repository;
        public TypesOfTourismController(IMapper mapper, ITypesOfTourismRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypesOfTourismDTO>>> GetAll()
        {
            var listTypesOfTourism = await _repository.GetAll();
            var listTypesOfTourismDTO = _mapper.Map<IEnumerable<TypesOfTourism>, IEnumerable<TypesOfTourismDTO>>(listTypesOfTourism);
            return Ok(listTypesOfTourismDTO);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TypesOfTourismDTO>>> GetTypesOfTourism(int id)
        {
            var TypesOfTourism = await _repository.GetBy(id);
            var TypesOfTourismDTO = _mapper.Map<TypesOfTourism, TypesOfTourismDTO>(TypesOfTourism);
            return Ok(TypesOfTourismDTO);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTypesOfTourism(TypesOfTourismDTO typesOfTourismDTO)
        {
            var typesOfTourism = _mapper.Map<TypesOfTourismDTO, TypesOfTourism>(typesOfTourismDTO);
            await _repository.Add(typesOfTourism);
            return CreatedAtAction(nameof(GetTypesOfTourism), new { id = typesOfTourism.TypesOfTourismId }, typesOfTourism);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTypesOfTourism(int id, TypesOfTourismDTO typesOfTourismDTO)
        {
            if (id != typesOfTourismDTO.TypesOfTourismId)
            {
                return BadRequest();
            }
            try
            {
                var typesOfTourism = _mapper.Map<TypesOfTourismDTO, TypesOfTourism>(typesOfTourismDTO);
                await _repository.Update(id, typesOfTourism);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await TypesOfTourismExists(id))
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
        private async Task<bool> TypesOfTourismExists(int id)
        {
            var typesOfTourism = await _repository.GetBy(id);
            if (typesOfTourism != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypesOfTourism(int id)
        {
            if (await TypesOfTourismExists(id))
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