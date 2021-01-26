using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class TinhToan : Form
    {
        
 
        public TinhToan()
        {
            InitializeComponent();
        }

        private void lbketqua_Click(object sender, EventArgs e)
        {

        }
   
        private void btnCong_Click(object sender, EventArgs e)
        {
           Double c;
           Double d ;
            if (!Double.TryParse(a.Text, out c) && (!Double.TryParse(b.Text, out d)))
            {
                MessageBox.Show("Nhập số!");
            }
            else
            {
                lbketqua.Text = ((Double.Parse(a.Text)) + (Double.Parse(b.Text))).ToString();
            }
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            Double c;
            Double d;
            if (!Double.TryParse(a.Text, out c) && (!Double.TryParse(b.Text, out d)))
            {
                MessageBox.Show("Nhập số!");
            }
            else
            {
                lbketqua.Text = ((Double.Parse(a.Text)) - (Double.Parse(b.Text))).ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            Double c;
            Double d;
            if (!Double.TryParse(a.Text, out c) && (!Double.TryParse(b.Text, out d)))
            {
                MessageBox.Show("Nhập số!");
            }
            else
            {
                lbketqua.Text = ((Double.Parse(a.Text)) * (Double.Parse(b.Text))).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double c;
            Double d;
            if (!Double.TryParse(a.Text, out c) && (!Double.TryParse(b.Text, out d)))
            {
                MessageBox.Show("Nhập số!");
            }
            else
            {
                lbketqua.Text = ((Double.Parse(a.Text)) / (Double.Parse(b.Text))).ToString();
            }
        }
    }
}
