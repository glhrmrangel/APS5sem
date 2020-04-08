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

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus1.Invoke((MethodInvoker)delegate ()
            {
                txtStatus1.Text += e.MessageString;
                e.ReplyLine(string.Format("Você disse: {0} \r\n", e.MessageString));
            });
        }

        private void btnInicial_Click(object sender, EventArgs e)
        {
            btnFim.Enabled = true;

            txtStatus1.Text = "Iniciando Conexão";

            System.Net.IPAddress ip = System.Net.IPAddress.Parse(tbHost.Text);
            servidor.Start(ip, Convert.ToInt32(tbPort.Text));

            txtStatus1.Text = "Iniciando Conexão";
            if (servidor.IsStarted)
                txtStatus1.Text = "Conexão bem sucedida \r\n";
            else
            {
                txtStatus1.Text = "Falha na conexão! \r\n";
                throw new System.ArgumentException("Problema no início da conexão, verifique as variáveis e tente novamente");
            }
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            if (servidor.IsStarted)
                servidor.Stop();
        }

        private void Servidor_Load_1(object sender, EventArgs e)
        {
            servidor = new SimpleTcpServer();
            servidor.Delimiter = 0x13; // o problema do [] tá aqui
            servidor.StringEncoder = Encoding.UTF8;
            servidor.DataReceived += Server_DataReceived;
        }
    }
}
