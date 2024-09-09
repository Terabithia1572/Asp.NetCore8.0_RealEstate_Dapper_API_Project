using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ServiceDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ServiceRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServicesController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpGet]
        public async Task< IActionResult> GetServiceList() {

            var values =await _serviceRepository.GetAllServiceAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateServiceAsync(CreateServiceDTO createServiceDTO)
        {
            _serviceRepository.CreateService(createServiceDTO);
            return Ok("Servis Detayları Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            _serviceRepository.DeleteService(id);
            return Ok("Servis Detayları Başarılı Bir Şekilde Silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDTO updateServiceDTO)
        {
            _serviceRepository.UpdateService(updateServiceDTO);
            return Ok("Servis Detayları Başarılı Bir Şekilde Güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var values = await _serviceRepository.GetService(id);
            return Ok(values);
        }
    }
}
