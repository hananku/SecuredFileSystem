using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static Common.Enumerations;

namespace SecureFileSystemClient
{
    public partial class ClientAuthentication : Form
    {
        private string _username;
        private string _password;
        private UserActions _action;
        private TcpClient _tcpClient;
        private byte[] actionData;
        private byte[] usernameData;
        private byte[] passwordData;
        private NetworkStream stream;
        private bool _autenticated;

        public ClientAuthentication(TcpClient tcpClient)
        {
            InitializeComponent();
            _tcpClient = tcpClient;
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                stream = _tcpClient.GetStream();
                _username = txtUsername.Text;
                _password = txtxPassword.Text;
                usernameData = Encoding.ASCII.GetBytes(_username);
                passwordData = Encoding.ASCII.GetBytes(_password);
                actionData = Encoding.ASCII.GetBytes("login");
                stream.Write(usernameData, 0, Encoding.ASCII.GetByteCount(_username));



                if (_autenticated)
                {
                    FSClient fsClient = new FSClient(_tcpClient);
                    fsClient.Activate();
                    Close();
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            try
            {
                stream = _tcpClient.GetStream();
                _username = txtUsername.Text;
                _password = txtxPassword.Text;
                usernameData = Encoding.ASCII.GetBytes(_username);
                passwordData = Encoding.ASCII.GetBytes(_password);
                actionData = Encoding.ASCII.GetBytes("register");
                stream.Write(usernameData, 0, Encoding.ASCII.GetByteCount(_username));
                //stream.
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
