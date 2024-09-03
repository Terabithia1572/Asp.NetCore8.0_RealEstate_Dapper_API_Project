using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.TestimonialRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialsController(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }
        [HttpGet]
        public async Task< IActionResult> TestimonialResult()
        {
            var values=await _testimonialRepository.GetAllTestimonialAsync();
            return Ok(values);
        }
    }
}
