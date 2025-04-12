using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.CategoryDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.EmployeeDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDTO>> GetAllEmployee();
        Task CreateEmployee(CreateEmployeeDTO createEmployeeDTO);
        Task DeleteEmployee(int id);
        Task UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO);
        Task<GetByIDEmployeeDTO> GetEmployee(int id);
    }
}
