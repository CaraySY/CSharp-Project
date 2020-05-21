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

namespace NetSocket
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        //定义回调：解决跨越线程访问问题
        private delegate void SetTextValueCallBack(string strValue);
        //定义接受客户端发送消息的回调
        private delegate void ReceiveMsgCallBack(string strReceive);
        //声明回调
        private SetTextValueCallBack setCallBack;
        private ReceiveMsgCallBack receiveCallBack;

        //定义回调：给ComboBox控件添加元素
        private delegate void SetCmbCallBack(string strItem);
        //声明
        private SetCmbCallBack setCmbCallBack;

        //定义发送文件的回调
        private delegate void SendFileCallBack(byte[] bf);
        //声明
        private SendFileCallBack sendCallBack;

        //用于通信的Socket
        private Socket socketSend;
        //用于监听的Socket
        private Socket socketWatch;

        // 将远程连接的客户端IP地址和Socket放入字典中
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        //创建监听的线程
        Thread acceptSocketThread;
        //接受客户端发送消息的线程
        Thread threadReceive;

        /// <summary>
        ///  开始监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //点击开始监听的时候，在在服务器端创建一个负责监听IP地址和端口号的Socket
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //获取IP地址
            IPAddress ip = IPAddress.Parse(txtIP.Text.Trim());
            //创建端口号
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text.Trim()));
            //监听的Socket绑定IP地址和端口号
            socketWatch.Bind(point);
            txtLog.AppendText("监听成功~" +DateTime.Now+"\r\n");
            //开始监听：同时设置最大可以同时连接多少个请求
            socketWatch.Listen(10);
            //实例化回调函数
            setCallBack = new SetTextValueCallBack(SetTextValue);
            receiveCallBack = new ReceiveMsgCallBack(ReceiveMsg);
            setCmbCallBack = new SetCmbCallBack(AddCmbItem);
            sendCallBack = new SendFileCallBack(SendFile);
            //创建监听线程
            acceptSocketThread = new Thread(new ParameterizedThreadStart(StartListen));
            acceptSocketThread.IsBackground = true;//设置为后台线程
            acceptSocketThread.Start(socketWatch); //启动线程
        }

        /*start init...delegate...UI控件无法被其他线程使用，只能使用GUI线程，但是控件可以使用委托执行非GUI线程指定的操作*/
        private void SendFile(byte[] bf)
        {
            try
            {
                dicSocket[cmbSocket.SelectedItem.ToString()].Send(bf, SocketFlags.None); //开始发送文件
            }
            catch(Exception ex)
            {
                txtLog.AppendText("发送文件出错！！！->"+DateTime.Now+ex.Message+"\r\n");
            }
        }

        private void AddCmbItem(string strItem)
        {
            cmbSocket.Items.Add(strItem); //添加到ComboBox控件项中
            Action action = () =>
            {
                cmbSocket.SelectedItem = strItem;
            };
            cmbSocket.Invoke(action);
        }

        private void ReceiveMsg(string strMsg)
        {
            txtLog.AppendText(strMsg + DateTime.Now+"\r\n");
        }

        private void SetTextValue(string strValue)
        {
            txtLog.AppendText(strValue + DateTime.Now+"\r\n");
        }
        /*end init...delegate...*/
        private void StartListen(object obj)
        {
            //获取监听Socket
            Socket socketWatch = obj as Socket;
            while (true)
            {
                //等待客户端的连接，并创建一个用于通信的Socket
                socketSend = socketWatch.Accept();
                //获取远程主机的IP和端口号
                string strIP = socketSend.RemoteEndPoint.ToString();
                //将远程IP和发送Socket保存到字典
                dicSocket.Add(strIP, socketSend);
                //使用委托为ComboBox控件回显远程主机的IP地址
                cmbSocket.Invoke(setCmbCallBack, strIP);
                string strMsg = "远程主机：" + socketSend.RemoteEndPoint + " 连接成功~";
                //使用回调显示到日志文本框
                txtLog.Invoke(setCallBack, strMsg);
                //定义接收客户端消息的线程
                threadReceive = new Thread(new ParameterizedThreadStart(Receive));
                threadReceive.IsBackground = true;
                //发送消息
                threadReceive.Start(socketSend);
            }
        }

        /// <summary>
        ///  用于接收远程主机发送的消息
        /// </summary>
        /// <param name="obj"></param>
        private void Receive(object obj)
        {
            Socket socketSend=obj as Socket;
            while (true)
            {
                //客户端连接成功，服务器接受发送的消息
                byte[] buffer = new byte[2 * 1024];
                //实际接收的有效字节数
                int count = socketSend.Receive(buffer);
                if (count == 0)
                {
                    break;
                }
                else
                {
                    string str = Encoding.Default.GetString(buffer, 0, count);
                    string strRecvMsg = "接收:" + socketSend.RemoteEndPoint + " 发送的消息：" + str;
                    txtLog.Invoke(receiveCallBack, strRecvMsg);
                }
            }
        }

        /// <summary>
        ///  给客户端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMsg_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsg = txtMsg.Text.Trim();
                txtLog.AppendText(strMsg + DateTime.Now + "\r\n");
                //清空文本框
                txtMsg.Text = "";
                byte[] buffer = Encoding.Default.GetBytes(strMsg);
                List<byte> list = new List<byte>();
                list.Add(0);
                list.AddRange(buffer);
                //将集合转为数组
                byte[] newBuffer = list.ToArray();
                //获取ComboBox选择的IP
                string ip = cmbSocket.SelectedItem.ToString();
                //开始发送消息
                dicSocket[ip].Send(newBuffer);
            }
            catch(Exception ex)
            {
                txtLog.AppendText("发送消息出错！！！->" + ex.Message +" "+DateTime.Now+"\r\n");
            }
        }

        /// <summary>
        ///  选择要发送的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //创建一个文件选择器对象
            OpenFileDialog dialog = new OpenFileDialog();
            //设置初始目录
            dialog.InitialDirectory = @"";
            //过滤文件的类型
            dialog.Filter = "所有文件|*.*";
            //显示文件选择器
            dialog.ShowDialog();
            //将路径保持到到txtBox
            txtFilePath.Text = dialog.FileName;
        }

        /// <summary>
        ///  发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            List<byte> list = new List<byte>();
            //获取要发送的文件路径
            string path = txtFilePath.Text.Trim();
            //读取文件
            using(FileStream fs=new FileStream(path,FileMode.Open,FileAccess.Read))
            {
                byte[] buffer = new byte[2 * 1024];
                int r = fs.Read(buffer, 0, buffer.Length);
                list.Add(1);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();
                //开始发送文件
                btnSendFile.Invoke(sendCallBack, newBuffer);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //关闭Socket
            socketSend.Close();
            socketWatch.Close();
            //终止线程
            acceptSocketThread.Abort();
            threadReceive.Abort();
        }
    }
}
