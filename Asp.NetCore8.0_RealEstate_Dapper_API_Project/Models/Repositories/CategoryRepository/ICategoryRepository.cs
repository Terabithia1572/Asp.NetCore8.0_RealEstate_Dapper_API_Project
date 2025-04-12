using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.CategoryDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDTO>> GetAllCategory();
        Task CreateCategory(CreateCategoryDTO createCategoryDTO);
        Task DeleteCategory(int id);
        Task UpdateCategory(UpdateCategoryDTO updateCategoryDTO);
        Task<GetByIDCategoryDTO> GetCategory(int id);
    }
}
