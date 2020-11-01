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
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _repository;
        public CustomerController(IMapper mapper, ICustomerRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDTO>>> GetAllCustomer()
        {
            var customers = await _repository.GetAll();
            var customersDTO = _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerDTO>>(customers);
            return Ok(customersDTO);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<CustomerDTO>>> GetCustomer(int id)
        {
            var customer = await _repository.GetBy(id);
            var customerDTO = _mapper.Map<Customer, CustomerDTO>(customer);
            return Ok(customerDTO);
        }
        [HttpPost("{groupid}")]
        public async Task<IActionResult> CreateCustomer(int groupid, CustomerDTO customerDto)
        {
            var customer = _mapper.Map<CustomerDTO, Customer>(customerDto);
            await _repository.Add(customer);
            await _repository.AddTourDetailsOfCustomer(new TouristGroupDetailsOfCustomer
            {
                CustomerId = customer.CustomerId,
                TouristGroupId = groupid
            });
            return CreatedAtAction(nameof(GetCustomer), new { id = customer.CustomerId }, customer);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, CustomerDTO customerDto)
        {
            if (id != customerDto.CustomerId)
            {
                return BadRequest();
            }
            try
            {
                var customer = _mapper.Map<CustomerDTO, Customer>(customerDto);
                await _repository.Update(id, customer);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CustomerExists(id))
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
        private async Task<bool> CustomerExists(int id)
        {
            var customer = await _repository.GetBy(id);
            if (customer != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            if (await CustomerExists(id))
            {
                await _repository.Delete(id);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTourDetailsOfCustomer(int id)
        {
            var tourDetailsOfCustomer = _repository.GetTouristGroupDetailsOfCustomer(id);
            if (tourDetailsOfCustomer != null)
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