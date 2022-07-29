using System;
using System.Windows.Forms;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Configuration;
using System.Collections.Specialized;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        string IP = ConfigurationManager.AppSettings.Get("serverIP");
        int port = Int32.Parse(ConfigurationManager.AppSettings.Get("serverPort"));
        TcpClient client = new TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            // Connect to chat server on button click
            readData = "Connecting to Chat Server...";
            msg();
            client.Connect(IP, port);
            serverStream = client.GetStream();
            
            byte[] outStream = Encoding.ASCII.GetBytes(tbUsername.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            Thread ctThread = new Thread(getMessage);

            ctThread.Start();
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            // Sends message to chat server on click
            byte[] outStream = Encoding.ASCII.GetBytes(tbUserMsg.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            tbUserMsg.Text = "";
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {        
            client.Close();
            serverStream.Close();
            client.Dispose();
            serverStream.Dispose();

            System.Windows.Forms.Application.Exit();
        }

        private void getMessage()
        {
            while (true)
            {
                serverStream = client.GetStream();
                byte[] inStream = new byte[10025];
                serverStream.Read(inStream, 0, inStream.Length);
                string returnData = Encoding.ASCII.GetString(inStream);
                readData = "" + returnData;
                msg();
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                tbChat.Text = tbChat.Text + Environment.NewLine + " >> " + readData;
        }

        private void tbUserMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUserMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bSend_Click(sender, e);
            }
        }
    }
}