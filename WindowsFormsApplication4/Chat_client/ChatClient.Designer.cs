namespace Chat_client
{
    partial class ChatClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbClient1 = new System.Windows.Forms.RichTextBox();
            this.rtbClient2 = new System.Windows.Forms.RichTextBox();
            this.btnSendClient = new System.Windows.Forms.Button();
            this.btnConnectClient = new System.Windows.Forms.Button();
            this.btnReciveClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbClient1
            // 
            this.rtbClient1.Location = new System.Drawing.Point(5, 20);
            this.rtbClient1.Name = "rtbClient1";
            this.rtbClient1.Size = new System.Drawing.Size(560, 178);
            this.rtbClient1.TabIndex = 0;
            this.rtbClient1.Text = "";
            this.rtbClient1.TextChanged += new System.EventHandler(this.rtbClient1_TextChanged);
            // 
            // rtbClient2
            // 
            this.rtbClient2.Location = new System.Drawing.Point(5, 203);
            this.rtbClient2.Name = "rtbClient2";
            this.rtbClient2.Size = new System.Drawing.Size(567, 118);
            this.rtbClient2.TabIndex = 1;
            this.rtbClient2.Text = "";
            this.rtbClient2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // btnSendClient
            // 
            this.btnSendClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnSendClient.Location = new System.Drawing.Point(419, 347);
            this.btnSendClient.Name = "btnSendClient";
            this.btnSendClient.Size = new System.Drawing.Size(75, 32);
            this.btnSendClient.TabIndex = 2;
            this.btnSendClient.Text = "Send";
            this.btnSendClient.UseVisualStyleBackColor = true;
            this.btnSendClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConnectClient
            // 
            this.btnConnectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnConnectClient.Location = new System.Drawing.Point(214, 356);
            this.btnConnectClient.Name = "btnConnectClient";
            this.btnConnectClient.Size = new System.Drawing.Size(75, 23);
            this.btnConnectClient.TabIndex = 4;
            this.btnConnectClient.Text = "Connect";
            this.btnConnectClient.UseVisualStyleBackColor = true;
            this.btnConnectClient.Click += new System.EventHandler(this.Connect_Click);
            // 
            // btnReciveClient
            // 
            this.btnReciveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnReciveClient.Location = new System.Drawing.Point(31, 356);
            this.btnReciveClient.Name = "btnReciveClient";
            this.btnReciveClient.Size = new System.Drawing.Size(75, 23);
            this.btnReciveClient.TabIndex = 5;
            this.btnReciveClient.Text = "Recive";
            this.btnReciveClient.UseVisualStyleBackColor = true;
            this.btnReciveClient.Click += new System.EventHandler(this.btnReciveClient_Click);
            // 
            // ChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.btnReciveClient);
            this.Controls.Add(this.btnConnectClient);
            this.Controls.Add(this.btnSendClient);
            this.Controls.Add(this.rtbClient2);
            this.Controls.Add(this.rtbClient1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Location = new System.Drawing.Point(600, 200);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChatClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Chat_Client";
            this.Load += new System.EventHandler(this.ChatClient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbClient1;
        private System.Windows.Forms.RichTextBox rtbClient2;
        private System.Windows.Forms.Button btnSendClient;
        private System.Windows.Forms.Button btnConnectClient;
        private System.Windows.Forms.Button btnReciveClient;
    }
}

