namespace Agenda
{
    partial class frmDBConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBConfig));
            this.pForm = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pConfig = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.labUser = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.labDatabase = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.labPort = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.labServer = new System.Windows.Forms.Label();
            this.pbDBLogo = new System.Windows.Forms.PictureBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pForm.SuspendLayout();
            this.pConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pForm
            // 
            this.pForm.BackColor = System.Drawing.Color.White;
            this.pForm.Controls.Add(this.btnSave);
            this.pForm.Controls.Add(this.pConfig);
            this.pForm.Controls.Add(this.pbDBLogo);
            this.pForm.Location = new System.Drawing.Point(0, 40);
            this.pForm.Name = "pForm";
            this.pForm.Size = new System.Drawing.Size(400, 420);
            this.pForm.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(91, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(218, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pConfig
            // 
            this.pConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pConfig.Controls.Add(this.txtPassword);
            this.pConfig.Controls.Add(this.labPassword);
            this.pConfig.Controls.Add(this.txtUser);
            this.pConfig.Controls.Add(this.labUser);
            this.pConfig.Controls.Add(this.txtDatabase);
            this.pConfig.Controls.Add(this.labDatabase);
            this.pConfig.Controls.Add(this.txtPort);
            this.pConfig.Controls.Add(this.labPort);
            this.pConfig.Controls.Add(this.txtServer);
            this.pConfig.Controls.Add(this.labServer);
            this.pConfig.Location = new System.Drawing.Point(36, 114);
            this.pConfig.Name = "pConfig";
            this.pConfig.Size = new System.Drawing.Size(328, 267);
            this.pConfig.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(22, 214);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(284, 23);
            this.txtPassword.TabIndex = 9;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.labPassword.Location = new System.Drawing.Point(19, 195);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(46, 15);
            this.labPassword.TabIndex = 8;
            this.labPassword.Text = "Senha:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(22, 169);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(284, 23);
            this.txtUser.TabIndex = 7;
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.labUser.Location = new System.Drawing.Point(19, 150);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(55, 15);
            this.labUser.TabIndex = 6;
            this.labUser.Text = "Usuário:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(22, 124);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(284, 23);
            this.txtDatabase.TabIndex = 5;
            // 
            // labDatabase
            // 
            this.labDatabase.AutoSize = true;
            this.labDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.labDatabase.Location = new System.Drawing.Point(19, 105);
            this.labDatabase.Name = "labDatabase";
            this.labDatabase.Size = new System.Drawing.Size(103, 15);
            this.labDatabase.TabIndex = 4;
            this.labDatabase.Text = "Banco de Dados:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(22, 79);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(284, 23);
            this.txtPort.TabIndex = 3;
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.labPort.Location = new System.Drawing.Point(19, 60);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(41, 15);
            this.labPort.TabIndex = 2;
            this.labPort.Text = "Porta:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(22, 34);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(284, 23);
            this.txtServer.TabIndex = 1;
            // 
            // labServer
            // 
            this.labServer.AutoSize = true;
            this.labServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.labServer.Location = new System.Drawing.Point(19, 15);
            this.labServer.Name = "labServer";
            this.labServer.Size = new System.Drawing.Size(59, 15);
            this.labServer.TabIndex = 0;
            this.labServer.Text = "Servidor:";
            // 
            // pbDBLogo
            // 
            this.pbDBLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbDBLogo.Image")));
            this.pbDBLogo.Location = new System.Drawing.Point(168, 34);
            this.pbDBLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbDBLogo.Name = "pbDBLogo";
            this.pbDBLogo.Size = new System.Drawing.Size(64, 64);
            this.pbDBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDBLogo.TabIndex = 0;
            this.pbDBLogo.TabStop = false;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Roboto Bk", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(124, 7);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(153, 27);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Configurações";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(360, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDBConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.pForm);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDBConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração";
            this.pForm.ResumeLayout(false);
            this.pConfig.ResumeLayout(false);
            this.pConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDBLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pForm;
        private System.Windows.Forms.PictureBox pbDBLogo;
        private System.Windows.Forms.Panel pConfig;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label labDatabase;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label labServer;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnClose;
    }
}