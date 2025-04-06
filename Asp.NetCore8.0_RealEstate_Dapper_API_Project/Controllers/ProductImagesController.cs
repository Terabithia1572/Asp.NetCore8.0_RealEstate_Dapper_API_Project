using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ProductImageRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IProductImageRepository _productImageRepository;

        public ProductImagesController(IProductImageRepository productImageRepository)
        {
            _productImageRepository = productImageRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductImageID(int id)
        {
            var values = await _productImageRepository.GetProductImageByProductID(id);
            if (values != null)
            {
                return Ok(values);
            }
            return NotFound();
        }
    }
}
