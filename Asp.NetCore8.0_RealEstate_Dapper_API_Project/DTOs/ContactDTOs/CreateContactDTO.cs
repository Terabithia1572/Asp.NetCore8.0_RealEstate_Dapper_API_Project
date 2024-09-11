namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ContactDTOs
{
    public class CreateContactDTO
    {
        public string ContactName { get; set; }
        public string ContactSubject { get; set; }
        public string ContactEmail { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactSendDate { get; set; }
    }
}
