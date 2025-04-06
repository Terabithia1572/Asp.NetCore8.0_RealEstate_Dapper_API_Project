using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.AppUserRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly IAppUserRepository _appUserRepository;

        public AppUsersController(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAppUserByProductID(int id)
        {
            var values = await _appUserRepository.GetAppUserByProductID(id);
            if (values == null)
            {
                return NotFound();
            }
            return Ok(values);
        }
    }
}
