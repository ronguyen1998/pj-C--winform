using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitest
{
    public partial class frXepHinh : Form
    {
        public frXepHinh()
        {
            InitializeComponent();
            init();

        }
        Button[,] arr2;
        private bool tt_game;
        Color mau1 = Color.Red;
     
        Button btnTam = new Button();
        private int time;
        private void init()
        {
            arr2 = new Button[3, 3];
            arr2[0, 0] = btn1;
            arr2[0, 1] = btn2;
            arr2[0, 2] = btn3;
            arr2[1, 0] = btn4;
            arr2[1, 1] = btn5;
            arr2[1, 2] = btn6;
            arr2[2, 0] = btn7;
            arr2[2, 1] = btn8;
            arr2[2, 2] = btn9;
            makeButton(false);
            setMap();
            time = 0;
        }

        private void makeButton(bool v)
        {
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr2[i, j].Enabled = v;
                }
            }
        }
        private bool canh_nhau(Button a, Button b)
        {
            int x1 = a.Location.X;
            int x2 = b.Location.X;
            int y1 = a.Location.Y;
            int y2 = b.Location.Y;
            if ((Math.Abs(y1 - y2) == a.Size.Width && x1 == x2) || (Math.Abs(x1 - x2) == a.Size.Width && y1 == y2))
            {
                return true;
            }
            return false;
        }
        private void Hoan_doi(Button a, Button b)
        {
            btnTam.Location = a.Location;
            a.Location = b.Location;
            b.Location = btnTam.Location;
            var tmp = a.Tag;
            a.Tag = b.Tag;
            b.Tag = tmp;
            if (isDone())
            {
                timer1.Stop();
                MessageBox.Show("You Win! \n"+ (time / 60).ToString() + " m : " + (time % 60).ToString() + " s ", "Thông báo");
            }
        }
        private void setMap()
        {
            Random rd = new Random();
            for (int i = 0; i < 200; i++)
            {
                Hoan_doi(arr2[rd.Next(0, 3), rd.Next(0, 3)], arr2[rd.Next(0, 3), rd.Next(0, 3)]);
            }
        }
        private bool isDone()
        {
            int c = 0;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (!arr2[i, j].Tag.Equals("btn" + ++c)) //TODO
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            btnTamDung.Enabled = false;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            }

       private void btn6_Click(object sender, EventArgs e)
        {
           if (canh_nhau(btn6, btn9)) 
                Hoan_doi(btn9, btn6);
          }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (canh_nhau(btn8, btn9))
            {
                Hoan_doi(btn9, btn8);
            }      
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (canh_nhau(btn9, btn7))
                Hoan_doi(btn9, btn7);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (canh_nhau(btn9, btn5))
                Hoan_doi(btn9, btn5);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (canh_nhau(btn9, btn4))
                Hoan_doi(btn9, btn4);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (canh_nhau(btn9, btn2))
                Hoan_doi(btn9, btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (canh_nhau(btn9, btn3))
                Hoan_doi(btn9, btn3);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (canh_nhau(btn9, btn1))
                Hoan_doi(btn9, btn1);
        }

        private void start_Click(object sender, EventArgs e)
        {
            makeButton(true);
            timer1.Start();
            start.Enabled = false;
            btnTamDung.Enabled = true;
        
        }
        private void newGame_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn chơi lại không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dl == DialogResult.Yes)
            {
                init();
                timer1.Stop();
                makeButton(false);
                start.Enabled = true;
                btnTamDung.Enabled = false;
            }    
        }

        private void back_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnTamDung_Click(object sender, EventArgs e)
        {
            if(tt_game == true)
            {
                makeButton(false);
                tt_game = false;
                timer1.Stop();
                btnTamDung.Text = "Tiếp Tục";
                MessageBox.Show("Bấm tiếp tục để chơi tiếp ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            else
            {
                makeButton(true);
                tt_game = true;
                timer1.Start();
                btnTamDung.Text = "Tạm Dừng";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = (time / 60).ToString() +" m : " + (time % 60).ToString()+" s ";
            time++;
        }

        private void lb_time_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
