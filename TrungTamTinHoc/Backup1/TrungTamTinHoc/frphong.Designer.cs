namespace TrungTamTinHoc
{
    partial class frphong
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmap = new System.Windows.Forms.TextBox();
            this.txttenp = new System.Windows.Forms.TextBox();
            this.txtddp = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgphong = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btnhapmoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgphong)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT PHÒNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtddp);
            this.groupBox1.Controls.Add(this.txttenp);
            this.groupBox1.Controls.Add(this.txtmap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đặc diểm";
            // 
            // txtmap
            // 
            this.txtmap.Location = new System.Drawing.Point(67, 17);
            this.txtmap.Name = "txtmap";
            this.txtmap.Size = new System.Drawing.Size(100, 20);
            this.txtmap.TabIndex = 3;
            // 
            // txttenp
            // 
            this.txttenp.Location = new System.Drawing.Point(256, 17);
            this.txttenp.Name = "txttenp";
            this.txttenp.Size = new System.Drawing.Size(100, 20);
            this.txttenp.TabIndex = 4;
            // 
            // txtddp
            // 
            this.txtddp.Location = new System.Drawing.Point(434, 17);
            this.txtddp.Name = "txtddp";
            this.txtddp.Size = new System.Drawing.Size(100, 20);
            this.txtddp.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgphong);
            this.groupBox3.Location = new System.Drawing.Point(12, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 176);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // dgphong
            // 
            this.dgphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgphong.Location = new System.Drawing.Point(8, 19);
            this.dgphong.Name = "dgphong";
            this.dgphong.Size = new System.Drawing.Size(561, 150);
            this.dgphong.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.btsua);
            this.groupBox4.Controls.Add(this.btluu);
            this.groupBox4.Controls.Add(this.btnhapmoi);
            this.groupBox4.Location = new System.Drawing.Point(151, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 31);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(240, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 23);
            this.button9.TabIndex = 4;
            this.button9.Text = "Thoát";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(159, 6);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(91, 7);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(62, 23);
            this.btluu.TabIndex = 1;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btnhapmoi
            // 
            this.btnhapmoi.Location = new System.Drawing.Point(19, 6);
            this.btnhapmoi.Name = "btnhapmoi";
            this.btnhapmoi.Size = new System.Drawing.Size(66, 23);
            this.btnhapmoi.TabIndex = 0;
            this.btnhapmoi.Text = "Nhập mới";
            this.btnhapmoi.UseVisualStyleBackColor = true;
            this.btnhapmoi.Click += new System.EventHandler(this.btnhapmoi_Click);
            // 
            // frphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 353);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frphong";
            this.Text = "frphong";
            this.Load += new System.EventHandler(this.frphong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgphong)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtddp;
        private System.Windows.Forms.TextBox txttenp;
        private System.Windows.Forms.TextBox txtmap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgphong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btnhapmoi;
    }
}