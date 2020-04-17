namespace Chat
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(704, 16);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(66, 20);
            this.tbPort.TabIndex = 7;
            this.tbPort.Text = "8910";
            this.tbPort.Visible = false;
            this.tbPort.TextChanged += new System.EventHandler(this.tbPort_TextChanged);
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(627, 16);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(60, 20);
            this.tbHost.TabIndex = 6;
            this.tbHost.Text = "127.0.0.1";
            this.tbHost.Visible = false;
            this.tbHost.TextChanged += new System.EventHandler(this.tbHost_TextChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConectar.Location = new System.Drawing.Point(604, 9);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(83, 32);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEnviar.Location = new System.Drawing.Point(662, 366);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(126, 72);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(17, 366);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(636, 71);
            this.tbMsg.TabIndex = 10;
            this.tbMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            // 
            // tbDisplay
            // 
            this.tbDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbDisplay.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplay.Location = new System.Drawing.Point(17, 70);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.Size = new System.Drawing.Size(771, 267);
            this.tbDisplay.TabIndex = 11;
            this.tbDisplay.TextChanged += new System.EventHandler(this.tbDisplay_TextChanged);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDesconectar.Location = new System.Drawing.Point(693, 9);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(77, 32);
            this.btnDesconectar.TabIndex = 12;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblID.Location = new System.Drawing.Point(12, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(156, 27);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "Seu nome:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(159, 21);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(107, 20);
            this.tbID.TabIndex = 14;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(515, 9);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(83, 32);
            this.btnConfig.TabIndex = 15;
            this.btnConfig.Text = "Configurar";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(653, 42);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbHost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chat";
            this.Text = "Chatter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnSalvar;
    }
}

