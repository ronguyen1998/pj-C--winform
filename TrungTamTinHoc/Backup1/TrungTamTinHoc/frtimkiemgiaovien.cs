using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrungTamTinHoc
{
    public partial class frtimkiemgiaovien : Form
    {
        public frtimkiemgiaovien()
        {
            InitializeComponent();
        }
        DataTable giaovien = new DataTable();
        Classqlttth obj = new Classqlttth();
        private void frtimkiemgiaovien_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "giaovien";
            if (rdma.Checked == true)
            {
                string ma = "magv";
                bool kt;
                kt = obj.timkiemgv(str, ma, txttimkiem.Text);
                if (kt == false)
                {
                    MessageBox.Show("Dữ liệu bạn cần không tìm thấy !");
                    return;
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = obj.gettimkiem(str, ma, txttimkiem.Text);
                    dgtimkiem.DataSource = ds.Tables[0];
                }
            }
            else
            {
                if (rdten.Checked == true)
                {
                    string ma = "hoten";
                    bool kt;
                    kt = obj.timkiemgv(str, ma, txttimkiem.Text);
                    if (kt == false)
                    {
                        MessageBox.Show("Dữ liệu bạn cần không tìm thấy !");
                        return;
                    }
                    else
                    {
                        DataSet ds = new DataSet();
                        ds = obj.gettimkiem(str, ma, txttimkiem.Text);
                        dgtimkiem.DataSource = ds.Tables[0];
                    }
                }

                else
                {
                    MessageBox.Show("Hay chon cach tim kiem");
                }
            }
        }

        private void rdma_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Text = "";
        }

        private void rdten_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}