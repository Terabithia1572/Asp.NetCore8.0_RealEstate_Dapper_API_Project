using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ToDoListDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ToDoListRepositories
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDTO>> GetAllToDoListAsync();
        void CreateToDoList(CreateToDoListDTO createToDoListDTO);
        void DeleteToDoList(int id);
        void UpdateToDoList(UpdateToDoListDTO updateToDoListDTO);
        Task<GetByIDToDoListDTO> GetToDoList(int id);
    }
}
