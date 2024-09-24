namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.MessageDTOs
{
    public class ResultInboxMessageDTO
    {
        public int MessageID { get; set; }
        public string Name { get; set; }
        public string MessageSubject { get; set; }
        public string MessageDetail { get; set; }
        public DateTime MessageSendDate { get; set; }
        public bool MessageIsRead { get; set; }
        public string UserImageURL { get; set; }
    }
}
