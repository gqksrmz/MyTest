using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClient
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        Socket socket;
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //在客户端创建一个与服务端进行通信的Socket
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //获得要连接的服务器的IP地址
                IPAddress ip = IPAddress.Parse(textServer.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(textPort.Text));
                //客户端负责通信的Socket去连接服务端的IP地址跟端口号
                socket.Connect(point);
                ShowMsg("连接成功！");
                Thread th1 = new Thread(Rec);
                th1.IsBackground = true;
                th1.Start();

            }
            catch
            {

            }
        }

        private void Rec()
        {
            try
            {


            while (true)
            {
                //客户端接收服务端发送的数据
                byte[] buffer = new byte[1024 * 1024 * 2];
                int r = socket.Receive(buffer);
                string str = System.Text.Encoding.UTF8.GetString(buffer, 0, r);
                ShowMsg(str);
               
            }
            }
            catch
            {

            }
        }

        public void ShowMsg(string str)
        {
            textLog.AppendText(socket.RemoteEndPoint.ToString() + ":"+str + "\r\n");
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            try
            {
                string str = textMsg.Text;
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                socket.Send(buffer);
                textMsg.Text = null;
            }
            catch
            {

            }
        }
        
    }
}
