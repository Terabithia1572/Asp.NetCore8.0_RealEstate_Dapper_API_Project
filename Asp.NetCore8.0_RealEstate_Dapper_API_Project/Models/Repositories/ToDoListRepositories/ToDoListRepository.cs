

using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ToDoListDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ToDoListRepositories
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly Context _context;

        public ToDoListRepository(Context context)
        {
            _context = context;
        }

        public Task CreateToDoList(CreateToDoListDTO createToDoListDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultToDoListDTO>> GetAllToDoList()
        {
            string query = "select * from ToDoList";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultToDoListDTO>(query);
                return values.ToList();
            }
        }

        public Task<GetByIDToDoListDTO> GetToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateToDoList(UpdateToDoListDTO updateToDoListDTO)
        {
            throw new NotImplementedException();
        }
    }
}
