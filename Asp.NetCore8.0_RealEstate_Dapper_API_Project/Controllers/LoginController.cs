using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.LoginDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Tools;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly Context _context;

        public LoginController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(CreateLoginDTO createLoginDTO)
        {
            string query = "select * from AppUser where Username=@username and Password=@password";
            string query2 = "select UserID from AppUser where Username=@username and Password=@password";
            var parameters = new DynamicParameters();
            parameters.Add("@username", createLoginDTO.Username);
            parameters.Add("@password", createLoginDTO.Password);
            using (var connection = _context.CreateConnection())
            {
                var values=await connection.QueryFirstOrDefaultAsync<CreateLoginDTO>(query,parameters);
                var values2=await connection.QueryFirstOrDefaultAsync<GetAppUserIDDTO>(query2,parameters);
                if(values != null)
                {
                    GetCheckAppUserViewModel getCheckAppUserViewModel = new GetCheckAppUserViewModel();

                    getCheckAppUserViewModel.Username=createLoginDTO.Username;
                    getCheckAppUserViewModel.ID = values2.UserID;
                    var token = JWTTokenGenerator.GenerateToken(getCheckAppUserViewModel);
                    return Ok(token);
                }
                else
                {
                    return Ok("Başarısız");
                }
            }
        }
    }
}
