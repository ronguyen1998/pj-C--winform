namespace TrungTamTinHoc
{
    partial class inhvthilai
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
            this.crvhvthilai = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvhvthilai
            // 
            this.crvhvthilai.ActiveViewIndex = -1;
            this.crvhvthilai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvhvthilai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvhvthilai.Location = new System.Drawing.Point(0, 0);
            this.crvhvthilai.Name = "crvhvthilai";
            this.crvhvthilai.SelectionFormula = "";
            this.crvhvthilai.Size = new System.Drawing.Size(292, 266);
            this.crvhvthilai.TabIndex = 0;
            this.crvhvthilai.ViewTimeSelectionFormula = "";
            this.crvhvthilai.Load += new System.EventHandler(this.crvhvthilai_Load);
            // 
            // inhvthilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.crvhvthilai);
            this.Name = "inhvthilai";
            this.Text = "inhvthilai";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvhvthilai;
    }
}