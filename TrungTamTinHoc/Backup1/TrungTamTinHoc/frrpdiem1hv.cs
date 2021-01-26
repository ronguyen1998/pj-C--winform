using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
namespace TrungTamTinHoc
{
    public partial class frrpdiem1hv : Form
    {
        public frrpdiem1hv()
        {
            InitializeComponent();
        }
        public string chuoiloc;
        private void crvdiem1hv_Load(object sender, EventArgs e)
        {
            frtkdiem hv = new frtkdiem();
            ReportDocument crpbl = new rpdiem1hv();
            crpbl.RecordSelectionFormula = chuoiloc;
           crvdiem1hv.ReportSource = crpbl;
            crpbl.Refresh();
        }
    }
}