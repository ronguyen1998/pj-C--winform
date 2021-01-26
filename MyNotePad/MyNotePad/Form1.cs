using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class Form1 : Form
    {
        string fileName = "NoName";
        public Form1()
        {
            
            InitializeComponent();
        }
        private void SaveSetting()
        {
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.Height = this.Height;
            Properties.Settings.Default.Width = this.Width;
            Properties.Settings.Default.Font = tbVanBan.Font;
            Properties.Settings.Default.WordWrap = tbVanBan.WordWrap;
            Properties.Settings.Default.Save();

        }
        private void LoadSetting()
        {
            this.Location = Properties.Settings.Default.Location;
            this.Height = Properties.Settings.Default.Height;
            this.Width = Properties.Settings.Default.Width;
            tbVanBan.Font = Properties.Settings.Default.Font;
            tbVanBan.WordWrap = Properties.Settings.Default.WordWrap;
            wordWrapToolStripMenuItem.Checked = tbVanBan.WordWrap;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSetting();

            this.Text = "MyNotePad -" + fileName;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSetting();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát?", "thông báo", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                DialogResult l = MessageBox.Show("Lưu File", "thông báo", MessageBoxButtons.YesNoCancel);
                if (l == DialogResult.Yes)
                {   
                    Application.Exit();
                }
                if (l == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = tbVanBan.Font;// hien thi len font đúng vs cái hộp thoại chọn font đúng vs font đang use cho textbox
            if( fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK )    
            {
                tbVanBan.Font = fontDialog1.Font;

            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;// laays ten file
                System.IO.File.WriteAllText(fileName, tbVanBan.Text);// luu file
                this.Text = "MyNotepad -" + fileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (fileName == "NoName ")
            {
                saveToolStripMenuItem_Click(null, null);
            }
            else
            {
                System.IO.File.WriteAllText(fileName, tbVanBan.Text);
                this.Text = "MyNotepad -" + fileName;
            }
        }

       
        private void tbVanBan_TextChanged(object sender, EventArgs e)
        {
            if (tbVanBan.Modified)
            {
                this.Text = " MyNotePad -" + fileName  + "  *";
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbVanBan.Modified)
            {
                if(MessageBox.Show("Bạn có muốn lưu tập tin đang soạn thảo không ","Xác Nhận ",MessageBoxButtons.YesNo, MessageBoxIcon.Question )== System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);

                }
            }
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {

            fileName = openFileDialog1.FileName;
            tbVanBan.Text = System.IO.File.ReadAllText(fileName);
            this.Text = "MyNotepad -" + fileName;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbVanBan.Modified)
            {
                if (MessageBox.Show("Bạn có muốn lưu tập tin đang soạn thảo không ", "Xác Nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);

                }
            }

            fileName = "NoName";
            tbVanBan.Text = "";
            this.Text = "MyNotePad -" + fileName;
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbVanBan.Text);
            tbVanBan.Text = "";
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbVanBan.Text);
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                tbVanBan.Text = Clipboard.GetText(TextDataFormat.Rtf);
            }
            else if (Clipboard.ContainsText(TextDataFormat.UnicodeText))
            {
                tbVanBan.Text = Clipboard.GetText();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbVanBan.Clear();
        }
    }
}
