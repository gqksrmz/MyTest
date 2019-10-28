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

namespace TestServer
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        Socket socketSend;
        private void Form1_Load(object sender, EventArgs e)
        {
            //在程序加载的时候取消跨线程的访问
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            try
            {


                //创建一个负责监听的Socket
                //参数：IPV4 流式Socket TCP协议
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //创建IP地址和端口号对象
                //IPAddress ip = IPAddress.Parse(textServer.Text);
                IPAddress ip = IPAddress.Any;
                //string name = Dns.GetHostName();
                //IPAddress[] ipadrlist = Dns.GetHostAddresses(name);
                //创建端口号对象
                IPEndPoint point = new IPEndPoint(ip, 50090);
                //让负责监听的Socket绑定IP地址和端口号
                socketWatch.Bind(point);
                ShowMsg("监听成功！");
                //设置监听队列 在某个时间点内能连入服务端的最大客户端的数量(例子 进入游戏排队)
                socketWatch.Listen(10);
                //开启一个新的线程来执行Listen方法
                Thread th1 = new Thread(Listen);
                th1.IsBackground = true;
                th1.Start(socketWatch);
            }
            catch
            {

            }
        }
        public void ShowMsg(string str)
        {
            textLog.AppendText(str + "\r\n");
        }
        //存储ip地址和负责跟客户端通信的Socket
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        /// <summary>
        /// 监听客户端的连接，并创建与之通信的Socket
        /// </summary>
        /// <param name="s"></param>
        public void Listen(Object s)
        {
            try
            {


                Socket cocketWatch = (Socket)s;
                while (true)
                {
                    //负责监听的Socket 来接受客户端的连接 创建跟客户端通信的Socket
                    socketSend = cocketWatch.Accept();
                    //将远程客户端的ip地址和端口号存到combox中
                    combUsers.Items.Add(socketSend.RemoteEndPoint.ToString());
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + "连接成功");
                    //开启一个新线程来不停的接收客户端发来的消息
                    Thread th2 = new Thread(Rec);
                    th2.IsBackground = true;
                    th2.Start(socketSend);

                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// 不停的接受客户端发来的消息
        /// </summary>
        /// <param name="o"></param>
        public void Rec(Object o)
        {



            socketSend = o as Socket;
            //服务端开始接受客户端发来的数据
            byte[] buffer = new byte[1024 * 1024 * 2];
            while (true)
            {
                try
                {
                    //服务端实际接受到的字节数
                    int r = socketSend.Receive(buffer);
                    //表示客户端下线了
                    if (r == 0)
                    {
                        ShowMsg(socketSend.RemoteEndPoint.ToString() + "下线了");
                        break;
                    }
                    //Ip为。。。。。：你好啊
                    //将字节数组转换为字符串
                    string str = System.Text.Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + str);
                }
                catch
                {

                }
            }

        }
        /// <summary>
        /// 服务端给客户端发消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            try
            {
                string str = textMsg.Text;
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                //获得在下拉框中选中的ip地址
                string ip = combUsers.SelectedItem.ToString();
                dicSocket[ip].Send(buffer);
                textMsg.Text = null;
            }
            catch
            {

            }
        }
    }
}
