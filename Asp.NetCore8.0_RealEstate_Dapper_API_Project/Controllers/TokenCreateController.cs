using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenCreateController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateToken(GetCheckAppUserViewModel getCheckAppUserViewModel)
        {
            var values = JWTTokenGenerator.GenerateToken(getCheckAppUserViewModel);
            return Ok(values);
        }
    }
}
