using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.MessageRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageRepository _messageRepository;

        public MessagesController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetInboxLast3MessageListByReceiver(int id)
        {
            var values =await _messageRepository.GetInboxLast3MessageListByReceiver(id);
            return Ok(values);
        }
    }
}
