using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.CategoryDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;
using Humanizer;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using NuGet.Protocol.Plugins;
using System.Numerics;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async void CreateCategory(CreateCategoryDTO createCategoryDTO) 
     //Bu kod, bir kategoriyi veritabanına eklemek için kullanılan bir metodu tanımlar. Metodun amacı, verilen kategoriyi veritabanına kaydetmektir. Aşağıda kodun detaylı açıklaması bulunmaktadır:
        {
//            public: Bu metot, sınıfın dışından erişilebilir.
//async void: Bu metot asenkron çalışır, yani başka işlemler devam ederken bu metot da çalışmaya devam eder. void döndüğü için çağırıldığı yerde sonuç beklenmez.Genellikle asenkron işlemlerde hata yönetimi zor olduğu için async Task kullanılması daha iyi bir yaklaşımdır.
//        CreateCategory: Metodun adı. Bu metot bir kategori oluşturmak için kullanılır.
//        CreateCategoryDTO createCategoryDTO: Bu parametre, yeni kategori oluşturmak için gerekli bilgileri içeren bir Data Transfer Object (DTO) türünde bir parametredir.
            string query = "insert into Category (CategoryName,CategoryStatus) values (@categoryName,@categoryStatus)";
        //query: Bu değişken, kategoriyi veritabanına eklemek için kullanılacak SQL sorgusunu tutar.Sorgu, Category tablosuna bir satır eklemek için yazılmıştır ve CategoryName ve CategoryStatus sütunlarına değerleri yerleştirir.
            var parameters = new DynamicParameters();
        //parameters: DynamicParameters sınıfı, SQL sorgusuna dinamik parametreler eklemek için kullanılır. Bu, SQL enjeksiyon saldırılarına karşı koruma sağlar.
            parameters.Add("@categoryName", createCategoryDTO.CategoryName);
            parameters.Add("@categoryStatus", true);
//            parameters.Add("categoryName", createCategoryDTO.CategoryName);: Sorgu içinde kullanılacak categoryName parametresine, createCategoryDTO nesnesinden alınan CategoryName değeri atanır.
//parameters.Add("categoryStatus", true);: categoryStatus parametresine ise true değeri atanır. Bu, kategorinin aktif olduğunu gösterir.
            using (var connection=_context.CreateConnection())
            {
                await connection.ExecuteAsync(query,parameters);
            }
//            using (var connection = _context.CreateConnection()): using bloğu, veritabanı bağlantısının iş bitiminde otomatik olarak kapatılmasını sağlar._context.CreateConnection() metodu, veritabanına bir bağlantı oluşturur.
//await connection.ExecuteAsync(query, parameters);: Bu satır, SQL sorgusunu ve parametreleri veritabanına asenkron olarak gönderir ve sorgunun yürütülmesini sağlar.Bu, kategorinin veritabanına eklenmesini sağlar.
//Özetle: Bu metod, verilen kategori bilgilerini alır ve bu bilgileri kullanarak Category tablosuna yeni bir kayıt ekler.Asenkron çalıştığı için diğer işlemler devam ederken bu işlem arka planda yürütülür.
        }

        public async void DeleteCategory(int id)
        {
            string query = "delete from Category where CategoryID=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
            
        }

        public async Task<List<ResultCategoryDTO>> GetAllCategoryAsync()
        {
            string query = "select * from Category";
            using(var connection=_context.CreateConnection())
            {
                var values=await connection.QueryAsync<ResultCategoryDTO>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDCategoryDTO> GetCategory(int id)
        {
            string query = "Select * from Category where CategoryID=@categoryID";
            var parameters=new DynamicParameters();
            parameters.Add("@categoryID", id);
            using(var connection= _context.CreateConnection())
            {
              var values=  await connection.QueryFirstOrDefaultAsync<GetByIDCategoryDTO>(query,parameters);
                return values;
            }
        }

        public async void UpdateCategory(UpdateCategoryDTO updateCategoryDTO)
        {
            string query = "Update Category Set CategoryName=@categoryName,CategoryStatus=@categoryStatus where CategoryID=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", updateCategoryDTO.CategoryName);
            parameters.Add("@categoryStatus", updateCategoryDTO.CategorStatus);
            parameters.Add("@categoryID", updateCategoryDTO.CategoryID);
            using(var connections=_context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
        }
    }
}
