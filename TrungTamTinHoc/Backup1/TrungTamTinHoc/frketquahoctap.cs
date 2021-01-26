using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TrungTamTinHoc
{
    public partial class frketquahoctap : Form
    {
        public frketquahoctap()
        {
            InitializeComponent();
        }
        Classqlttth obj = new Classqlttth();
        int vitri = 0;
        DataTable mtblhv = new DataTable();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void clearall()
        {
            
            txtmal.Clear();
            txtmakh.Clear();
            txtdtk.Clear();
            txtdgk.Clear();
            txtdck.Clear();
           
        }
        private void GanDuLieuTuRowVaoText(DataTable tbl, int vitri)
        {
            DataRow drw;
            drw = tbl.Rows[vitri];
           cbmahv.Text= drw["mahv"].ToString();            
           txtmal.Text= drw["malop"].ToString();
           txtmakh.Text = drw["makh"].ToString();
          txtdtk.Text = drw["diem1"].ToString();
          txtdgk.Text = drw["diem2"].ToString();
          txtdck.Text = drw["diem3"].ToString();

        }
        void ht()
        {
            

          mtblhv = obj.getDataTable("diem");
          GanDuLieuTuRowVaoText(mtblhv, vitri);
          DataSet ds = new DataSet();
          ds = obj.getDataSet("diem");
          dgdiem.DataSource = ds.Tables[0];
        }
        private void cbmahv_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable tbl = new DataTable();
            DataRow dw;
            string sql = "select* from View2 Where MaHV=N'" + cbmahv.Text + "' ";
            //string sql = "select* from hocvien Where MaHV=N'" + cbmahv.Text + "' ";
            ds = obj.getDataSetSQL(sql, "VKH");
            dw = ds.Tables["VKH"].Rows[0];
           txtmakh.Text = dw["makh"].ToString();
           txtmal.Text = dw["malop"].ToString();
        }

        private void frketquahoctap_Load(object sender, EventArgs e)
        {
            clearall();
            DataSet ds = new DataSet();
            DataTable tbl = new DataTable();
            DataRow dw;
            string sql = "select* from View2";
            //string sql = "select* from bienlai1";
            ds = obj.getDataSetSQL(sql, "VBL");
            tbl = ds.Tables["VBL"];
            //for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                dw = tbl.Rows[i];
                cbmahv.Items.Add(dw["mahv"].ToString());
            }
            //*******
            //dgbienlai.DataSource = tbl;
            ht();
        }
        //--------kiem tra du lieu hop le--------------//
        public bool kiemtradulieud()
        {
            if (cbmahv.Text == "" || txtmal.Text==""||txtmakh.Text==""||txtdck.Text==""||txtdgk.Text==""||txtdtk.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return false;
            }
            else
            {
                if (obj.kiemtratrungd(cbmahv.Text))
                {
                    MessageBox.Show("  Mã Học viên này đã tồn tại !");
                    return false;
                    
                }
                return true;
            }
        }
        string xl, gc;
      
       

       

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá thông tin học viên này?", "THONG BAO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                bool kt;
                string mahv = dgdiem.CurrentCell.Value.ToString();
                kt = obj.xoadiem(mahv);
                if (kt == false)
                {
                    MessageBox.Show("Chua Xoa Duoc!");
                    return;
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = obj.diem();
                    dgdiem.DataSource = ds.Tables[0];
                    MessageBox.Show("Xoa Thanh Cong!");

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

        void clear()
        {
            txtdck.Clear();
            txtdgk.Clear();
            txtdtk.Clear();
        }
        private void btnhapmoi_Click(object sender, EventArgs e)
        {
            clear();
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

        private void btluu_Click(object sender, EventArgs e)
        {
               if (btsua.Enabled == false)
               {
                   bool kt;

                   if (kiemtradulieud() == false)
                   {

                       return;
                   }
                   else
                   {
                       string mhv, mkh, ml;
                       //bool tt;
                       double d1, d2, d3, d4;
                       mhv = cbmahv.Text;
                       mkh = txtmakh.Text;
                       ml = txtmal.Text;

                       d1 = double.Parse(txtdtk.Text);
                       d2 = double.Parse(txtdgk.Text);
                       d3 = double.Parse(txtdck.Text);
                       d4 = Math.Round(((d1 + d2 + d3) / 3), 1);
                       if (d3 < 5)
                           d4 = 0;
                       if (d4 < 5)
                       {
                           xl = " ";
                           gc = "thi lại.";

                       }

                       if (d4 > 5 && d4 < 6.9)
                       {
                           xl = "trung bình";
                           gc = "DUOC CAP CHUNG CHI ";
                       }
                       if (d4 > 7 && d4 < 8)
                       {
                           xl = "khá";
                           gc = " DUOC CAP CHUNG CHI";
                       }
                       if (d4 > 8 && d4 < 9.5)
                       {
                           xl = "GIOI";
                           gc = " DUOC CAP CHUNG CHI";
                       }
                       if (d4 > 9.5 && d4 <= 10)
                       {
                           xl = "XUAT SAC";
                           gc = " DUOC CAP CHUNG CHI";
                       }



                       kt = obj.luudiem(mhv, mkh, ml, d1, d2, d3, d4, xl, gc);
                       if (kt == false)
                       {
                           MessageBox.Show("Ban Chua Them Duoc!");
                           return;
                       }
                       else
                       {
                           DataSet ds = new DataSet();
                           ds = obj.diem();
                           dgdiem.DataSource = ds.Tables[0];
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
                   string mhv,mkh,ml;
                   bool kt;
                   double d1, d2, d3,d4;
                   mhv = cbmahv.Text;
                   mkh = txtmakh.Text;
                   ml = txtmal.Text;

                   d1 = double.Parse(txtdtk.Text);
                   d2 = double.Parse(txtdgk.Text);
                   d3 = double.Parse(txtdck.Text);
                   d4 = Math.Round(((d1 + d2 + d3) / 3), 1); 
                   mhv = dgdiem.CurrentCell.Value.ToString();
                   //d4 = Math.Round(((d1 + d2 + d3) / 3), 1);
                   if (d3 < 5)
                       d4 = 0;
                   if (d4 < 5)
                   {
                       xl = " ";
                       gc = "thi lại.";

                   }

                   if (d4 > 5 && d4 < 6.9)
                   {
                       xl = "trung bình";
                       gc = "DUOC CAP CHUNG CHI ";
                   }
                   if (d4 > 7 && d4 < 8)
                   {
                       xl = "khá";
                       gc = " DUOC CAP CHUNG CHI";
                   }
                   if (d4 > 8 && d4 < 9.5)
                   {
                       xl = "GIOI";
                       gc = " DUOC CAP CHUNG CHI";
                   }
                   if (d4 > 9.5 && d4 <= 10)
                   {
                       xl = "XUAT SAC";
                       gc = " DUOC CAP CHUNG CHI";
                   }
                   kt = obj.suathongtindiem(mhv,mkh,ml, d1, d2, d3,d4,xl,gc);
                   if (kt == false)
                   {
                       MessageBox.Show("Ban Chua sua Duoc!");
                       return;
                   }
                   else
                   {
                       DataSet ds = new DataSet();
                       ds = obj.diem();
                       dgdiem.DataSource = ds.Tables[0];
                       MessageBox.Show("Ban da sua Thanh Cong !");
                       btluu.Enabled = false;
                       btsua.Enabled = true;
                       btnhapmoi.Enabled = true;
                       btsua.Text = "Sửa";
                   }
               }
             }

        private void btsua_Click(object sender, EventArgs e)
        {
            clear();
            if (btsua.Text == "Sửa")
            {
               // txtmakh.Enabled = false;
               // txtmal.Enabled = false;
               //cbmahv.Enabled = false;
                btnhapmoi.Enabled = false;

                btsua.Text = "Huỷ sửa";
                btluu.Enabled = true;

            }
            else
            {
                cbmahv.Enabled = true;
                btluu.Enabled = false;
                btsua.Text = "Sửa";
                btnhapmoi.Enabled = true;

            }          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        
    }
}