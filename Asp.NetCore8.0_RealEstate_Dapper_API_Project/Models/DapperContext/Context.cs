using Microsoft.Data.SqlClient;
using System.Data;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext
{
    public class Context
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public Context(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("connection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
       
        

    }
}
