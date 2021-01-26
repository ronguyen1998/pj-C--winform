namespace TrungTamTinHoc
{
    partial class indiem
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
            this.crvdiem = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvdiem
            // 
            this.crvdiem.ActiveViewIndex = -1;
            this.crvdiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvdiem.Location = new System.Drawing.Point(0, 0);
            this.crvdiem.Name = "crvdiem";
            this.crvdiem.SelectionFormula = "";
            this.crvdiem.Size = new System.Drawing.Size(682, 266);
            this.crvdiem.TabIndex = 0;
            this.crvdiem.ViewTimeSelectionFormula = "";
            this.crvdiem.Load += new System.EventHandler(this.crvdiem_Load);
            // 
            // indiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 266);
            this.Controls.Add(this.crvdiem);
            this.Name = "indiem";
            this.Text = "indiem";
            this.Load += new System.EventHandler(this.indiem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvdiem;
    }
}