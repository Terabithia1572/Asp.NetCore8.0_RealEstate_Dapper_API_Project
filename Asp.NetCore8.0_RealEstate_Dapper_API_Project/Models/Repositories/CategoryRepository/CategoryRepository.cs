using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.CategoryDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultCategoryDTO>> GetAllCategoryAsync()
        {
            string query = "select * from Category";
            using(var connection=_context.CreateConnection())
            {
                var values=await connection.QueryAsync<ResultCategoryDTO>(query);
                return values.ToList();
            }
        }
    }
}
