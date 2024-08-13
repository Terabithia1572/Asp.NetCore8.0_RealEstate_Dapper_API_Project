using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.CategoryDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.CategoryRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values=await _categoryRepository.GetAllCategoryAsync();
            return Ok(values);
            //NULL UPDATE
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategoryAsync(CreateCategoryDTO createCategoryDTO)
        {
             _categoryRepository.CreateCategory(createCategoryDTO);
            return Ok("Kategori Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok("Kategori Başarılı Bir Şekilde Silindi.");
        }
    }
}
