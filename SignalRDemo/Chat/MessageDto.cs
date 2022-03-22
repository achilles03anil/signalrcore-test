using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRDemo.Chat
{
    public class MessageDto
    {
        public string Room { get; set; }
        public string msgText { get; set; }
    }
}
