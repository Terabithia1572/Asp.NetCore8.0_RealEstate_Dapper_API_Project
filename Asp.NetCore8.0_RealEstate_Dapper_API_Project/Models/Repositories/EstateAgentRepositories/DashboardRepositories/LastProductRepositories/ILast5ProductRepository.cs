using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ProductDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductRepositories
{
    public interface ILast5ProductRepository
    {
        Task<List<ResultLast5ProductWithCategoryDTO>> GetLast5ProductAsync(int id);
    }
}
