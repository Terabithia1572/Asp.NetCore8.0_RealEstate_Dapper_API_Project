using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ProductRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductDetailsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("GetProductDetailByProductID")]
        public async Task<IActionResult> GetProductDetailByProductID(int id)
        {
            var values = await _productRepository.GetProductDetailByProductID(id);
            return Ok(values);
        }
    }
}
