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
    public partial class GamXepHinh : Form
    {
        public GamXepHinh()
        {
            InitializeComponent();
        }
      
        Color mau1 = Color.Red;
        Color mau2 = Color.Blue;
        Button btnTam = new Button();
   
       
        private bool CanhNhau(Button b1 , Button b2)
        {
            if(b1.Location.Y == b2.Location.X )
                if(Math.Abs(b1.Location.X - b2.Location.X) <=150){
                    HoanDoi(b1,b2);
                    return true;
                }
            if (b1.Location.Y == b2.Location.Y)
                if (Math.Abs(b1.Location.X - b2.Location.Y ) <= 150){
                    HoanDoi(b1,b2);
                    return true;
                }
            return false;
            

        }
        private void HoanDoi(Button b1 , Button b2)
        {
            btnTam.Location = b1.Location;
            b1.Location = b2.Location;
            b2.Location = btnTam.Location;
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            btn1.BackColor = mau1;
            
        }

        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            btn2.BackColor = mau1;
        }

        private void btn3_MouseEnter(object sender, EventArgs e)
        {
            btn3.BackColor = mau1;
        }

        private void btn4_MouseEnter(object sender, EventArgs e)
        {
            btn4.BackColor = mau1;
        }
        private void btn5_MouseEnter(object sender, EventArgs e)
        {
            btn5.BackColor = mau1;

        }

        private void btn6_MouseEnter(object sender, EventArgs e)
        {
            btn6.BackColor = mau1;
        }

        private void btn7_MouseEnter(object sender, EventArgs e)
        {
            btn7.BackColor = mau1;
        }

        private void btn8_MouseEnter(object sender, EventArgs e)
        {
            btn8.BackColor = mau1;
        }

        private void btn0_MouseEnter(object sender, EventArgs e)
        {
            btn0.BackColor = mau1;
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btn1.BackColor = mau2;
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            btn2.BackColor = mau2;
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            btn3.BackColor = mau2;

        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            btn4.BackColor = mau2;
        }

        private void btn5_MouseLeave(object sender, EventArgs e)
        {
            btn5.BackColor = mau2;
        }

        private void btn6_MouseLeave(object sender, EventArgs e)
        {
            btn6.BackColor = mau2;
        }

        private void btn7_MouseLeave(object sender, EventArgs e)
        {
            btn7.BackColor = mau2;
        }

        private void btn8_MouseLeave(object sender, EventArgs e)
        {
            btn8.BackColor = mau2;
        }

        private void btn0_MouseLeave(object sender, EventArgs e)
        {
            btn0.BackColor = mau2;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           //if( CanhNhau(btn0, btn1))
             //  HoanDoi(btn0,btn1);
            CanhNhau(btn0, btn1);

        }
        // foreach duyet qua tung nut lenh 
        // file - random
        //      - exit
        //      - close 
         
     //   private void mnuRand_Click(object sender , EventArgs e)
       // {
          //  foreach (Button b in groupBox1.Controls)
           //     HoanDoi(b, btn0);
       // }

        private void btn2_Click(object sender, EventArgs e)
        {
            //if(CanhNhau(btn0, btn2))
             //   HoanDoi(btn0,btn2);
            CanhNhau(btn0, btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
           // if (CanhNhau(btn0, btn3))
             //   HoanDoi(btn0, btn3);
            CanhNhau(btn0, btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            CanhNhau(btn0, btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            CanhNhau(btn0, btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            CanhNhau(btn0, btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            CanhNhau(btn0, btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            CanhNhau(btn0, btn8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
    
	        // ... Create new Random object.
	        Random r = new Random();
	        // ... Get three random numbers.
	        //     Always 5, 6, 7, 8 or 9.
	        Console.WriteLine(r.Next(5, 10));
	        Console.WriteLine(r.Next(5, 10));
	        Console.WriteLine(r.Next(5, 10));
    
        }
    }
}
