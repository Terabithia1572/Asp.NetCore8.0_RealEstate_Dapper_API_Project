using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ProductDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductRepositories
{
    public class Last5ProductRepository : ILast5ProductRepository
    {
        private readonly Context _context;

        public Last5ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultLast5ProductWithCategoryDTO>> GetLast5ProductAsync(int id)
        {

            string query = "select Top(5) ProductID,ProductTitle,ProductPrice,ProductCity,ProductDistrict,ProductCategory,CategoryName,ProductAdvertisementDate from Product inner join Category on Product.ProductCategory=Category.CategoryID where EmployeeID=@employeeID order By ProductID desc\r\n";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductWithCategoryDTO>(query,parameters);
                return values.ToList();
            }
        }
    }
}
