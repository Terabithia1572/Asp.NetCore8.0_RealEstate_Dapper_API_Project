using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.AppUserDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly Context _context;

        public AppUserRepository(Context context)
        {
            _context = context;
        }

        public async Task<GetAppUserByProductID> GetAppUserByProductID(int id)
        {
            string query = "Select * from AppUser where UserID=@UserID";
            var parameters = new DynamicParameters();
            parameters.Add("@UserID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetAppUserByProductID>(query, parameters);
                return values;
            }
        }
    }
}
