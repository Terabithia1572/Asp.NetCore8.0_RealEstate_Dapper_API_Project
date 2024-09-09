using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.PopularLocationDTO;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.PopularLocationRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocationRepository;

        public PopularLocationsController(IPopularLocationRepository popularLocationRepository)
        {
            _popularLocationRepository = popularLocationRepository;
        }
        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var values =await _popularLocationRepository.GetAllPopularLocationAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePopularLocationAsync(CreatePopularLocationDTO createPopularLocationDTO)
        {
            _popularLocationRepository.CreatePopularLocation(createPopularLocationDTO);
            return Ok("Popüler Lokasyonlar Detayları Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePopularLocation(int id)
        {
            _popularLocationRepository.DeletePopularLocation(id);
            return Ok("Popüler Lokasyonlar Detayları Başarılı Bir Şekilde Silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePopularLocation(UpdatePopularLocationDTO updatePopularLocationDTO)
        {
            _popularLocationRepository.UpdatePopularLocation(updatePopularLocationDTO);
            return Ok("Popüler Lokasyonlar Detayları Başarılı Bir Şekilde Güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPopularLocation(int id)
        {
            var values = await _popularLocationRepository.GetPopularLocation(id);
            return Ok(values);
        }
    }
}
