using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentStatisticController : ControllerBase
    {
        private readonly IStatisticRepository _statisticRepository;

        public EstateAgentStatisticController(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }
        [HttpGet("AllProductCount")]
        public IActionResult AllProductCount()
        {
            return Ok(_statisticRepository.AllProductCount());
        }
        [HttpGet("ProductCountByEmployeeID")]
        public IActionResult ProductCountByEmployeeID(int id)
        {
            return Ok(_statisticRepository.ProductCountByEmployeeID(id));
        }
        [HttpGet("StatusProductCountByStatusFalse")]
        public IActionResult StatusProductCountByStatusFalse(int id)
        {
            return Ok(_statisticRepository.StatusProductCountByStatusFalse(id));
        }
        [HttpGet("StatusProductCountByStatusTrue")]
        public IActionResult StatusProductCountByStatusTrue(int id)
        {
            return Ok(_statisticRepository.StatusProductCountByStatusTrue(id));
        }
    }
}
