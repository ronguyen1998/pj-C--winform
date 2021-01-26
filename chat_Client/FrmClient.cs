using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace chat_Client
{
    public partial class FrmClient : Form
    {
        Socket client;
        IPEndPoint Ipe;
        public FrmClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            rtb1.Enabled = false;
            rtb2.Enabled = false;
            btnSend.Enabled = false;
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
            Ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"),2019);
            client.Connect(Ipe);
            //rtb1.Enabled = true;
            rtb2.Enabled = true;
            btnSend.Enabled = true;
            btnConnect.Enabled = false;
            Thread tnhan = new Thread(new ThreadStart(Nhan));
            tnhan.Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            data = Encoding.Unicode.GetBytes(rtb2.Text);
            client.Send(data);
            rtb1.AppendText("\n sever:" + rtb2.Text);
            rtb2.AppendText("\n sever: " + rtb2.Text);
            rtb2.Clear();
            rtb2.Focus();
        }
        public void Nhan()
        { 
              while (true)
                {
                    byte[] data = new byte[1024];//chứa dữ liệu nhận
                    client.Receive(data);//nhận
                    string str = Encoding.Unicode.GetString(data);//giải mã
                    rtb1.AppendText("\n Client: " + str);
                }
        }
    }
}
