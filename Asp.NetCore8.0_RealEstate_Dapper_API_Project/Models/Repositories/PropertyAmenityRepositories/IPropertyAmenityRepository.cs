using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.PropertyAmenityDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.PropertyAmenityRepositories
{
    public interface IPropertyAmenityRepository
    {
        Task <List<ResultPropertyAmenityByStatusTrueDTO>> ResultPropertyAmenityByStatusTrue(int id);
    }
}
