using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.SubFeatureDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.SubFeatureRepositories
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDTO>> GetAllSubFeatureAsync();
    }
}
