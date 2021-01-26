using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TinhToan().ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmXoSo().ShowDialog();
      
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new GamXepHinh().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new NotePad().ShowDialog();
        }
    }
}
