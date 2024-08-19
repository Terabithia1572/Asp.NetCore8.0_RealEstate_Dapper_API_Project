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
    }
}
