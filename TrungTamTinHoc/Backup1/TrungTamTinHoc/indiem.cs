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
    public partial class indiem : Form
    {
        public indiem()
        {
            InitializeComponent();
        }
        public string chuoiloc;
        private void crvdiem_Load(object sender, EventArgs e)
        {
        //    frbienlai bienlai1 = new frbienlai();//form chứa nút in
        //    ReportDocument crpbl = new rpbienlai();//rp bien lai           
        //    crpbl.RecordSelectionFormula = chuoiloc;
        //    crvbienlai.ReportSource = crpbl;
        //    crpbl.Refresh();
            frindiemlop diem = new frindiemlop();
            ReportDocument crpbl = new rpdiem1lop();
            crpbl.RecordSelectionFormula = chuoiloc;
           crvdiem.ReportSource = crpbl;
            crpbl.Refresh();
        }

        private void indiem_Load(object sender, EventArgs e)
        {

        }
    }
}