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
    public partial class inhvthilai : Form
    {
        public inhvthilai()
        {
            InitializeComponent();
        }
        public string chuoiloc;
        private void crvhvthilai_Load(object sender, EventArgs e)
        {
            //    frbienlai bienlai1 = new frbienlai();//form chứa nút in
            //    ReportDocument crpbl = new rpbienlai();//rp bien lai           
            //    crpbl.RecordSelectionFormula = chuoiloc;
            //    crvbienlai.ReportSource = crpbl;
            //    crpbl.Refresh();
            frrphvthilai diem = new frrphvthilai();
            ReportDocument crpbl = new rphvthilai();
            crpbl.RecordSelectionFormula = chuoiloc;
            crvhvthilai.ReportSource= crpbl;
            crpbl.Refresh();
        }
    }
}