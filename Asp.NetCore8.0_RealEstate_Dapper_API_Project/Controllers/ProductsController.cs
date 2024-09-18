using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ProductRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }
        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
        [HttpGet("ProductDailyOfTheDayStatusChangeToTrue/{id}")]
        public async Task<IActionResult> ProductDailyOfTheDayStatusChangeToTrue(int id)
        {
            _productRepository.ProductDailyOfTheDayStatusChangeToTrue(id);
            return Ok("İlan Günün Fırsatlarına Eklendi");
        }
        [HttpGet("ProductDailyOfTheDayStatusChangeToFalse/{id}")]
        public async Task<IActionResult> ProductDailyOfTheDayStatusChangeToFalse(int id)
        {
            _productRepository.ProductDailyOfTheDayStatusChangeToFalse(id);
            return Ok("İlan Günün Fırsatlarından Çıkarıldı");
        }
        [HttpGet("Last5ProductList")]
        public async Task<IActionResult> Last5ProductList()
        {
            var values = await _productRepository.GetLast5ProductAsync();
            return Ok(values);
        }
        [HttpGet("ProductAdvertsListByEmployee")]
        public async Task<IActionResult> ProductAdvertsListByEmployee(int id)
        {
            var values = await _productRepository.GetProductAdvertsListByEmployeeAsync(id);
            return Ok(values);
        }
    }
}
