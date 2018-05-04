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
using System.IO;
using System.Threading;

namespace TILSerialCommunication
{
    public partial class TADSerialCommunication : Form
    {
        TcpClient tcpClient = new TcpClient();
        NetworkStream stream;
        string responsedata = null;

        bool isfirst = true;

        public TADSerialCommunication()
        {
            InitializeComponent();
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            if (sendmsg.TextLength > 0)
            {
                if (isfirst)
                {
                    try
                    {
                        tcpClient.Connect("192.168.1.103", 4001);
                        stream = tcpClient.GetStream();

                        byte[] data = Encoding.ASCII.GetBytes(sendmsg.Text);
                        stream.Write(data, 0, data.Length);
                        stream.Flush();

                        Thread thread = new Thread(getmessage);
                        thread.Start();
                        sendmsg.Text = "";
                        isfirst = false;
                    }
                    catch (System.Net.Sockets.SocketException)
                    {
                        TAD.Text = "COULD NOT CONNECT";
                        tcpClient.Close();
                    }
                }
                else
                {
                    byte[] data = Encoding.ASCII.GetBytes(sendmsg.Text);
                    stream.Write(data, 0, data.Length);
                    stream.Flush();
                    sendmsg.Text = "";
                }
            }
        }

        private void getmessage()
        {
            while(true)
            {
                stream = tcpClient.GetStream();
                Byte[] data = new Byte[16];
                stream.Read(data, 0, data.Length);
                string responseData = Encoding.ASCII.GetString(data);
                responsedata = "" + responseData;
                msg();
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                TAD.Text = TAD.Text + Environment.NewLine + ">>" + responsedata;
        }

        private void sendmsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                sendbutton_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tcpClient.Close();
            stream.Close();
            Close();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            TAD.Text = "";
        }
    }
}
