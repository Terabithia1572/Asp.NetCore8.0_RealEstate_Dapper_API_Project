using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentLastProductController : ControllerBase
    {
        private readonly ILast5ProductRepository _last5ProductRepository;

        public EstateAgentLastProductController(ILast5ProductRepository last5ProductRepository)
        {
            _last5ProductRepository = last5ProductRepository;
        }
        [HttpGet]
        public async Task< IActionResult> GetLast5ProductAsync(int id)
        {
            var values =await _last5ProductRepository.GetLast5ProductAsync(id);
            return Ok(values);
        }
    }
}
