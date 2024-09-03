using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.BottomGridDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.PopularLocationDTO;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDTO>> GetAllPopularLocationAsync();
     
    }
}
