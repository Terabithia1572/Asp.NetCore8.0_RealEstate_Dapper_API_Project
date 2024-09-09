using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.BottomGridDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.BottomGridRepository;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.BottomGridRepositories
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public async void CreateBottomGrid(CreateBottomGridDTO createBottomGridDTO)
        {
            string query = "insert into BottomGrid (BottomGridIcon,BottomGridTitle,BottomGridDescription) values (@bottomGridIcon,@bottomGridTitle,@bottomGridDescription)";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridIcon", createBottomGridDTO.BottomGridIcon);
            parameters.Add("@bottomGridTitle", createBottomGridDTO.BottomGridTitle);
            parameters.Add("@bottomGridDescription", createBottomGridDTO.BottomGridDescription);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteBottomGrid(int id)
        {
            string query = "delete from BottomGrid where BottomGridID=@BottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@BottomGridID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultBottomGridDTO>> GetAllBottomGridAsync()
        {
            string query = "select * from BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDTO>(query);
                return values.ToList();
            }
        }

        public async Task<GetBottomGridDTO> GetBottomGrid(int id)
        {
            string query = "Select * from BottomGrid where BottomGridID=@BottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@BottomGridID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetBottomGridDTO>(query, parameters);
                return values;
            }
        }

        public async void UpdateBottomGrid(UpdateBottomGridDTO updateBottomGridDTO)
        {
            string query = "update BottomGrid Set BottomGridIcon=@bottomGridIcon,BottomGridTitle=@bottomGridTitle,BottomGridDescription=@bottomGridDescription where BottomGridID=@BottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridIcon", updateBottomGridDTO.BottomGridIcon);
            parameters.Add("@bottomGridTitle", updateBottomGridDTO.BottomGridTitle);
            parameters.Add("@bottomGridDescription", updateBottomGridDTO.BottomGridDescription);
            parameters.Add("@BottomGridID", updateBottomGridDTO.BottomGridID);
            using (var connections = _context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
        }
    }
}
