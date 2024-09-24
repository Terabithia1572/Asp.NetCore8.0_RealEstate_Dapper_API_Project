using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.MessageDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.MessageRepositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly Context _context;

        public MessageRepository(Context context)
        {
            _context = context;
        }

        public async Task< List<ResultInboxMessageDTO>> GetInboxLast3MessageListByReceiver(int id)
        {
            string query = "select TOP(3) MessageID,Name,MessageSubject,MessageDetail,MessageSendDate,MessageIsRead from Message inner join AppUser on Message.MessageReceiver=AppUser.UserID where MessageReceiver=@messageReceiverID order by MessageID desc\r\n";
            var parameters = new DynamicParameters();
            parameters.Add("@messageReceiverID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultInboxMessageDTO>(query, parameters);
                return values.ToList();
            }

        }
    }
}
