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
    public partial class frmXoSo : Form
    {
        string tengiai = "";
        int sochuso = 0;
        int sogiai = 0;
        string so = "";
        int sleepOneLoop = 0, timeout = 0, countLoop = 0;
        int slepOneloop = 0;
        Random rd = new Random();
        TextBox tb = null;
        public frmXoSo()
        {
            InitializeComponent();
            loadCBB();
            loadCDD();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tengiai = cbb.GetItemText(cbb.SelectedItem);
            switch (tengiai)
            {
                case "Giải Đặc Biệt":
                    sogiai = 1;
                    sochuso = 5;
                    break;
                case "Giải Nhất":
                    sogiai = 2;
                    sochuso = 5;

                    break;
                case "Giải 2":
                    sogiai = 7;
                    sochuso = 5;

                    break;
                case "Giải 3":
                    sogiai = 6;
                    sochuso = 5;

                    break;
                case "Giải 4":
                    sogiai = 6;
                    sochuso = 5;

                    break;
                case "Giải 5":
                    sogiai = 4;
                    sochuso = 5;

                    break;
                case "Giải 6":
                    sogiai = 3;
                    sochuso = 4;

                    break;
                case "Giải 7":
                    sogiai = 1;
                    sochuso = 3;

                    break;
                case "Giải 8":
                    sogiai = 1;
                    sochuso = 2;
                    break;
            }
        }
        public void loadCBB(){
            cbb.Items.Add("Giải 8");
            cbb.Items.Add("Giải 7");
            cbb.Items.Add("Giải 6");
            cbb.Items.Add("Giải 5");
            cbb.Items.Add("Giải 4");
            cbb.Items.Add("Giải 3");
            cbb.Items.Add("Giải 2");
            cbb.Items.Add("Giải Nhất");
            cbb.Items.Add("Giải Đặc Biệt");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void quay()
        {
            so = "";
            Random rd = new Random();
            for (int i = 0; i < sogiai; i++)
            {
                string sotam = "";
                for (int j = 0; j < sochuso; j++)
                {
                    sotam += rd.Next(10).ToString();
                }
                so = so + sotam + "   ";
            }
        }

        public void loadCDD()
        {
            comboBox1.Items.Add("Xổ Số Miền Bắc");
            comboBox1.Items.Add("Xổ Số Miền Trung");
            comboBox1.Items.Add("Xổ Số Miền Nam");
        }

        private void Số_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // quay();
            switch (tengiai)
            {
                case "Giải Đặc Biệt":
                    so9.Text = so;
                    tb = so9;
                   
                    break;
                case "Giải Nhất":
                    so8.Text = so;
                    tb = so8;
                    break;
                case "Giải 2":
                    so7.Text = so;
                    tb = so7;
                    break;
                case "Giải 3":
                    so6.Text = so;
                    tb = so6;
                    break;
                case "Giải 4":
                    so5.Text = so;
                    tb = so5;

                    break;
                case "Giải 5":
                    so4.Text = so;
                    tb = so4;
                    break;
                case "Giải 6":
                    so3.Text = so;
                    tb = so3;

                    break;
                case "Giải 7":
                    so2.Text = so;
                    tb = so2;
                    break;
                case "Giải 8":
                    //giai8.Text = so;
                    tb = giai8;
                    break;
            }
            timerQuay.Enabled = true;
        }

        private void giai8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            

       
        }

        private void button3_Click(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sleepOneLoop = Convert.ToInt32(numericUpDown1.Value)*1000;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timerQuay_Tick(object sender, EventArgs e)
        {
            String number = "";
            for (int i = 0; i < sochuso; i++)
                number += (rd.Next(10) + "");
            label14.Text = number;
            timeout += timerQuay.Interval;

            if (timeout >= sleepOneLoop)
            {
                tb.Text += label14.Text + "   ";
                countLoop++;
                timeout = 0;
                if (countLoop >= sogiai)
                {
                    countLoop = 0;
                    timerQuay.Enabled = false;
                }
            }
        }
    }
}
