using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.WhoWeAreDetailDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.WhoWeAreDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDTO>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDetail(CreateWhoWeAreDetailDTO createWhoWeAreDetailDTO);
        void DeleteWhoWeAreDetail(int id);
        void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDTO updateWhoWeAreDetailDTO);
        Task<GetByIDWhoWeAreDetail> GetWhoWeAreDetail(int id);
    }
}
