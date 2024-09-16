using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ToDoListDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ToDoListRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListsController : ControllerBase
    {
        private readonly IToDoListRepository _toDoListRepository;

        public ToDoListsController(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ToDoListList()
        {
            var values = await _toDoListRepository.GetAllToDoListAsync();
            return Ok(values);
            //NULL UPDATE

        }
        [HttpPost]
        public async Task<IActionResult> CreateToDoListAsync(CreateToDoListDTO createToDoListDTO)
        {
            _toDoListRepository.CreateToDoList(createToDoListDTO);
            return Ok("Personel Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDoList(int id)
        {
            _toDoListRepository.DeleteToDoList(id);
            return Ok("Personel Başarılı Bir Şekilde Silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateToDoList(UpdateToDoListDTO updateToDoListDTO)
        {
            _toDoListRepository.UpdateToDoList(updateToDoListDTO);
            return Ok("Personel Başarılı Bir Şekilde Güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetToDoList(int id)
        {
            var values = await _toDoListRepository.GetToDoList(id);
            return Ok(values);
        }
    }
}
