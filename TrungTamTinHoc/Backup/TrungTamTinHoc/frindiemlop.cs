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
    public partial class frindiemlop : Form
    {
        public frindiemlop()
        {
            InitializeComponent();
        }
        Classqlttth obj = new Classqlttth();
        //int vitri = 0;
        DataTable mtblhv = new DataTable();
        DataTable diem = new DataTable();
        //SqlConnection con = new SqlConnection();

      
        private void frindiemlop_Load(object sender, EventArgs e)
        {
            string sql;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=HP-PAVILION;database=QLTrungTamTinHoc;uid=sa;pwd=;";
            con.Open();
            sql = "select malop from lophoc";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "lophoc");
            cblop.DataSource = ds.Tables["lophoc"];
            cblop.DisplayMember = "malop";
            cblop.ValueMember = "malop";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma;
            ma = cblop.Text;
            //mal = comboBox1.Text;
            string sql;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=HP-PAVILION;database=QLTrungTamTinHoc;uid=sa;pwd=;";
            con.Open();
            sql = "select * from diem where malop='" + ma + "'";
            //sql = "select * from viewdiem where malop='" + mal + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "diem");
            dgdiem.DataSource = ds.Tables["diem"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public string chuoiloc;
        private void button2_Click(object sender, EventArgs e)
        {
            //frreportbienlai inbienlai = new frreportbienlai();//form chua crvrp
            //inbienlai.chuoiloc = "";
            //inbienlai.chuoiloc = "{Viewbienlai.mahv}='" + cbmahv.Text + "'";
            //inbienlai.Show();
            indiem diem = new indiem();
            diem.chuoiloc = "";
            diem.chuoiloc = "{viewdiem.malop}='" + cblop.Text + "'";
            diem.Show();
        }

        private void cblop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}