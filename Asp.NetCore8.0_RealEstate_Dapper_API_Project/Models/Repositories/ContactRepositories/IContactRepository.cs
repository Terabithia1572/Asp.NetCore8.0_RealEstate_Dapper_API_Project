using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ContactDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ContactRepositories
{
    public interface IContactRepository
    {
        Task<List<ResultContactDTO>> GetAllContactAsync();
        Task<List<Last4ContactResultDTO>> GetLast4Contact();
        void CreateContact(CreateContactDTO createContactDTO);
        void DeleteContact(int id);
        Task<GetByIDContactDTO> GetContact(int id);
    }
}
