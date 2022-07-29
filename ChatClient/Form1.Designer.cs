namespace ChatClient
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
            this.tbChat = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.tbUserMsg = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(12, 89);
            this.tbChat.Multiline = true;
            this.tbChat.ScrollBars = ScrollBars.Vertical;
            this.tbChat.WordWrap = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(776, 272);
            this.tbChat.TabIndex = 0;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(562, 12);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(226, 31);
            this.tbUsername.TabIndex = 1;
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(609, 49);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(179, 34);
            this.bConnect.TabIndex = 2;
            this.bConnect.Text = "Connect To Server";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // tbUserMsg
            // 
            this.tbUserMsg.Location = new System.Drawing.Point(12, 367);
            this.tbUserMsg.Name = "tbUserMsg";
            this.tbUserMsg.Size = new System.Drawing.Size(776, 31);
            this.tbUserMsg.TabIndex = 3;
            this.tbUserMsg.TextChanged += new System.EventHandler(this.tbUserMsg_TextChanged);
            this.tbUserMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserMsg_KeyDown);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(676, 404);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(112, 34);
            this.bSend.TabIndex = 4;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbUserMsg);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbChat);
            this.Name = "Form1";
            this.Text = "Chat Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbChat;
        private TextBox tbUsername;
        private Button bConnect;
        private TextBox tbUserMsg;
        private Button bSend;
        private Label label1;
    }
}