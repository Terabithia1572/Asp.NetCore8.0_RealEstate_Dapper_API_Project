using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly Context _context;

        public StatisticRepository(Context context)
        {
            _context = context;
        }

        public int AllProductCount()
        {
            string query = "select Count(*) as 'Toplam Ürün Sayısı' from Category";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ProductCountByEmployeeID(int id)
        {
            string query = "select Count(*) as 'Toplam Ürün Sayısı' from Product where EmployeeID=@employeeID ";
            var parameters = new DynamicParameters();
            //parameters: DynamicParameters sınıfı, SQL sorgusuna dinamik parametreler eklemek için kullanılır. Bu, SQL enjeksiyon saldırılarına karşı koruma sağlar.
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query,parameters);
                return values;
            }
        }

        public int StatusProductCountByStatusFalse(int id)
        {
            string query = "select Count(*) as 'Toplam Ürün Sayısı' from Product where EmployeeID=@employeeID AND ProductStatus=0";
            var parameters = new DynamicParameters();
            //parameters: DynamicParameters sınıfı, SQL sorgusuna dinamik parametreler eklemek için kullanılır. Bu, SQL enjeksiyon saldırılarına karşı koruma sağlar.
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, parameters);
                return values;
            }
        }

        public int StatusProductCountByStatusTrue(int id)
        {
            string query = "select Count(*) as 'Toplam Ürün Sayısı' from Product where EmployeeID=@employeeID AND ProductStatus=1";
            var parameters = new DynamicParameters();
            //parameters: DynamicParameters sınıfı, SQL sorgusuna dinamik parametreler eklemek için kullanılır. Bu, SQL enjeksiyon saldırılarına karşı koruma sağlar.
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, parameters);
                return values;
            }
        }
    }
}
