using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRDemo.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRDemo.Controllers
{
    [Route("api/[controller]")]
    public class ChatController : Controller
    {
        private readonly IHubContext<ChatHub> _hubContext;
        public ChatController(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [Route("send")] //path looks like this: https://localhost:44379/api/chat/send
        [HttpPost]
        public IActionResult SendRequest([FromBody] MessageDto messageDto)
        {
             _hubContext.Clients.Group(messageDto.Room).SendAsync("ReceiveMessage", "My Chat Bot", $"{messageDto.msgText}");
            return Ok();
        }
    }
}
