using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.MessageDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.MessageRepositories
{
    public interface IMessageRepository
    {
        Task<List<ResultInboxMessageDTO>> GetInboxLast3MessageListByReceiver(int id);
    }
}
