namespace TrungTamTinHoc
{
    partial class frrpdiem1hv
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
            this.crvdiem1hv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvdiem1hv
            // 
            this.crvdiem1hv.ActiveViewIndex = -1;
            this.crvdiem1hv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvdiem1hv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvdiem1hv.Location = new System.Drawing.Point(0, 0);
            this.crvdiem1hv.Name = "crvdiem1hv";
            this.crvdiem1hv.SelectionFormula = "";
            this.crvdiem1hv.Size = new System.Drawing.Size(284, 264);
            this.crvdiem1hv.TabIndex = 0;
            this.crvdiem1hv.ViewTimeSelectionFormula = "";
            this.crvdiem1hv.Load += new System.EventHandler(this.crvdiem1hv_Load);
            // 
            // frrpdiem1hv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.crvdiem1hv);
            this.Name = "frrpdiem1hv";
            this.Text = "frrpdiem1hv";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvdiem1hv;
    }
}