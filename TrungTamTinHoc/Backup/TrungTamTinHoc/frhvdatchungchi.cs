using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrungTamTinHoc
{
    public partial class frhvdatchungchi : Form
    {
        public frhvdatchungchi()
        {
            InitializeComponent();
        }
        DataTable hocvien = new DataTable();
        Classqlttth obj = new Classqlttth();
        private void button1_Click(object sender, EventArgs e)
        {
            if (rddat.Checked == true)
            {
                //txttimkiem.Text = "";

                bool kt;
                kt = obj.hvdat();
                if (kt == false)
                {
                    MessageBox.Show("Dữ liệu bạn cần không tìm thấy !");
                    return;
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = obj.gettimkiemhvdat();
                    dgtimkiem.DataSource = ds.Tables[0];
                }
            }
            //====
            if (rddalay.Checked == true)
            {
                //txttimkiem.Text = "";

                bool kt;
                kt = obj.hvdalay();
                if (kt == false)
                {
                    MessageBox.Show("Dữ liệu bạn cần không tìm thấy !");
                    return;
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = obj.gettimkiemhvdalay();
                    dgtimkiem.DataSource = ds.Tables[0];
                }
            }
            //====
            if (rdchualay.Checked == true)
            {
                //txttimkiem.Text = "";

                bool kt;
                kt = obj.hvclay();
                if (kt == false)
                {
                    MessageBox.Show("Dữ liệu bạn cần không tìm thấy !");
                    return;
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = obj.gettimkiemhvchualay();
                    dgtimkiem.DataSource = ds.Tables[0];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}