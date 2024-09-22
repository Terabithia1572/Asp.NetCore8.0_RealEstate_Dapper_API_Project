using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ChartDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories
{
    public class ChartRepository : IChartRepository
    {
        private readonly Context _context;

        public ChartRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultChartDTO>> Get5CityForChart()
        {
            string query = "select TOP(5) ProductCity,Count(*) as 'CityCount' from Product Group By ProductCity order by CityCount desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultChartDTO>(query);
                return values.ToList();
            }
        }
    }
}
