using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSocketClient
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        //定义回调
        private delegate void SetTextCallBack(string strValue);
        //声明 
        private SetTextCallBack setCallBack;

        //定义接受服务端发送消息的回调
        private delegate void ReceiveMsgCallBack(string strMsg);
        //声明
        private ReceiveMsgCallBack receiveCallBack;

        //创建连接的Socket
        Socket socketSend;
        //创建接受服务器发送消息的线程
        Thread threadRecevie;

        /// <summary>
        ///  开始连接到服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(txtIP.Text.Trim());
                socketSend.Connect(ip, Convert.ToInt32(txtPort.Text.Trim()));
                //实例化回调
                setCallBack = new SetTextCallBack(SetValue);
                receiveCallBack = new ReceiveMsgCallBack(SetValue);
                txtLog.Invoke(setCallBack, "连接成功~");
                //开启一个新的线程不停的接收服务器发送消息的线程
                threadRecevie = new Thread(new ThreadStart(Receive));
                threadRecevie.IsBackground = true;
                threadRecevie.Start();
            }
            catch(Exception ex)
            {
                txtLog.AppendText("连接服务端出错:" + ex.ToString()+DateTime.Now + "\r\n");
            }
        }

        /*init start..*/
        private void SetValue(string strValue)
        {
            txtLog.AppendText(strValue + "\r\n");
        }
        /*init finished..*/

        private void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[2 * 1024];
                    //实际接收的字节数
                    int len = socketSend.Receive(buffer);
                    if (len == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (buffer[0] == 0) // 0 - 文字消息
                        {
                            //从第二位开始读取数据，第一位是标识位
                            string msg = Encoding.Default.GetString(buffer, 1, len-1);
                            txtLog.Invoke(receiveCallBack, "接收远程服务器:" + socketSend.RemoteEndPoint + " 发送的消息:" + msg+" "+DateTime.Now);
                        }
                        if (buffer[0] == 1) // 1 - 发送的文件
                        {
                            txtLog.Invoke(receiveCallBack, "成功接收远程服务器:" + socketSend.RemoteEndPoint + " 发送文件~"+DateTime.Now);
                            SaveFileDialog dialog = new SaveFileDialog();//保持文件的会话框
                            dialog.InitialDirectory = @"";
                            dialog.Title = "请选择要保持的文件";
                            dialog.Filter = "所有文件|*.*";
                            dialog.ShowDialog(this);
                            string path = dialog.FileName;
                            using(FileStream fs=new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                            {
                                fs.Write(buffer, 1, len - 1);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                txtLog.AppendText("接收服务端发送的消息出错:" + ex.ToString()+DateTime.Now +"\r\n");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //关闭socket
            socketSend.Close();
            //停止线程
            threadRecevie.Abort();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        ///  客户端给服务端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsg = txtMsg.Text.Trim();
                txtLog.AppendText(strMsg + DateTime.Now +"\r\n");
                txtMsg.Text = "";
                byte[] buffer = new byte[2 * 1024];
                buffer = Encoding.Default.GetBytes(strMsg);
                int receive=socketSend.Send(buffer);
            }
            catch(Exception ex)
            {
                txtLog.AppendText("发送消息出错:" + DateTime.Now + ex.Message + "\n\r" );
            }
        }
    }
}
