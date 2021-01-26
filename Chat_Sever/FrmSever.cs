using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace Chat_Sever
{
    public partial class FrmSever : Form
    {
        Socket client,sever;
        IPEndPoint Ipe;
        public FrmSever()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            rtb1.Enabled = false;
            rtb2.Enabled = false;
            btnSend.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];//chứa dữ liệu gửi
            data = Encoding.Unicode.GetBytes(rtb2.Text);//mã hóa
            client.Send(data);
            rtb1.AppendText("\n client:" + rtb2.Text);
            rtb2.AppendText("\n client: " + rtb2.Text);
            rtb2.Clear();
            rtb2.Focus();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Ipe = new IPEndPoint(IPAddress.Any, 2019);
            sever.Bind(Ipe);//gán số hiệu cổng
            sever.Listen(10);//chờ kết nối
            rtb1.AppendText("\n Đang chờ kết nối...");
            client = sever.Accept();//chấp nhận kết nối
            rtb1.AppendText("\n Đã chấp nhận kết nối");
           // rtb1.Enabled = true;
            rtb2.Enabled = true;
            btnSend.Enabled = true;
            btnStart.Enabled = false;
            Thread tnhan = new Thread(new ThreadStart(Nhan));
            tnhan.Start();

        }
        public void Nhan()
        {
            rtb1.Clear();
            rtb1.Focus();
            while (true)
            {
                byte[] data = new byte[1024];//chứa dữ liệu nhận
                client.Receive(data);//nhận
                string str = Encoding.Unicode.GetString(data);//giải mã
                rtb1.AppendText("\n sever: " + str);
            }
        }
        private void FrmSever_Load(object sender, EventArgs e)
        {
           
        }
    }
}
