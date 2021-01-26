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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoSo_Click(object sender, EventArgs e)
        {
            xoso f2 = new xoso();
            f2.ShowDialog();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            TinhToan f2 = new TinhToan();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
