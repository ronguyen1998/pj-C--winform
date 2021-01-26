namespace bai3
{
    partial class Form1
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
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.btnXoSo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.Location = new System.Drawing.Point(64, 74);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(75, 23);
            this.btnTinhToan.TabIndex = 0;
            this.btnTinhToan.Text = "Tính Toán";
            this.btnTinhToan.UseVisualStyleBackColor = true;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // btnXoSo
            // 
            this.btnXoSo.Location = new System.Drawing.Point(270, 74);
            this.btnXoSo.Name = "btnXoSo";
            this.btnXoSo.Size = new System.Drawing.Size(75, 23);
            this.btnXoSo.TabIndex = 0;
            this.btnXoSo.Text = "Xổ Số";
            this.btnXoSo.UseVisualStyleBackColor = true;
            this.btnXoSo.Click += new System.EventHandler(this.btnXoSo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.btnXoSo);
            this.Controls.Add(this.btnTinhToan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.Button btnXoSo;
    }
}

