using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GhepHinh
{
    partial class AboutBox : XtraForm
    {
        public AboutBox()
        {
            InitializeComponent();
           
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void AboutBox_Load(object sender, EventArgs e)
		{

		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("Nguyen van ");
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("nguyen van ");
		}
    }
}
