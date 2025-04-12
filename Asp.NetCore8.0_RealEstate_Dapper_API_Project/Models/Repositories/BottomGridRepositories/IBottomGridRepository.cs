using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.BottomGridDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ServiceDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDTO>> GetAllBottomGrid();
        Task CreateBottomGrid(CreateBottomGridDTO createBottomGridDTO);
        Task DeleteBottomGrid(int id);
        Task UpdateBottomGrid(UpdateBottomGridDTO updateBottomGridDTO);
        Task<GetBottomGridDTO> GetBottomGrid(int id);
    }
}
