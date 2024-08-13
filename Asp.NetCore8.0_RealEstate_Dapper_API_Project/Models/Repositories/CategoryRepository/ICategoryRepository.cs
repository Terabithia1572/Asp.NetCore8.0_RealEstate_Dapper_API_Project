using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.CategoryDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDTO>> GetAllCategoryAsync();
        void CreateCategory(CreateCategoryDTO createCategoryDTO);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDTO updateCategoryDTO);

    }
}
