using cleanarchitecture.Application.Service;
using cleanarchitecture.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService= (EmployeeService?)employeeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var emp =await _employeeService.GetAllAsync();
            return Ok(emp);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var emp = await _employeeService.GetByIdAsync(id);
            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee) 
        {
            var Createdemp = await _employeeService.CreateAsync(employee);
            return CreatedAtAction(nameof(GetById), new { id = Createdemp.Id }, Createdemp);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Employee employee)
        {

            var updatedEmployee = await _employeeService.UpdateAsync(id, employee);
            if (updatedEmployee == null)
            {
                return NotFound();
            }
            return Ok(updatedEmployee);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete (int id)
        {
          bool emp = await _employeeService.DeleteAsync(id);
            
            return NoContent();
        }

    }
}
