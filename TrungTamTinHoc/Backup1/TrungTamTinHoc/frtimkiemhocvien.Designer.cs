namespace TrungTamTinHoc
{
    partial class frtimkiemhocvien
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rddat = new System.Windows.Forms.RadioButton();
            this.rdthilai = new System.Windows.Forms.RadioButton();
            this.rdten = new System.Windows.Forms.RadioButton();
            this.rdma = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgtimkiem = new System.Windows.Forms.DataGridView();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtimkiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM THÔNG TIN HỌC VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rddat);
            this.groupBox1.Controls.Add(this.rdthilai);
            this.groupBox1.Controls.Add(this.rdten);
            this.groupBox1.Controls.Add(this.rdma);
            this.groupBox1.Location = new System.Drawing.Point(67, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn cách tìm kiếm";
            // 
            // rddat
            // 
            this.rddat.AutoSize = true;
            this.rddat.Location = new System.Drawing.Point(15, 86);
            this.rddat.Name = "rddat";
            this.rddat.Size = new System.Drawing.Size(190, 17);
            this.rddat.TabIndex = 7;
            this.rddat.TabStop = true;
            this.rddat.Text = "Danh sách học viên đạt chứng chỉ";
            this.rddat.UseVisualStyleBackColor = true;
            this.rddat.CheckedChanged += new System.EventHandler(this.rddat_CheckedChanged);
            // 
            // rdthilai
            // 
            this.rdthilai.AutoSize = true;
            this.rdthilai.Location = new System.Drawing.Point(15, 63);
            this.rdthilai.Name = "rdthilai";
            this.rdthilai.Size = new System.Drawing.Size(148, 17);
            this.rdthilai.TabIndex = 7;
            this.rdthilai.TabStop = true;
            this.rdthilai.Text = "Danh sách học viên thi lại";
            this.rdthilai.UseVisualStyleBackColor = true;
            // 
            // rdten
            // 
            this.rdten.AutoSize = true;
            this.rdten.Location = new System.Drawing.Point(15, 42);
            this.rdten.Name = "rdten";
            this.rdten.Size = new System.Drawing.Size(88, 17);
            this.rdten.TabIndex = 1;
            this.rdten.TabStop = true;
            this.rdten.Text = "Tên học viên";
            this.rdten.UseVisualStyleBackColor = true;
            // 
            // rdma
            // 
            this.rdma.AutoSize = true;
            this.rdma.Location = new System.Drawing.Point(15, 19);
            this.rdma.Name = "rdma";
            this.rdma.Size = new System.Drawing.Size(84, 17);
            this.rdma.TabIndex = 0;
            this.rdma.TabStop = true;
            this.rdma.Text = "Mã học viên";
            this.rdma.UseVisualStyleBackColor = true;
            this.rdma.CheckedChanged += new System.EventHandler(this.rdma_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "TÌM KIẾM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgtimkiem);
            this.groupBox3.Location = new System.Drawing.Point(18, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(632, 173);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả tìm kiếm";
            // 
            // dgtimkiem
            // 
            this.dgtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtimkiem.Location = new System.Drawing.Point(6, 17);
            this.dgtimkiem.Name = "dgtimkiem";
            this.dgtimkiem.Size = new System.Drawing.Size(620, 150);
            this.dgtimkiem.TabIndex = 0;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(6, 21);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(148, 20);
            this.txttimkiem.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(407, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 117);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cần tìm kiếm";
            // 
            // button3
            // 
            this.button3.Image = global::TrungTamTinHoc.Properties.Resources.help;
            this.button3.Location = new System.Drawing.Point(160, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 23);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frtimkiemhocvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frtimkiemhocvien";
            this.Text = "frtimkiemhocvien";
            this.Load += new System.EventHandler(this.frtimkiemhocvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtimkiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdten;
        private System.Windows.Forms.RadioButton rdma;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgtimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rdthilai;
        private System.Windows.Forms.RadioButton rddat;
    }
}