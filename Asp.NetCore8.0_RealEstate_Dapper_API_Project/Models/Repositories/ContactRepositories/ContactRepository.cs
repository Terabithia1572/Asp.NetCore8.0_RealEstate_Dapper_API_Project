using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ContactDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ContactRepositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly Context _context;

        public ContactRepository(Context context)
        {
            _context = context;
        }

        public void CreateContact(CreateContactDTO createContactDTO)
        {
            throw new NotImplementedException();
        }

        public void DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultContactDTO>> GetAllContactAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIDContactDTO> GetContact(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Last4ContactResultDTO>> GetLast4Contact()
        {
            string query = "select TOP(4) * from Contact order by ContactID desc\r\n";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Last4ContactResultDTO>(query);
                return values.ToList();
            }
        }
    }
}
