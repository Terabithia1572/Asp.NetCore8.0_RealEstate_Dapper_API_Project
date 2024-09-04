using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.CategoryDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.EmployeeDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;

        public EmployeeRepository(Context context)
        {
            _context = context;
        }

        public async void CreateEmployee(CreateEmployeeDTO createEmployeeDTO)
        {
            //Bu kod, bir kategoriyi veritabanına eklemek için kullanılan bir metodu tanımlar. Metodun amacı, verilen kategoriyi veritabanına kaydetmektir. Aşağıda kodun detaylı açıklaması bulunmaktadır:
            {

                string query = "insert into Employee (EmployeeName,EmployeeTitle,EmployeeMail,EmployeePhoneNumber,EmployeeImageURL,EmployeeStatus) values (@employeeName,@employeeTitle,@employeeMail,@employeePhoneNumber,@employeeImageURL,@employeeStatus)";
                var parameters = new DynamicParameters();
                parameters.Add("@employeeName", createEmployeeDTO.EmployeeName);
                parameters.Add("@employeeTitle", createEmployeeDTO.EmployeeTitle);
                parameters.Add("@employeeMail", createEmployeeDTO.EmployeeMail);
                parameters.Add("@employeePhoneNumber", createEmployeeDTO.EmployeePhoneNumber);
                parameters.Add("employeeImageURL", createEmployeeDTO.EmployeeImageURL);
                parameters.Add("@employeeStatus", true);
                using (var connection = _context.CreateConnection())
                {
                    await connection.ExecuteAsync(query, parameters);
                }
            }
        }

        public async void DeleteEmployee(int id)
        {
            string query = "delete from Employee where EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDTO>> GetAllEmployeeAsync()
        {
            string query = "select * from Employee";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDTO>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDEmployeeDTO> GetEmployee(int id)
        {
            string query = "Select * from Employee where EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDEmployeeDTO>(query, parameters);
                return values;
            }
        }

        public async void UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO)
        {
            string query = "update Employee Set EmployeeName=@employeeName,EmployeeTitle=@employeeTitle,EmployeeMail=@employeeMail,EmployeePhoneNumber=@employeePhoneNumber,EmployeeImageURL=@employeeImageURL,EmployeeStatus=@employeeStatus where EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeName", updateEmployeeDTO.EmployeeName);
            parameters.Add("@employeeTitle", updateEmployeeDTO.EmployeeTitle);
            parameters.Add("@employeeMail", updateEmployeeDTO.EmployeeMail);
            parameters.Add("@employeePhoneNumber", updateEmployeeDTO.EmployeePhoneNumber);
            parameters.Add("employeeImageURL", updateEmployeeDTO.EmployeeImageURL);
            parameters.Add("@employeeStatus", true);
            parameters.Add("@employeeID", updateEmployeeDTO.EmployeeID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
