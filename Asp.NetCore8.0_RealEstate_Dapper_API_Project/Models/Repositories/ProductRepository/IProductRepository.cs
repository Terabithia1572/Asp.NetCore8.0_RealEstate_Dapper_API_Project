using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ProductDetailDTO;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ProductDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDTO>> GetAllProductAsync();
        Task<List<ResultProductAdvertListWithCategoryWithByEmployeeDTO>> GetProductAdvertsListByEmployeeAsyncByTrue(int id);
        Task<List<ResultProductAdvertListWithCategoryWithByEmployeeDTO>> GetProductAdvertsListByEmployeeAsyncByFalse(int id);
        Task<List<ResultProductWithCategoryDTO> > GetAllProductWithCategoryAsync();
        Task ProductDailyOfTheDayStatusChangeToTrue(int id);
        Task ProductDailyOfTheDayStatusChangeToFalse(int id);
        Task<List<ResultLast5ProductWithCategoryDTO>> GetLast5ProductAsync();
        Task CreateProduct(CreateProductDTO createProductDTO);

        Task<GetProductByProductIDDTO> GetProductByProductID(int id);
        Task<GetProductDetailByIDDTO> GetProductDetailByProductID(int id);
        Task<List<ResultProductWithSearchListDTO>> ResultProductWithSearchList(string searchKeyValue,int propertyCategoryID,string city);
        Task<List<ResultProductWithCategoryDTO>> GetProductDailyOfTheDayTrueWithCategoryAsync();
    }
}
