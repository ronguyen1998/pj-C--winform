namespace TrungTamTinHoc
{
    partial class frhvdatchungchi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rddat = new System.Windows.Forms.RadioButton();
            this.rdchualay = new System.Windows.Forms.RadioButton();
            this.rddalay = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgtimkiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rddat);
            this.groupBox1.Controls.Add(this.rdchualay);
            this.groupBox1.Controls.Add(this.rddalay);
            this.groupBox1.Location = new System.Drawing.Point(259, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn cách tìm kiếm";
            // 
            // rddat
            // 
            this.rddat.AutoSize = true;
            this.rddat.Checked = true;
            this.rddat.Location = new System.Drawing.Point(15, 19);
            this.rddat.Name = "rddat";
            this.rddat.Size = new System.Drawing.Size(190, 17);
            this.rddat.TabIndex = 7;
            this.rddat.TabStop = true;
            this.rddat.Text = "Danh sách học viên đạt chứng chỉ";
            this.rddat.UseVisualStyleBackColor = true;
            // 
            // rdchualay
            // 
            this.rdchualay.AutoSize = true;
            this.rdchualay.Location = new System.Drawing.Point(15, 63);
            this.rdchualay.Name = "rdchualay";
            this.rdchualay.Size = new System.Drawing.Size(214, 17);
            this.rdchualay.TabIndex = 7;
            this.rdchualay.Text = "Danh sách học viên chưa lấy chứng chỉ";
            this.rdchualay.UseVisualStyleBackColor = true;
            // 
            // rddalay
            // 
            this.rddalay.AutoSize = true;
            this.rddalay.Location = new System.Drawing.Point(15, 42);
            this.rddalay.Name = "rddalay";
            this.rddalay.Size = new System.Drawing.Size(203, 17);
            this.rddalay.TabIndex = 1;
            this.rddalay.Text = "Danh sách học viên đã lấy chứng chỉ";
            this.rddalay.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(593, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(593, 69);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(75, 23);
            this.txttimkiem.TabIndex = 3;
            this.txttimkiem.Text = "TÌM KIẾM";
            this.txttimkiem.UseVisualStyleBackColor = true;
            this.txttimkiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgtimkiem);
            this.groupBox3.Location = new System.Drawing.Point(12, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(907, 173);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả tìm kiếm";
            // 
            // dgtimkiem
            // 
            this.dgtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtimkiem.Location = new System.Drawing.Point(6, 17);
            this.dgtimkiem.Name = "dgtimkiem";
            this.dgtimkiem.Size = new System.Drawing.Size(895, 150);
            this.dgtimkiem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ CHỨNG CHỈ";
            // 
            // frhvdatchungchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frhvdatchungchi";
            this.Text = "frhvdatchungchi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rddat;
        private System.Windows.Forms.RadioButton rdchualay;
        private System.Windows.Forms.RadioButton rddalay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txttimkiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgtimkiem;
        private System.Windows.Forms.Label label1;
    }
}