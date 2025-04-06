using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ProoductImageDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ProductImageRepositories
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly Context _context;

        public ProductImageRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<GetProductImageByProductIDDTO>> GetProductImageByProductID(int id)
        {
            string query = "Select * from ProductImage where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetProductImageByProductIDDTO>(query, parameters);
                return values.ToList();
            }
        }
    }
}
