using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace 客户端
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //设置或获取一个值，该值指示是否捕获对错误线程的调用
            CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// 创建客户端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        Socket Client;
        private void btnConnet_Click(object sender, EventArgs e)
        {
            //创建客户端
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //IP地址
            IPAddress ip = IPAddress.Parse(txtIP.Text);

            //端口号
            IPEndPoint point = new IPEndPoint(ip, int.Parse(txtPort.Text));

            //建立服务器的远程连接
            Client.Connect(point);
            
            //线程问题
            Thread thread = new Thread(ReciveMsg);
            thread.IsBackground = true;
            thread.Start(Client);

        }

        void ReciveMsg(Object o)
        {
            Socket client = o as Socket;

            while (true)
            {
                try
                {

                    //定义客户端接收到的信息大小
                    byte[] arrList = new byte[1024 * 1024];

                    //接受到的信息大小
                    int length = client.Receive(arrList);
                    string msg = DateTime.Now + Encoding.UTF8.GetString(arrList, 0, length);
                    lbXian.AppendText(msg);
                }
                catch
                {
                    if (client != null && client.Connected)
                    {
                        
                        //关闭Socket之前，首选需要把双方的Socket Shutdown掉
                        client.Shutdown(SocketShutdown.Both);

                        //Shutdown掉Socket后主线程停止10ms，保证Socket的Shutdown完成
                        System.Threading.Thread.Sleep(10);

                        //关闭客户端Socket,清理资源
                        client.Close();

                    }
                }
              
            }
            
        }
       
        void SendMsg(string str)
        {
            byte[] arrMsg = Encoding.UTF8.GetBytes(str);
            Client.Send(arrMsg);
        }


        /// <summary>
        /// 客户端发送消息给服务端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text != "")
            {

                 txtEnter.Text = txtMing.Text+":" + txtEnter.Text;
                SendMsg(txtEnter.Text);
                txtEnter.Text = "";
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            //线程问题
            Thread thread = new Thread(Tuichu);
            thread.IsBackground = true;
            thread.Start(Client);
            //thread.Abort();
            this.Controls.Clear();
        }
        
        void Tuichu(object o)
        {
            Socket client = o as Socket;

            while (true)
            {
                try
                {
                    if (client != null && client.Connected)
                    {
                        SendMsg(txtMing.Text + "退出聊天室!");
                        //关闭Socket之前，首选需要把双方的Socket Shutdown掉
                        client.Shutdown(SocketShutdown.Both);

                        //Shutdown掉Socket后主线程停止10ms，保证Socket的Shutdown完成
                        System.Threading.Thread.Sleep(10);

                        //移除添加在字典中的服务器和客户端之间的线程
                        //ClientList.Remove(client.RemoteEndPoint.ToString());

                        //关闭客户端Socket,清理资源
                        client.Close();
                        break;

                    }
                }
                catch
                {
                    this.Close();
                }
                this.Close();
                break;
            }
        }

    }
}
