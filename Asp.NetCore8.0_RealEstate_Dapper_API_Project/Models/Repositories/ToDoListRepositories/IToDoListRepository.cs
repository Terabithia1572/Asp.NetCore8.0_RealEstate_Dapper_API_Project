using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ToDoListDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ToDoListRepositories
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDTO>> GetAllToDoList();
        Task CreateToDoList(CreateToDoListDTO createToDoListDTO);
        Task DeleteToDoList(int id);
        Task UpdateToDoList(UpdateToDoListDTO updateToDoListDTO);
        Task<GetByIDToDoListDTO> GetToDoList(int id);
    }
}
