
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ServiceDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDTO>> GetAllService();
        Task CreateService(CreateServiceDTO createServiceDTO);
        Task DeleteService(int id);
        Task UpdateService(UpdateServiceDTO updateServiceDTO);
        Task<GetByIDServiceDTO> GetService(int id);
    }
}
