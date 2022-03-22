using Microsoft.AspNetCore.SignalR;
using SignalRDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRDemo.Chat
{
    public class ChatHub : Hub
    {
        //private readonly string _botUser;
        //private readonly IDictionary<string, UserConnection> _connections;
        //public ChatHub(IDictionary<string, UserConnection> connections)
        //{
        //    _botUser = "MyChat Bot";
        //    _connections = connections;
        //}

        //public override Task OnDisconnectedAsync(Exception exception)
        //{
        //    if (_connections.TryGetValue(Context.ConnectionId, out UserConnection userConnection))
        //    {
        //        _connections.Remove(Context.ConnectionId);
        //        Clients.Group(userConnection.Room).SendAsync("ReceiveMessage", _botUser, $"{userConnection.User} has left");
        //        SendUsersConnected(userConnection.Room);
        //    }

        //    return base.OnDisconnectedAsync(exception);
        //}


        public async Task JoinRoom(UserConnection userConnection)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, userConnection.Room);
            //_connections[Context.ConnectionId] = userConnection;
        }
        //public async Task SendMessage(string message)
        //{
        //    if (_connections.TryGetValue(Context.ConnectionId, out UserConnection userConnection))
        //    {
        //        await Clients.Group(userConnection.Room).SendAsync("ReceiveMessage", userConnection.User, message);
        //    }
        //}

        //public Task SendUsersConnected(string room)
        //{
        //    var users = _connections.Values
        //        .Where(c => c.Room == room)
        //        .Select(c => c.User);

        //    return Clients.Group(room).SendAsync("UsersInRoom", users);
        //}


        ////public Task SendMessage(string user, string message)               // Two parameters accepted
        ////{
        ////    return Clients.All.SendAsync("ReceiveOne", user, message);    // Note this 'ReceiveOne' 
        ////}
        //public void SendPrivateMessage(string toUserId, string message)
        //{
        //    string fromUserId = Context.ConnectionId;
        //    if (toUserId != null && fromUserId != null)
        //    {
        //        // send to 
        //        Clients.Client(toUserId).SendAsync(fromUserId, message);

        //        // send to caller user

        //        Clients.Caller.SendAsync(toUserId, message);

        //    }

        //}

        //public async Task SendMessage(MessageDto messageDto)
        //{
        //    await Clients.Group(messageDto.Room).SendAsync("ReceiveMessage", _botUser, $"{messageDto.msgText}");
        //}
    }
}
