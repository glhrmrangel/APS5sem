namespace APSchat
{
    partial class Servidor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servidor));
            this.btnInicial = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.btnFim = new System.Windows.Forms.Button();
            this.txtStatus1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInicial
            // 
            this.btnInicial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInicial.Location = new System.Drawing.Point(53, 131);
            this.btnInicial.Name = "btnInicial";
            this.btnInicial.Size = new System.Drawing.Size(104, 40);
            this.btnInicial.TabIndex = 13;
            this.btnInicial.Text = "Iniciar";
            this.btnInicial.UseVisualStyleBackColor = true;
            this.btnInicial.Click += new System.EventHandler(this.btnInicial_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(128, 86);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(154, 20);
            this.tbPort.TabIndex = 12;
            this.tbPort.Text = "8910";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(128, 28);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(154, 20);
            this.tbHost.TabIndex = 11;
            this.tbHost.Text = "127.0.0.1";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPort.Location = new System.Drawing.Point(12, 79);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(92, 27);
            this.lblPort.TabIndex = 10;
            this.lblPort.Text = "Port:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHost.Location = new System.Drawing.Point(12, 21);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(92, 27);
            this.lblHost.TabIndex = 9;
            this.lblHost.Text = "Host:";
            // 
            // btnFim
            // 
            this.btnFim.Enabled = false;
            this.btnFim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFim.Location = new System.Drawing.Point(200, 131);
            this.btnFim.Name = "btnFim";
            this.btnFim.Size = new System.Drawing.Size(104, 40);
            this.btnFim.TabIndex = 14;
            this.btnFim.Text = "Finalizar";
            this.btnFim.UseVisualStyleBackColor = true;
            this.btnFim.Click += new System.EventHandler(this.btnFim_Click);
            // 
            // txtStatus1
            // 
            this.txtStatus1.Location = new System.Drawing.Point(17, 188);
            this.txtStatus1.Multiline = true;
            this.txtStatus1.Name = "txtStatus1";
            this.txtStatus1.ReadOnly = true;
            this.txtStatus1.Size = new System.Drawing.Size(323, 316);
            this.txtStatus1.TabIndex = 15;
            // 
            // Servidor
            // 
            this.ClientSize = new System.Drawing.Size(352, 519);
            this.Controls.Add(this.txtStatus1);
            this.Controls.Add(this.btnFim);
            this.Controls.Add(this.btnInicial);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblHost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Servidor";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.Servidor_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnInicial;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Button btnFim;
        private System.Windows.Forms.TextBox txtStatus1;
    }
}

