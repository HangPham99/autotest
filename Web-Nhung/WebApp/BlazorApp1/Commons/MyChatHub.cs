using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Commons
{

    public class ChatHub : Hub
    {
        static IHubCallerClients sClients;
        public static Dictionary<string, string> ChatUser = new Dictionary<string, string>();
       
        public async Task SendMessage(string message)
        { 
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
        public async Task Subribe(string userid)
        {
            sClients = Clients;
            ChatUser[userid] = Context.ConnectionId;
            await Clients.Client(ChatUser[userid]).SendAsync("ReceiveMessage", "Connect Thành Công");
        }
        public async override Task OnDisconnectedAsync(Exception exception)
        {
            var item = ChatUser.First(kvp => kvp.Value == Context.ConnectionId);
            ChatUser.Remove(item.Key);
            await base.OnDisconnectedAsync(exception);
        }
        public static async void SendMessangeToUser(string userid,string message)
        {
            await sClients.Client(ChatUser[userid]).SendAsync("ReceiveMessage", message);
        }
    }
}
