using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            tbDisplay.ScrollBars = ScrollBars.Vertical;
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
            try
            {
                chat.Connect(tbHost.Text, Convert.ToInt32(tbPort.Text));           
                tbDisplay.Text += "Conexão Realizada \r\n";
            }
            catch(System.Net.Sockets.SocketException exception)
            {
                tbDisplay.Text += "Conexão não disponível \r\n";
                chat.Dispose();
            }
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
            try
            { 
            tbDisplay.Invoke((MethodInvoker)delegate ()
            {
                String msg = e.MessageString.Replace("\u0013", "");
                tbDisplay.Text += msg;
            });
            }
            catch
            {
                tbDisplay.Text += "ERRO: Não foi possível receber os dados do servidor";
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
            chat.WriteLineAndGetReply(tbID.Text + " disse: " + tbMsg.Text, TimeSpan.FromSeconds(0));
                tbMsg.Text = "";
            }
            catch (System.Net.Sockets.SocketException exception)
            {
                tbDisplay.Text += "Conexão não disponível \r\n Mensagem de erro: {0}" + exception;
                chat.Dispose();
            }
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            btnConectar.Visible = false;
            btnDesconectar.Visible = false;
            tbHost.Visible = true;
            btnSalvar.Visible = true;
            tbPort.Visible = true;
            btnSalvar.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tbHost.Visible = false;
            btnSalvar.Visible = false;
            tbPort.Visible = false;
            btnConectar.Visible = true;
            btnDesconectar.Visible = true;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            chat.Disconnect();
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
        }
    }
}
