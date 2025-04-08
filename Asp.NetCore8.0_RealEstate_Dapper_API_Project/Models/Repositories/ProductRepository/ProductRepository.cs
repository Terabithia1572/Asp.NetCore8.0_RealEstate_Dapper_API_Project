using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.CategoryDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ProductDetailDTO;
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

        public async Task CreateProduct(CreateProductDTO createProductDTO)
        {
            string query = "insert into Product (ProductTitle,ProductPrice,ProductCoverImage,ProductCity,ProductDistrict,ProductAddress,ProductDescription,ProductType,ProductDailyOfTheDay,ProductAdvertisementDate,ProductStatus,ProductCategory,EmployeeID) values " +
                "(@productTitle,@productPrice,@productCoverImage,@productCity,@productDistrict,@productAddress,@productDescription,@productType,@productDailyOfTheDay,@productAdvertisementDate,@productStatus,@productCategory,@employeeID)";
            var parameters = new DynamicParameters();
            parameters.Add("@productTitle", createProductDTO.ProductTitle);
            parameters.Add("@productPrice", createProductDTO.ProductPrice);
            parameters.Add("@productCoverImage", createProductDTO.ProductCoverImage);
            parameters.Add("@productCity", createProductDTO.ProductCity);
            parameters.Add("@productDistrict", createProductDTO.ProductDistrict);
            parameters.Add("@productAddress", createProductDTO.ProductAddress);
            parameters.Add("@productDescription", createProductDTO.ProductDescription);
            parameters.Add("@productType", createProductDTO.ProductType);
            parameters.Add("@productCategory", createProductDTO.ProductCategory);
            parameters.Add("@employeeID", createProductDTO.EmployeeID);
            parameters.Add("@productDailyOfTheDay", createProductDTO.ProductDailyOfTheDay);
            parameters.Add("@productAdvertisementDate", createProductDTO.ProductAdvertisementDate);
            parameters.Add("@productStatus", true);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
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

        public async Task<List<ResultProductAdvertListWithCategoryWithByEmployeeDTO>> GetProductAdvertsListByEmployeeAsyncByFalse(int id)
        {
            string query = "select ProductID,ProductTitle,ProductPrice,ProductCoverImage,ProductCity,ProductDistrict,ProductAddress,ProductDescription,ProductType,CategoryName,ProductDailyOfTheDay from Product inner join Category on Product.ProductCategory=Category.CategoryID where EmployeeID=@employeeID and ProductStatus=0 ";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductAdvertListWithCategoryWithByEmployeeDTO>(query, parameters);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductAdvertListWithCategoryWithByEmployeeDTO>> GetProductAdvertsListByEmployeeAsyncByTrue(int id)
        {
            string query = "select ProductID,ProductTitle,ProductPrice,ProductCoverImage,ProductCity,ProductDistrict,ProductAddress,ProductDescription,ProductType,CategoryName,ProductDailyOfTheDay from Product inner join Category on Product.ProductCategory=Category.CategoryID where EmployeeID=@employeeID and ProductStatus=1 ";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductAdvertListWithCategoryWithByEmployeeDTO>(query,parameters);
                return values.ToList();
            }
        }

        public async Task<GetProductByProductIDDTO> GetProductByProductID(int id)
        {
            string query = "select ProductID,ProductTitle,ProductPrice,ProductCoverImage,ProductCity,ProductDistrict,ProductAddress,ProductDescription,ProductType,CategoryName,ProductDailyOfTheDay,ProductAdvertisementDate from Product inner join Category on Product.ProductCategory=Category.CategoryID where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetProductByProductIDDTO>(query,parameters);
                return values.FirstOrDefault();
            }
            
        }

        public async Task<GetProductDetailByIDDTO> GetProductDetailByProductID(int id)
        {
            string query = "select * from ProductDetails where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetProductDetailByIDDTO>(query, parameters);
                return values.FirstOrDefault();
            }

        }

        public async Task ProductDailyOfTheDayStatusChangeToFalse(int id)
        {
            string query = "Update Product Set ProductDailyOfTheDay=0 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task ProductDailyOfTheDayStatusChangeToTrue(int id)
        {
            string query = "Update Product Set ProductDailyOfTheDay=1 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultProductWithSearchListDTO>> ResultProductWithSearchList(string searchKeyValue, int propertyCategoryID, string city)
        {
            string query = "Select * from product Where ProductTitle like '%"+searchKeyValue+"%' and ProductCategory=@propertyCategoryID and ProductCity=@city";
            var parameters = new DynamicParameters();
            //parameters.Add("@searchKeyValue", searchKeyValue);
            parameters.Add("@propertyCategoryID", propertyCategoryID);
            parameters.Add("@city", city);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithSearchListDTO>(query, parameters);
                return values.ToList();
            }
        }
    }
}
