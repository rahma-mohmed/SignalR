using Microsoft.AspNetCore.SignalR;

namespace SignalR.Hubs
{
	public class ChatHub : Hub
	{
		public void SendMessage(string name, string message)
		{
			// save in database

			// send to all online clients
			Clients.All.SendAsync("newMessage", name, message);
		}
	}
}
