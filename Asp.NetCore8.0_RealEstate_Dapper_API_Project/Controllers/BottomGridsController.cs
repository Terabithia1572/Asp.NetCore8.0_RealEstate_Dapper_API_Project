using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.BottomGridDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.BottomGridRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridsController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }
        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var values = await _bottomGridRepository.GetAllBottomGridAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBottomGrid(CreateBottomGridDTO createBottomGridDTO)
        {
            _bottomGridRepository.CreateBottomGrid(createBottomGridDTO);
            return Ok("Veri Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBottomGrid(int id)
        {
             _bottomGridRepository.DeleteBottomGrid(id);
            return Ok("Veri Başarılı Bir Şekilde Silindi");
        }
        [HttpPut]
        public IActionResult UpdateBottomGrid(UpdateBottomGridDTO updateBottomGridDTO)
        {
            _bottomGridRepository.UpdateBottomGrid(updateBottomGridDTO);
            return Ok("Veri Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBottomGrid(int id)
        {
            var value = await _bottomGridRepository.GetBottomGrid(id);
            return Ok(value);
        }

    }
}
