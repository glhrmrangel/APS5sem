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

namespace APSchat
{
    public partial class Servidor : Form
    {
        public Servidor()
        {
            InitializeComponent();
        }

        SimpleTcpServer servidor;

        private void Servidor_Load(object sender, EventArgs e)
        {
            servidor = new SimpleTcpServer();
            servidor.Delimiter = 0x13;
            servidor.StringEncoder = Encoding.UTF8;
            servidor.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus1.Invoke((MethodInvoker)delegate ()
            {
                txtStatus1.Text += e.MessageString;
                e.ReplyLine(string.Format("You said: {0}", e.MessageString));
            });
        }

        private void btnInicial_Click(object sender, EventArgs e)
        {
            btnFim.Enabled = true;

            txtStatus1.Text = "Iniciando Conexão";
            if (servidor.IsStarted)

                txtStatus1.Text = "Conexão bem sucedida";
            else
            {
                txtStatus1.Text = "Falha na conexão!";
                throw new System.ArgumentException("Problema no início da conexão, verifique as variáveis e tente novamente");
            }

            System.Net.IPAddress ip = new System.Net.IPAddress(long.Parse(tbHost.Text));
            servidor.Start(ip, Convert.ToInt32(tbPort.Text));
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            if (servidor.IsStarted)
                servidor.Stop();
        }
    }
}
