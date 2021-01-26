using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net;
using System.Net.Sockets;
namespace Chat_Sever
{
    public partial class ChatSever : Form
    {
        public ChatSever()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        Socket server,client;
        IPEndPoint ipe;


        private void rtbSever1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipe = new IPEndPoint(IPAddress.Any, 2019);
           // client.Connect(ipe);
            server.Bind(ipe);
            server.Listen(10);
            rtbSever1.AppendText("\n đăng chờ kết nối... ");
            client = server.Accept();
            rtbSever1.AppendText("\n đã chấp nhận kết nối");

        }

        private void rtbSever2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread tNhan = new Thread(new ThreadStart(Nhan));
            tNhan.Start();
            //Nhan();
        }
        public void Nhan()
        {
            while (true)
            {


                byte[] data = new byte[1024];
                data = Encoding.Unicode.GetBytes(rtbSever2.Text);
                client.Send(data);
                rtbSever2.AppendText("Client: " + rtbSever2.Text);
                
            }
        }
        private void btnRecive_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];// chua du lieu nhan
            client.Receive(data);// nhan ve 
            string s = Encoding.Unicode.GetString(data);
            rtbSever2.AppendText("\n Client:"+s);


        }

        
    }
}
