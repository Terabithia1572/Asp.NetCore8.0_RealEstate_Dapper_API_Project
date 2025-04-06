using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.AppUserDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.AppUserRepositories
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductID> GetAppUserByProductID(int id);
    }
}
