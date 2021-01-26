using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class xoso : Form
    {
        public xoso()
        {
            InitializeComponent();
        }

        private void xoso_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có muốn Thoát k?","thông báo",MessageBoxButtons.YesNo);
            if(dia == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }
        private void reset()
        {
            lbDB.ResetText();
            lbg1.ResetText();
            lbg2.ResetText();
            lbg3a.ResetText();
            lbg3b.ResetText();
            lbg4a.ResetText();
            lbg4b.ResetText();
            lbg4c.ResetText();
            lbg4d.ResetText();
            lbg4e.ResetText();
            lbg4f.ResetText();
            lbg4g.ResetText();
            lbg5.ResetText();
            lbg6a.ResetText();
            lbg6b.ResetText();
            lbg6c.ResetText();
            lbg7.ResetText();
            lbg8.ResetText();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null) { 
            if (checkBox1.Checked)
            {
                    reset();
                    timer1.Enabled = true;
                    delay = (int)soGiayc.Value * 1000;
                    timeOut = 0;
                    soGiayc.Enabled = false;
                    comboBox1.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    checkBox1.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
            }
            else
            {
                lbDB.Text = QuaySo(5, 0);
                lbg1.Text = QuaySo(4, 0);
                lbg2.Text = QuaySo(4, 0);
                lbg3a.Text = QuaySo(4, 0);
                lbg3b.Text = QuaySo(4, 0);
                lbg4a.Text = QuaySo(4, 0);
                lbg4b.Text = QuaySo(4, 0);
                lbg4c.Text = QuaySo(4, 0);
                lbg4d.Text = QuaySo(4, 0);
                lbg4e.Text = QuaySo(4, 0);
                lbg4f.Text = QuaySo(4, 0);
                lbg4g.Text = QuaySo(4, 0);
                lbg5.Text = QuaySo(3, 0);
                lbg6a.Text = QuaySo(3, 0);
                lbg6b.Text = QuaySo(3, 0);
                lbg6c.Text = QuaySo(3, 0);
                lbg7.Text = QuaySo(2, 0);
                lbg8.Text = QuaySo(1, 0);
            }

        }
            else
            {
                MessageBox.Show("Chọn Công Ty");
            }
           
        }
        private String QuaySo(int soChuSo, int soGiay)
        {
            String tam = "";
            Random rd = new Random();
            for(int i = 0; i <= soChuSo; i++)
            {
                tam += rd.Next(10);
                Thread.Sleep(10);
            }
            return tam;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        int timeOut = 0;
        int delay;
        int id = 0;
     
        private void timer1_Tick(object sender, EventArgs e)
        {
           
                timeOut += timer1.Interval;
                id = timeOut / delay;
                switch (id)
                {
                    case 0:
                        {
                            lbDB.Text = QuaySo(5, delay);
                            break;
                        }
                    case 1:
                        {
                            lbg1.Text = QuaySo(4, delay);
                            break;
                        }
                    case 2:
                        {
                            lbg2.Text = QuaySo(4, delay);
                            break;
                        }
                    case 3:
                        {
                            lbg3a.Text = QuaySo(4, delay);

                            break;
                        }
                    case 4:
                        {
                            lbg3b.Text = QuaySo(4, delay);
                            break;
                        }
                    case 5:
                        {
                            lbg4a.Text = QuaySo(4, delay);
                            lbg4b.Text = QuaySo(4, delay);
                            lbg4c.Text = QuaySo(4, delay);
                            break;
                        }
                   
                    case 6:
                    {
                        lbg4d.Text = QuaySo(4, delay);
                        lbg4e.Text = QuaySo(4, delay);
                        lbg4f.Text = QuaySo(4, delay);
                        lbg4g.Text = QuaySo(4, delay);
                        break;
                    }
                   
                    case 7:
                        {
                            lbg5.Text = QuaySo(3, delay);

                            break;
                        }
                    case 8:
                        {
                            lbg6a.Text = QuaySo(3, delay);

                            break;
                        }
                    case 9:
                        {
                            lbg6b.Text = QuaySo(3, delay);
                            break;
                        }
                    case 10:
                        {
                            lbg6c.Text = QuaySo(3, delay);
                            break;
                        }
                    case 11:
                        {
                            lbg7.Text = QuaySo(2, delay);
                            break;
                        }
                    case 12:
                    {
                        lbg8.Text = QuaySo(1, delay);
                        break;
                    }
                case 13:
                    {
                        timer1.Stop();
                        MessageBox.Show("Quay Xong");
                        break;
                    }
                default:
                        {
                            timer1.Enabled = false;
                            break;
                        }
                }
            }
            
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void soGiay_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
