using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.SubFeatureRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubFeaturesController : ControllerBase
    {
        private readonly ISubFeatureRepository _subFeatureRepository;

        public SubFeaturesController(ISubFeatureRepository subFeatureRepository)
        {
            _subFeatureRepository = subFeatureRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSubFeatureList()
        {
            var values = await _subFeatureRepository.GetAllSubFeatureAsync();
            if (values == null)
            {
                return NotFound();
            }
            return Ok(values);
        }
    }
}
