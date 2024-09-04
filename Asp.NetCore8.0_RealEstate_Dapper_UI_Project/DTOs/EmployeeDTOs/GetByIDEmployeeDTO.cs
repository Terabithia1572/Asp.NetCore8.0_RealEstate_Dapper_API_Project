namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.EmployeeDTOs
{
    public class GetByIDEmployeeDTO
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeTitle { get; set; }
        public string EmployeeMail { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeeImageURL { get; set; }
        public bool EmployeeStatus { get; set; }
    }
}
