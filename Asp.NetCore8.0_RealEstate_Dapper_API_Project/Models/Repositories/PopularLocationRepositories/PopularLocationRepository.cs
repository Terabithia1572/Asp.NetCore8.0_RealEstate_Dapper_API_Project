using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.BottomGridDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.PopularLocationDTO;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ServiceDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.PopularLocationRepositories
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public async void CreatePopularLocation(CreatePopularLocationDTO createPopularLocationDTO)
        {
            string query = "insert into PopularLocation (PopularLocationCityName,PopularLocationImageURL) values (@popularLocationCityName,@popularLocationImageURL)";
            var parameters = new DynamicParameters();
            parameters.Add("@popularLocationCityName", createPopularLocationDTO.PopularLocationCityName);
            parameters.Add("@popularLocationImageURL", createPopularLocationDTO.PopularLocationImageURL);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeletePopularLocation(int id)
        {

            string query = "delete from PopularLocation where PopularLocationID=@popularLocationID";
            var parameters = new DynamicParameters();
            parameters.Add("@popularLocationID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultPopularLocationDTO>> GetAllPopularLocationAsync()
        {
            string query = "select * from PopularLocation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDTO>(query);
                return values.ToList();
            }

        }

        public async Task<GetByIDPopularLocationDTO> GetPopularLocation(int id)
        {
            string query = "Select * from PopularLocation where PopularLocationID=@popularLocationID";
            var parameters = new DynamicParameters();
            parameters.Add("@PopularLocationID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDPopularLocationDTO>(query, parameters);
                return values;
            }
        }

        public async void UpdatePopularLocation(UpdatePopularLocationDTO updatePopularLocationDTO)
        {
            string query = "update PopularLocation Set PopularLocationCityName=@popularLocationCityName,PopularLocationImageURL=@popularLocationImageURL where PopularLocationID=@popularLocationID";
            var parameters = new DynamicParameters();
            parameters.Add("@popularLocationCityName", updatePopularLocationDTO.PopularLocationCityName);
            parameters.Add("@popularLocationImageURL", updatePopularLocationDTO.PopularLocationImageURL);
            parameters.Add("@popularLocationID", updatePopularLocationDTO.PopularLocationID);
            using (var connections = _context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
        }
    }
}
