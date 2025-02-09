using Microsoft.AspNetCore.SignalR;

namespace SignalR.Hubs
{
	public class ChatHub : Hub
	{
		#region Paramaters as premative data types
		public void SendMessage(string name, string message)
		{
			// save in database

			// send to all online clients
			Clients.All.SendAsync("newMessage", name, message);
		}
		#endregion

		public void joingroup(string groupname, string name)
		{
			// add group
			Groups.AddToGroupAsync(Context.ConnectionId, groupname);

			// send to all online clients (broadcasting)
			Clients.OthersInGroup(groupname).SendAsync("newmember", name, groupname);
			Clients.Caller.SendAsync("member", name, groupname);
		}

		public void leavegroup(string groupname, string name)
		{
			// remove group
			Groups.RemoveFromGroupAsync(Context.ConnectionId, groupname);
			// send to all online clients (broadcasting)
			Clients.OthersInGroup(groupname).SendAsync("leavemember", name, groupname);
		}

		[HubMethodName("sendtogroup")]
		public void sendToGroup(string groupname, string name, string message)
		{
			Clients.Group(groupname).SendAsync("newgroupmessage", name, groupname, message);
		}

		#region Hub events
		public override Task OnConnectedAsync()
		{
			string connectionId = Context.ConnectionId;
			return base.OnConnectedAsync();
		}

		public override Task OnDisconnectedAsync(Exception? exception)
		{
			return base.OnDisconnectedAsync(exception);
		}
		#endregion
	}
}
