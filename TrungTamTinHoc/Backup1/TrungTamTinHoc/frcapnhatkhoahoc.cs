using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrungTamTinHoc
{
    public partial class frcapnhatkhoahoc : Form
    {
        public frcapnhatkhoahoc()
        {
            InitializeComponent();
        }
        Classqlttth obj = new Classqlttth();
        int vitri = 0;
        DataTable mtblkh = new DataTable();
        //======//

        void clearall()
        {
            txtmkh.Clear();
            txttenkh.Clear();
            txtmkh.Focus();
           

        }
        //====//
        private void GanDuLieuTuRowVaoText(DataTable tbl, int vitri)
        {
            DataRow drw;
            drw = tbl.Rows[vitri];
            txtmkh.Text = drw["makh"].ToString();
            txttenkh.Text = drw["tenkh"].ToString();
            

        }
        private void frcapnhatkhoahoc_Load(object sender, EventArgs e)
        {

            mtblkh = obj.getDataTable("khoahoc");
            GanDuLieuTuRowVaoText(mtblkh, vitri);
            DataSet ds = new DataSet();
            ds = obj.getDataSet("khoahoc");
            dgvkhoahoc.DataSource = ds.Tables[0];
            btluu.Enabled = false;
            clearall();
        }

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
        //====kiem tra du lieu hop le====//
        public bool kiemtradulieukhoahoc()
        {
            if (txtmkh.Text == "" ||txttenkh.Text == "" )
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return false;
            }
            else
            {
                if (obj.kiemtatrungkhoaKH(txtmkh.Text))
                {
                    MessageBox.Show(" Mã khoá học này đã tồn tại !");
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
                if (kiemtradulieukhoahoc() == false)
                {

                    return;
                }
                else
                {
                    string mkh,tkh;
                    mkh = txtmkh.Text;
                    tkh = txttenkh.Text;


                    kt = obj.luukhoahoc(mkh,tkh);
                    if (kt == false)
                    {
                        MessageBox.Show("Ban Chua Them Duoc!");
                        return;
                    }
                    else
                    {
                        DataSet ds = new DataSet();
                        ds = obj.khoahoc();
                        dgvkhoahoc.DataSource= ds.Tables[0];
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
                string mkh,tkh;
                mkh = txtmkh.Text;
                tkh = txttenkh.Text;

                mkh = dgvkhoahoc.CurrentCell.Value.ToString();
                kt = obj.suathongtinkhoahoc(mkh,tkh);
                if (kt == false)
                {
                    MessageBox.Show("Ban Chua sua Duoc!");
                    return;
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = obj.khoahoc();
                    dgvkhoahoc.DataSource = ds.Tables[0];
                    MessageBox.Show("Ban da sua Thanh Cong !");
                    //ClearAll();
                    btluu.Enabled = false;
                    btsua.Enabled = true;
                    btnhapmoi.Enabled = true;
                    
                    btsua.Text = "Sửa";
                }

            }           
        }

        private void btsua_Click(object sender, EventArgs e)
        {
             if (btsua.Text == "Sửa")
            {

              txtmkh.Enabled = false;
                btnhapmoi.Enabled = false;
                
                btsua.Text = "Huỷ sửa";
                btluu.Enabled = true;

            }
            else
            {
               txtmkh.Enabled= true;
                btluu.Enabled = false;
                btsua.Text = "Sửa";
                btnhapmoi.Enabled = true;
                
        }
    }

        //private void btxoa_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có chắc muốn xoá thông tin khoá học này?", "THONG BAO", MessageBoxButtons.OKCancel) == DialogResult.OK)
        //    {

        //        bool kt;
        //        string mkh = dgvkhoahoc.CurrentCell.Value.ToString();
        //        kt = obj.xoakhoahoc(mkh);
        //        if (kt == false)
        //        {
        //            MessageBox.Show("Chua Xoa Duoc!");
        //            return;
        //        }
        //        else
        //        {
        //            DataSet ds = new DataSet();
        //            ds = obj.khoahoc();
        //            dgvkhoahoc.DataSource = ds.Tables[0];
        //            MessageBox.Show("Xoa Thanh Cong!");

        //        }
        //    }
        //}

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vitri = 0;

            GanDuLieuTuRowVaoText(mtblkh, vitri);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vitri -= 1;

            if (vitri < 0)
                vitri = mtblkh.Rows.Count - 1;

            GanDuLieuTuRowVaoText(mtblkh, vitri);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vitri += 1;
            if (vitri > mtblkh.Rows.Count - 1)
                vitri = 0;
            GanDuLieuTuRowVaoText(mtblkh, vitri);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vitri = mtblkh.Rows.Count - 1;
            GanDuLieuTuRowVaoText(mtblkh, vitri);
        }
      }
  }
