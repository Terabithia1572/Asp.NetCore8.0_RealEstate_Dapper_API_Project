namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.MessageDTOs
{
    public class ResultInboxMessageDTO
    {
        public int MessageID { get; set; }
        public int MessageSender { get; set; }
        public int MessageReceiver { get; set; }
        public string MessageSubject { get; set; }
        public string MessageDetail { get; set; }
        public DateTime MessageSendDate { get; set; }
        public bool MessageIsRead { get; set; }
    }
}
