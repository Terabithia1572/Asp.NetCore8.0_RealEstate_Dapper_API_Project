using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.BottomGridDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ProductDTOs;
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

        public void CreateBottomGrid(CreateBottomGridDTO createBottomGridDTO)
        {
            throw new NotImplementedException();
        }

        public void DeleteBottomGrid(int id)
        {
            throw new NotImplementedException();
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

        public Task<GetBottomGridDTO> GetBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBottomGrid(UpdateBottomGridDTO updateBottomGridDTO)
        {
            throw new NotImplementedException();
        }
    }
}
