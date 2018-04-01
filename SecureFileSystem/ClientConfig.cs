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

namespace SecureFileSystemClient
{
    public partial class ClientConfig : Form
    {
        private IPAddress _ipAddress;
        private int _port;
        private TcpClient _tcpClient;

        public ClientConfig()
        {
            InitializeComponent();
            _tcpClient = new TcpClient();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _ipAddress = IPAddress.Parse(txtServerIp.Text);
                _port = int.Parse(txtPort.Text);
                _tcpClient.Connect(_ipAddress, _port);
                ClientAuthentication clientForm = new ClientAuthentication(_tcpClient);
                clientForm.Activate();
                Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
