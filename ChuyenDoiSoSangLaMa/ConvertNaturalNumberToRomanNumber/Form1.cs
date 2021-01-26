using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertNaturalNumberToRomanNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            try
            {
                string a = string.Empty;
                decimal socanchuyen = nudSoCanDoi.Value;
                Boolean flag = true;
                string[] ArrayLaMa = {"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
                int[] ArrayNumber = {1000,900,500,400,100,90,50,40,10,9,5,4,1 };
                int i = 0;
                while(flag)
                {
                    while (socanchuyen>=ArrayNumber[i])
                    {
                        socanchuyen -= ArrayNumber[i];
                        a += ArrayLaMa[i];
                        if (socanchuyen < 1)
                            flag = false;

                    }
                    i++;
                    
                }
                txtLaMa.Text = a;


            }
            catch
            {
                txtLaMa.Text = string.Empty;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
