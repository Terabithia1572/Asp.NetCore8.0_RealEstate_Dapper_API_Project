using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.BottomGridDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ServiceDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDTO>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDTO createBottomGridDTO);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBottomGridDTO updateBottomGridDTO);
        Task<GetBottomGridDTO> GetBottomGrid(int id);
    }
}
