namespace Chat_Sever
{
    partial class ChatSever
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
            this.btnStartSever = new System.Windows.Forms.Button();
            this.btnSendSever = new System.Windows.Forms.Button();
            this.rtbSever2 = new System.Windows.Forms.RichTextBox();
            this.rtbSever1 = new System.Windows.Forms.RichTextBox();
            this.btnReciveSever = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartSever
            // 
            this.btnStartSever.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnStartSever.Location = new System.Drawing.Point(236, 355);
            this.btnStartSever.Name = "btnStartSever";
            this.btnStartSever.Size = new System.Drawing.Size(78, 23);
            this.btnStartSever.TabIndex = 7;
            this.btnStartSever.Text = "Start";
            this.btnStartSever.UseVisualStyleBackColor = true;
            this.btnStartSever.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSendSever
            // 
            this.btnSendSever.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnSendSever.Location = new System.Drawing.Point(416, 355);
            this.btnSendSever.Name = "btnSendSever";
            this.btnSendSever.Size = new System.Drawing.Size(75, 23);
            this.btnSendSever.TabIndex = 6;
            this.btnSendSever.Text = "Send";
            this.btnSendSever.UseVisualStyleBackColor = true;
            this.btnSendSever.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbSever2
            // 
            this.rtbSever2.Location = new System.Drawing.Point(12, 218);
            this.rtbSever2.Name = "rtbSever2";
            this.rtbSever2.Size = new System.Drawing.Size(560, 108);
            this.rtbSever2.TabIndex = 5;
            this.rtbSever2.Text = "";
            this.rtbSever2.TextChanged += new System.EventHandler(this.rtbSever2_TextChanged);
            // 
            // rtbSever1
            // 
            this.rtbSever1.Location = new System.Drawing.Point(12, 34);
            this.rtbSever1.Name = "rtbSever1";
            this.rtbSever1.Size = new System.Drawing.Size(560, 178);
            this.rtbSever1.TabIndex = 4;
            this.rtbSever1.Text = "";
            this.rtbSever1.TextChanged += new System.EventHandler(this.rtbSever1_TextChanged);
            // 
            // btnReciveSever
            // 
            this.btnReciveSever.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnReciveSever.Location = new System.Drawing.Point(85, 356);
            this.btnReciveSever.Name = "btnReciveSever";
            this.btnReciveSever.Size = new System.Drawing.Size(75, 23);
            this.btnReciveSever.TabIndex = 8;
            this.btnReciveSever.Text = "Recive";
            this.btnReciveSever.UseVisualStyleBackColor = true;
            this.btnReciveSever.Click += new System.EventHandler(this.btnRecive_Click);
            // 
            // ChatSever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.btnReciveSever);
            this.Controls.Add(this.btnStartSever);
            this.Controls.Add(this.btnSendSever);
            this.Controls.Add(this.rtbSever2);
            this.Controls.Add(this.rtbSever1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Location = new System.Drawing.Point(15, 25);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChatSever";
            this.Text = "Chat_Sever";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartSever;
        private System.Windows.Forms.Button btnSendSever;
        private System.Windows.Forms.RichTextBox rtbSever2;
        private System.Windows.Forms.RichTextBox rtbSever1;
        private System.Windows.Forms.Button btnReciveSever;
    }
}

