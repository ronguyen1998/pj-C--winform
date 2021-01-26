using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Chat_client
{
    public partial class ChatClient : Form
    {
        public ChatClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        Socket client;
        IPEndPoint ipe;


        private void ChatClient_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"),2019);
            client.Connect(ipe);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            data = Encoding.Unicode.GetBytes(rtbClient2.Text);
            client.Send(data );
            rtbClient2.AppendText("Client: "+rtbClient2.Text);
            rtbClient2.Clear();
            rtbClient2.Focus();
        }

        private void rtbClient1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReciveClient_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];// chua du lieu nhan
            client.Receive(data);// nhan ve 
            string s = Encoding.Unicode.GetString(data);
            rtbClient2.AppendText("\n Client:"+s);
        }

       
    }
}
