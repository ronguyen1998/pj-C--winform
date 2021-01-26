﻿namespace GhepHinh
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showImageHintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.jpe;*.bmp;*.gif";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(868, 24);
			this.menuStrip1.TabIndex = 0;
			// 
			// FileMenu
			// 
			this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileMenuItem,
            this.toolStripSeparator1,
            this.ExitMenuItem});
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Size = new System.Drawing.Size(63, 20);
			this.FileMenu.Text = "Trò chơi";
			// 
			// OpenFileMenuItem
			// 
			this.OpenFileMenuItem.Name = "OpenFileMenuItem";
			this.OpenFileMenuItem.Size = new System.Drawing.Size(153, 22);
			this.OpenFileMenuItem.Text = "Chọn hình ảnh";
			this.OpenFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
			// 
			// ExitMenuItem
			// 
			this.ExitMenuItem.Name = "ExitMenuItem";
			this.ExitMenuItem.Size = new System.Drawing.Size(153, 22);
			this.ExitMenuItem.Text = "Thoát";
			this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showImageHintToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.optionsToolStripMenuItem.Text = "Tùy chọn";
			// 
			// showImageHintToolStripMenuItem
			// 
			this.showImageHintToolStripMenuItem.Checked = true;
			this.showImageHintToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.showImageHintToolStripMenuItem.Name = "showImageHintToolStripMenuItem";
			this.showImageHintToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.showImageHintToolStripMenuItem.Text = "Hiển thị hình nền gợi ý";
			this.showImageHintToolStripMenuItem.Click += new System.EventHandler(this.showImageHintToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.helpToolStripMenuItem.Text = "Trợ giúp";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "Giới thiệu";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// defaultLookAndFeel1
			// 
			this.defaultLookAndFeel1.LookAndFeel.SkinName = "Springtime";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 566);
			this.Controls.Add(this.menuStrip1);
			this.HtmlText = "<b><color=red>LAPTRINHVB.NET</color></b> - GAME GHÉP HÌNH";
			this.MainMenuStrip = this.menuStrip1;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ClientSizeChanged += new System.EventHandler(this.MainForm_ClientSizeChanged);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showImageHintToolStripMenuItem;
		private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

