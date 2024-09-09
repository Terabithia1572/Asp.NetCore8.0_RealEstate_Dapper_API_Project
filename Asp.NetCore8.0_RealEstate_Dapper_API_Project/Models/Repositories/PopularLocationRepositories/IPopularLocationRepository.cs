using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.BottomGridDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.PopularLocationDTO;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDTO>> GetAllPopularLocationAsync();
        void CreatePopularLocation(CreatePopularLocationDTO createPopularLocationDTO);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(UpdatePopularLocationDTO updatePopularLocationDTO);
        Task<GetByIDPopularLocationDTO> GetPopularLocation(int id);
    }
}
