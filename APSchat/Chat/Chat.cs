using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        SimpleTcpClient chat;

        private void Form1_Load(object sender, EventArgs e)
        {
            chat = new SimpleTcpClient();
            chat.StringEncoder = Encoding.UTF8;
            chat.DataReceived += ClientDataReceived;
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            btnConectar.Enabled = false;
            btnDesconectar.Enabled = true;
            chat.Connect(tbHost.Text, Convert.ToInt32(tbPort.Text));
        }

        private void tbHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPort_Click(object sender, EventArgs e)
        {

        }

        private void tbPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHost_Click(object sender, EventArgs e)
        {

        }


        private void ClientDataReceived(object sender, SimpleTCP.Message e)
        {
            tbDisplay.Invoke((MethodInvoker)delegate ()
            {
                tbDisplay.Text += e.MessageString;
            });
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            chat.WriteLineAndGetReply(tbMsg.Text, TimeSpan.FromSeconds(3));
        }
    }
}
