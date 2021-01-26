using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        private string path;
        bool isOpen = false;
        private Color mauchu;
        String tenFont = "Time New Roman";
        float coFont = 12;
        public Menu()
        {
            InitializeComponent();
        }

        private void eXitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            SaveFileDialog sv = new SaveFileDialog();
            sv.Title = "Save As";
            sv.Filter = "Text Document|*.txt";
            sv.DefaultExt = "txt";
            DialogResult result =  sv.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                rtb1.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
                this.Text = sv.FileName;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           OpenFileDialog OpenFileDialog = new OpenFileDialog();
           OpenFileDialog.Filter = "Text files (*.txt)|*.txt";
           if (OpenFileDialog.ShowDialog() == DialogResult.OK)
           {
               rtb1.Text = File.ReadAllText(OpenFileDialog.FileName);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rtb1.Clear();
            rtb1.Show();
            isOpen = true;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            ColorDialog colorChu = new ColorDialog();
            colorChu.ShowDialog();
            mauchu = colorChu.Color;
              rtb1.SelectionColor = mauchu;



        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.ShowDialog();
            coFont = f.Font.Size;
            tenFont = f.Font.Name;
            rtb1.SelectionFont = new Font(tenFont, coFont);

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            float zoom = rtb1.ZoomFactor;
            if (zoom * 2 < 64)
                rtb1.ZoomFactor = zoom * 2; 
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            float zoom = rtb1.ZoomFactor;
            if (zoom / 2 > 0.015625)
                rtb1.ZoomFactor = zoom / 2;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            rtb1.Undo();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

           
            rtb1.Clear();
            rtb1.Show();
            isOpen = true;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            rtb1.Redo();
        }

        private void underToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Undo();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            rtb1.Cut();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtb1.Paste();
        }

        private void coppyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Copy();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                rtb1.Text = File.ReadAllText(OpenFileDialog.FileName);
            }
        }

        private void seleetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.SelectAll();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = rtb1.Text.ToString();
            text = text.Remove(rtb1.SelectionStart, rtb1.SelectionLength);

            rtb1.Text = text;
        }


    }
}
