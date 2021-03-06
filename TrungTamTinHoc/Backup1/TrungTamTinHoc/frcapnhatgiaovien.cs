using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrungTamTinHoc
{
    public partial class frcapnhatgiaovien : Form
    {
        public frcapnhatgiaovien()
        {
            InitializeComponent();
        }
        Classqlttth obj = new Classqlttth();
        int vitri = 0;
        DataTable mtblgv = new DataTable();
        //======//

        void clearall()
        {
            txtmagv.Clear();
            txthtgv.Clear();
            txtdcgv.Clear();
            txtdtgv.Clear();
            txttdgv.Clear();
            txtmagv.Focus();
            
        }
        //====//
        private void GanDuLieuTuRowVaoText(DataTable tbl, int vitri)
        {
            DataRow drw;
            drw = tbl.Rows[vitri];
            txtmagv.Text = drw["magv"].ToString();
           txthtgv.Text = drw["hoten"].ToString();
           dateTimePicker1.Text = drw["namsinh"].ToString();
           if ((Boolean)drw["gioitinh"])
               rdnam.Checked = true;
           else
               rdnu.Checked = true;
           txtdcgv.Text = drw["diachi"].ToString();
           //txtgtgv.Text = drw["gioitinh"].ToString();
           txtdtgv.Text = drw["dienthoai"].ToString();
           txttdgv.Text = drw["trinhdo"].ToString();

        }
        //===//
      
        private void btnhapmoi_Click(object sender, EventArgs e)
        {

            clearall();


            if (btnhapmoi.Text == "Nhập mới")
            {

                btnhapmoi.Text = "Huỷ Nhập";
                btsua.Enabled = false;
               
                btluu.Enabled = true;
            }
            else
            {

                btluu.Enabled = false;
                btnhapmoi.Text = "Nhập mới";
                btsua.Enabled = true;
               

            }               
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void frcapnhatgiaovien_Load(object sender, EventArgs e)
        {
           
            mtblgv = obj.getDataTable("giaovien");
            GanDuLieuTuRowVaoText(mtblgv, vitri);
            DataSet ds = new DataSet();
            ds = obj.getDataSet("giaovien");
            dgrgiaovien.DataSource = ds.Tables[0];
            btluu.Enabled = false;
            clearall();
        }
        //====kiem tra du lieu hop le====//
        public bool kiemtradulieugiaovien()
        {
            if(txtmagv.Text == "" || txthtgv.Text == "" || txtdcgv.Text == "" || txtdtgv.Text == "" || txttdgv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return false;
            }
            else
            {
                if (obj.kiemtatrungkhoagiaovien(txtmagv.Text))
                {
                    MessageBox.Show(" Mã học viên này đã tồn tại !");
                    return false;
                }
                return true;
            }
        }
        private void btluu_Click(object sender, EventArgs e)
        {
            if (btsua.Enabled == false)
            {

                bool kt;
                //=====================
                if (kiemtradulieugiaovien() == false)
                {

                    return;
                }
                else
                {
                    string _magv,_htgv,_nsgv,_dcgv,_dtgv,_tdgv;
                    int _gtgv;
                    _magv = txtmagv.Text;
                    _htgv = txthtgv.Text;
                    _dcgv = txtdcgv.Text;
                    _dtgv = txtdtgv.Text;
                    _tdgv = txttdgv.Text;
                    if (rdnam.Checked)
                        _gtgv = 1;
                    else
                        _gtgv = 0;
                    _nsgv = dateTimePicker1.Value.ToShortDateString();

                    kt = obj.luugiaovien( _magv,  _htgv,  _nsgv,  _dcgv, _dtgv, _tdgv, _gtgv);
                    if (kt == false)
                    {
                        MessageBox.Show("Ban Chua Them Duoc!");
                        return;
                    }
                    else
                    {
                        DataSet ds = new DataSet();
                        ds = obj.giaovien();
                        dgrgiaovien.DataSource = ds.Tables[0];
                        MessageBox.Show("Ban Them Thanh Cong !");
                        clearall();
                        btluu.Enabled = false;
                        btsua.Enabled = true;
                        btnhapmoi.Text = "Nhập mới";

                        
                    }
                }
            }
            else
            {
                bool kt;
                //=====================               
                string _magv, _htgv, _nsgv, _dcgv, _dtgv, _tdgv;
                int _gtgv;
                _magv = txtmagv.Text;
                _htgv = txthtgv.Text;
                _dcgv = txtdcgv.Text;
                _dtgv = txtdtgv.Text;
                _tdgv = txttdgv.Text;
                if (rdnam.Checked)
                    _gtgv = 1;
                else
                    _gtgv = 0;
                _nsgv = dateTimePicker1.Value.ToShortDateString();
                _magv = dgrgiaovien.CurrentCell.Value.ToString();
                kt = obj.suathongtingiaovien(_magv, _htgv, _nsgv, _dcgv, _dtgv, _tdgv,_gtgv);
                if (kt == false)
                {
                    MessageBox.Show("Ban Chua sua Duoc!");
                    return;
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = obj.giaovien();
                    dgrgiaovien.DataSource = ds.Tables[0];
                    MessageBox.Show("Ban da sua Thanh Cong !");
                    //ClearAll();
                    btluu.Enabled = false;
                    btsua.Enabled = true;
                    btnhapmoi.Enabled = true;
                    
                    btsua.Text = "Sửa";
                }

            }           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (btsua.Text == "Sửa")
            {

               txtmagv.Enabled = false;
                btnhapmoi.Enabled = false;
               
                btsua.Text = "Huỷ sửa";
                btluu.Enabled = true;

            }
            else
            {
                txtmagv.Enabled= true;
                btluu.Enabled = false;
                btsua.Text = "Sửa";
                btnhapmoi.Enabled = true;
               

            }          
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            string str = "giaovien";
            if (rdmagv.Checked==true)
            {
                string ma = "magv";
                bool kt;
                kt = obj.timkiemall(str, ma, txttkgv.Text);
                if (kt == false)
                {
                    MessageBox.Show("Dữ liệu bạn cần không tìm thấy !");
                    return;
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = obj.gettimkiemAll(str, ma, txttkgv.Text);
                    dgrgiaovien.DataSource = ds.Tables[0];
                }
            }
            else
            {
                if (rdtengv.Checked==true)
                {
                    string ma = "hoten";
                    bool kt;
                    kt = obj.timkiemall(str, ma, txttkgv.Text);
                    if (kt == false)
                    {
                        MessageBox.Show("Dữ liệu bạn cần không tìm thấy !");
                        return;
                    }
                    else
                    {
                        DataSet ds = new DataSet();
                        ds = obj.gettimkiemAll(str, ma, txttkgv.Text);
                        dgrgiaovien.DataSource = ds.Tables[0];
                    }
                }

                else
                {
                    MessageBox.Show("Hay chon cach tim kiem");
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vitri = 0;

            GanDuLieuTuRowVaoText(mtblgv, vitri);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vitri -= 1;

            if (vitri < 0)
                vitri = mtblgv.Rows.Count - 1;

            GanDuLieuTuRowVaoText(mtblgv, vitri);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vitri += 1;
            if (vitri > mtblgv.Rows.Count - 1)
                vitri = 0;
            GanDuLieuTuRowVaoText(mtblgv, vitri);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vitri = mtblgv.Rows.Count - 1;
            GanDuLieuTuRowVaoText(mtblgv, vitri);
        }
    }
}