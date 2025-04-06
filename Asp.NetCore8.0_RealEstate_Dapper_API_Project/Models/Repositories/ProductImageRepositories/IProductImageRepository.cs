using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ProoductImageDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIDDTO>> GetProductImageByProductID(int id);

    }
}
