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

namespace SecureFileSystemServer
{
    public partial class FSServer : Form
    {
        private TcpListener _tcpListener;

        public FSServer()
        {
            InitializeComponent();
            // verify passwords file exists
            // listen to client connections
            FSServerStart();
            // when client connects: check password
            // listen to clients actions and handle them
        }

        private void FSServerStart()
        {
            _tcpListener = new TcpListener(IPAddress.Any, 49151);
            var listeningThread = new Thread(new System.Threading.ThreadStart(ListenToClients));
            listeningThread.Start();
        }

        private void ListenToClients()
        {
            _tcpListener.Start();
            while (true)
            {
                TcpClient client = _tcpListener.AcceptTcpClient();
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientCommunication));
                clientThread.Start(client);
            }
        }

        private void HandleClientCommunication(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            byte[] message = new byte[4096];
            int bytesRead;
            while (true)
            {
                bytesRead = 0;
                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                    if(bytesRead == 4096)
                    {
                        
                    }
                }
                catch
                {
                    // TODO
                    break;
                }
                if (bytesRead == 0)
                {
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
