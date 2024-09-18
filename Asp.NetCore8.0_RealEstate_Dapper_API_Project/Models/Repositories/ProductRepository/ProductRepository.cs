using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.CategoryDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ProductDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultProductDTO>> GetAllProductAsync()
        {
            string query = "select * from Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDTO>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDTO>> GetAllProductWithCategoryAsync()
        {
            string query = "select ProductID,ProductTitle,ProductPrice,ProductCoverImage,ProductCity,ProductDistrict,ProductAddress,ProductDescription,ProductType,CategoryName,ProductDailyOfTheDay from Product inner join Category on Product.ProductCategory=Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDTO>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultLast5ProductWithCategoryDTO>> GetLast5ProductAsync()
        {
            string query = "select Top(5) ProductID,ProductTitle,ProductPrice,ProductCity,ProductDistrict,ProductCategory,CategoryName,ProductAdvertisementDate from Product inner join Category on Product.ProductCategory=Category.CategoryID where ProductType='Kiralık' order By ProductID desc\r\n";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductWithCategoryDTO>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductAdvertListWithCategoryWithByEmployeeDTO>> GetProductAdvertsListByEmployeeAsync(int id)
        {
            string query = "select ProductID,ProductTitle,ProductPrice,ProductCoverImage,ProductCity,ProductDistrict,ProductAddress,ProductDescription,ProductType,CategoryName,ProductDailyOfTheDay from Product inner join Category on Product.ProductCategory=Category.CategoryID where EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductAdvertListWithCategoryWithByEmployeeDTO>(query,parameters);
                return values.ToList();
            }
        }

        public async void ProductDailyOfTheDayStatusChangeToFalse(int id)
        {
            string query = "Update Product Set ProductDailyOfTheDay=0 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void ProductDailyOfTheDayStatusChangeToTrue(int id)
        {
            string query = "Update Product Set ProductDailyOfTheDay=1 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
