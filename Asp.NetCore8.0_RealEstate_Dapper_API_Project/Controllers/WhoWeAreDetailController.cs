using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.WhoWeAreDetailDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.WhoWeAreRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        private readonly IWhoWeAreDetailRepository _whoWeAreDetailRepository;

        public WhoWeAreDetailController(IWhoWeAreDetailRepository whoWeAreDetailRepository)
        {
            _whoWeAreDetailRepository = whoWeAreDetailRepository;
        }
        [HttpGet]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var values = await _whoWeAreDetailRepository.GetAllWhoWeAreDetail();
            return Ok(values);
            //NULL UPDATE

        }
        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAreDetailAsync(CreateWhoWeAreDetailDTO createWhoWeAreDetailDTO)
        {
            await _whoWeAreDetailRepository.CreateWhoWeAreDetail(createWhoWeAreDetailDTO);
            return Ok("Hakkımızda Detayları Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
        {
            await _whoWeAreDetailRepository.DeleteWhoWeAreDetail(id);
            return Ok("Hakkımızda Detayları Başarılı Bir Şekilde Silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDTO updateWhoWeAreDetailDTO)
        {
            await _whoWeAreDetailRepository.UpdateWhoWeAreDetail(updateWhoWeAreDetailDTO);
            return Ok("Hakkımızda Detayları Başarılı Bir Şekilde Güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAreDetail(int id)
        {
            var values = await _whoWeAreDetailRepository.GetWhoWeAreDetail(id);
            return Ok(values);
        }
    }
}
