using Microsoft.AspNetCore.SignalR.Client;

namespace Chat_app
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		HubConnection con;
		private void Form1_Load(object sender, EventArgs e)
		{
			// define connection
			con = new HubConnectionBuilder()
				.WithUrl("https://localhost:44377/chatHub")
				.Build();

			// start connection
			con.StartAsync();

			// define callback for receiving messages
			con.On<string, string>("newMessage", (user, message) =>
			{
				// single thread can access the UI elements so we need to invoke a delegate to access the UI elements
				// server can't modify the UI elements directly

				lst_messages.Invoke(new Action(() =>
				{
					lst_messages.Items.Add($"{user} : {message}");
				}));
			});

			con.On<string, string>("newmember", (name, groupname) =>
			{
				lst_messages.Invoke(new Action(() =>
				{
					lst_messages.Items.Add($"{name} joined the group {groupname}");
				}));
			});

			con.On<string, string, string>("newgroupmessage", (name, groupname, message) =>
			{
				lst_messages.Invoke(new Action(() =>
				{
					lst_messages.Items.Add($"{name} : {message} (Group {groupname})");
				}));
			});
		}

		private void btn_send_Click(object sender, EventArgs e)
		{
			con.InvokeAsync("SendMessage", textBox1.Text, textBox2.Text);
		}

		private void btn_join_Click(object sender, EventArgs e)
		{
			con.InvokeAsync("joingroup", textBox3.Text, textBox1.Text);
		}

		private void btn_group_Click(object sender, EventArgs e)
		{
			con.InvokeAsync("sendtogroup", textBox3.Text, textBox1.Text, textBox2.Text);
		}
	}
}
