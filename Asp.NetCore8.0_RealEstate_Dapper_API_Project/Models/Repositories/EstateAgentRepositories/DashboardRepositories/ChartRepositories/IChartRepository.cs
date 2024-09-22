using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ChartDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories
{
    public interface IChartRepository
    {
        Task<List<ResultChartDTO>> Get5CityForChart();
    }
}
