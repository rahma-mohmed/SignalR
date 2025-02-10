namespace Chat_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lst_messages = new ListBox();
			btn_send = new Button();
			txt_name = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			txt_message = new Label();
			txt_group = new Label();
			btn_group = new Button();
			btn_join = new Button();
			SuspendLayout();
			// 
			// lst_messages
			// 
			lst_messages.FormattingEnabled = true;
			lst_messages.Location = new Point(40, 216);
			lst_messages.Name = "lst_messages";
			lst_messages.Size = new Size(709, 204);
			lst_messages.TabIndex = 0;
			// 
			// btn_send
			// 
			btn_send.BackColor = Color.BurlyWood;
			btn_send.Cursor = Cursors.Hand;
			btn_send.FlatStyle = FlatStyle.Popup;
			btn_send.ForeColor = SystemColors.ButtonHighlight;
			btn_send.Location = new Point(291, 70);
			btn_send.Name = "btn_send";
			btn_send.Size = new Size(95, 27);
			btn_send.TabIndex = 1;
			btn_send.Text = "Send";
			btn_send.UseVisualStyleBackColor = false;
			btn_send.Click += btn_send_Click;
			// 
			// txt_name
			// 
			txt_name.AutoSize = true;
			txt_name.BackColor = Color.Transparent;
			txt_name.ForeColor = Color.OrangeRed;
			txt_name.Location = new Point(40, 30);
			txt_name.Name = "txt_name";
			txt_name.Size = new Size(49, 20);
			txt_name.TabIndex = 2;
			txt_name.Text = "Name";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(113, 30);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 27);
			textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(113, 77);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(125, 27);
			textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(113, 129);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(125, 27);
			textBox3.TabIndex = 5;
			// 
			// txt_message
			// 
			txt_message.AutoSize = true;
			txt_message.BackColor = Color.Transparent;
			txt_message.ForeColor = Color.OrangeRed;
			txt_message.Location = new Point(40, 80);
			txt_message.Name = "txt_message";
			txt_message.Size = new Size(67, 20);
			txt_message.TabIndex = 6;
			txt_message.Text = "Message";
			// 
			// txt_group
			// 
			txt_group.AutoSize = true;
			txt_group.BackColor = Color.Transparent;
			txt_group.ForeColor = Color.OrangeRed;
			txt_group.Location = new Point(40, 136);
			txt_group.Name = "txt_group";
			txt_group.Size = new Size(50, 20);
			txt_group.TabIndex = 7;
			txt_group.Text = "Group";
			// 
			// btn_group
			// 
			btn_group.BackColor = Color.BurlyWood;
			btn_group.Cursor = Cursors.Hand;
			btn_group.FlatStyle = FlatStyle.Popup;
			btn_group.ForeColor = SystemColors.ButtonHighlight;
			btn_group.Location = new Point(426, 70);
			btn_group.Name = "btn_group";
			btn_group.Size = new Size(121, 30);
			btn_group.TabIndex = 8;
			btn_group.Text = "Send to group";
			btn_group.UseVisualStyleBackColor = false;
			btn_group.Click += btn_group_Click;
			// 
			// btn_join
			// 
			btn_join.BackColor = Color.BurlyWood;
			btn_join.Cursor = Cursors.Hand;
			btn_join.FlatStyle = FlatStyle.Popup;
			btn_join.ForeColor = SystemColors.ButtonHighlight;
			btn_join.Location = new Point(291, 133);
			btn_join.Name = "btn_join";
			btn_join.Size = new Size(95, 27);
			btn_join.TabIndex = 9;
			btn_join.Text = "Join";
			btn_join.UseVisualStyleBackColor = false;
			btn_join.Click += btn_join_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btn_join);
			Controls.Add(btn_group);
			Controls.Add(txt_group);
			Controls.Add(txt_message);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(txt_name);
			Controls.Add(btn_send);
			Controls.Add(lst_messages);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox lst_messages;
		private Button btn_send;
		private Label txt_name;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private Label txt_message;
		private Label txt_group;
		private Button btn_group;
		private Button btn_join;
	}
}
