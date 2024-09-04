using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.CategoryDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.EmployeeDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.CategoryRepository;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EmployeeRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _employeeRepository.GetAllEmployeeAsync();
            return Ok(values);
            //NULL UPDATE

        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployeeAsync(CreateEmployeeDTO createEmployeeDTO)
        {
            _employeeRepository.CreateEmployee(createEmployeeDTO);
            return Ok("Personel Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return Ok("Personel Başarılı Bir Şekilde Silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO)
        {
            _employeeRepository.UpdateEmployee(updateEmployeeDTO);
            return Ok("Personel Başarılı Bir Şekilde Güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var values = await _employeeRepository.GetEmployee(id);
            return Ok(values);
        }
    }
}
