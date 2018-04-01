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

namespace SecureFileSystemClient
{
    public partial class FSClient : Form
    {
        private TcpClient _tcpClient;

        public FSClient(TcpClient tcpClient)
        {
            InitializeComponent();
            FSClientStart(tcpClient);
        }

        private void FSClientStart(TcpClient tcpClient)
        {
            _tcpClient = tcpClient;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
