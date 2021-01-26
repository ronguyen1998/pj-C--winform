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

namespace bai5
{
    public partial class Notepad : Form
    {
        private SaveFileDialog sv;
        private OpenFileDialog op;
        bool isSv = true;
       
        private Color mauchu;
        private Color mauNen;
        String path;
        String tenFont = "";
        float foFont  ;

        string fileName = "NoName";
        public Notepad()
        {
            InitializeComponent();
        }


        private void SaveSetting()
        {
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.Height = this.Height;
            Properties.Settings.Default.Width = this.Width;
            Properties.Settings.Default.Font = rtb1.Font;
            Properties.Settings.Default.WordWrap = rtb1.WordWrap;
            Properties.Settings.Default.Save();

        }
        private void LoadSetting()
        {
            this.Location = Properties.Settings.Default.Location;
            this.Height = Properties.Settings.Default.Height;
            this.Width = Properties.Settings.Default.Width;
            rtb1.Font = Properties.Settings.Default.Font;
            rtb1.WordWrap = Properties.Settings.Default.WordWrap;
            wordWrapToolStripMenuItem.Checked = rtb1.WordWrap;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtb1.Enabled = false;
            rtb1.ContextMenuStrip = contextMenuStrip1;
            addforn();

            LoadSetting();

            this.Text = "MyNotePad -" + fileName;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefile();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFiles();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                op = new OpenFileDialog();
                op.ShowDialog();
                path = op.FileName;
                rtb1.LoadFile(path);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            savefile();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            newFiles();
        }
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát?", "thông báo", MessageBoxButtons.YesNo);
            if(dl == DialogResult.Yes)
            {
                DialogResult l = MessageBox.Show("Lưu File", "thông báo", MessageBoxButtons.YesNoCancel);
                if(l == DialogResult.Yes)
                {
                    savefile();
                    Application.Exit();
                }
                if(l == DialogResult.No)
                {
                    Application.Exit();
                }

            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefile();
        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {
          
        }
        private void savefile()
        {
            try
            {
               sv = new SaveFileDialog();
                sv.ShowDialog();
                path = sv.FileName;
                rtb1.SaveFile(path);
                isSv = true;
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void newFiles()
        {
            if (isSv == false)
            {
                DialogResult dl = MessageBox.Show("Files Chưa được lưu!\n"+"bạn có muốn lưu?", "Lưu Files", MessageBoxButtons.YesNoCancel);
                if (dl == DialogResult.Yes)
                {
                    savefile();
                    rtb1.Enabled = true;
                    rtb1.Clear();
                    rtb1.Show();
                    isSv = false;
                }
                else if(dl == DialogResult.No)
                {
                    rtb1.Enabled = true;
                    rtb1.Clear();
                    rtb1.Show();
                    isSv = false;
                }
            }
            else if(isSv ==true)
            {
                rtb1.Enabled = true;
                rtb1.Clear();
                rtb1.Show();
                isSv = false;
            }
        }
        private void addforn()
        {    
            toolStripComboBox1.Items.Clear();
            ccbCoChu.Items.Clear();
            float c2 = 8;
              foreach(FontFamily f in FontFamily.Families)
              {
                  ccbCoChu.Items.Add(c2++);
                  toolStripComboBox1.Items.Add(f.Name);
              }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            //rtb1.SelectionColor = Color.Red;
            ColorDialog colorChu = new ColorDialog();
            colorChu.ShowDialog();
            mauchu = colorChu.Color;
            rtb1.ForeColor = mauchu;
        }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tenFont = toolStripComboBox1.SelectedItem.ToString();
            rtb1.Font = new Font(tenFont, foFont);
        }

        private void ccbCoChu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foFont = (float)Convert.ToDecimal(ccbCoChu.SelectedItem.ToString());
            rtb1.Font = new Font(tenFont, foFont);
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {

        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb1.Text);
            rtb1.Text = "";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb1.Text);
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                rtb1.Rtf = Clipboard.GetText(TextDataFormat.Rtf);
            }
            else if (Clipboard.ContainsText(TextDataFormat.UnicodeText))
            {
                rtb1.Text = Clipboard.GetText();
            }
        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtb1.Clear();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ColorDialog colorNen = new ColorDialog();
            colorNen.ShowDialog();
            mauNen = colorNen.Color;
            rtb1.BackColor = mauNen;
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtb1.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtb1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.DeselectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Undo();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.SelectAll();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            float Zoom = rtb1.ZoomFactor;
            if (Zoom * 2 < 64)
                rtb1.ZoomFactor = Zoom * 2;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            float Zoom = rtb1.ZoomFactor;
            if (Zoom / 2 > 0.015625)
                rtb1.ZoomFactor = Zoom / 2;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
