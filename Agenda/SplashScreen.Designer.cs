namespace Agenda
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labLicensedFor = new System.Windows.Forms.Label();
            this.labLicenseNumber = new System.Windows.Forms.Label();
            this.labLicense = new System.Windows.Forms.Label();
            this.labCompanyName = new System.Windows.Forms.Label();
            this.labInfo = new System.Windows.Forms.Label();
            this.tToClose = new System.Windows.Forms.Timer(this.components);
            this.labShortcut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pLogo
            // 
            this.pLogo.Image = ((System.Drawing.Image)(resources.GetObject("pLogo.Image")));
            this.pLogo.Location = new System.Drawing.Point(645, 283);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(100, 100);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLogo.TabIndex = 0;
            this.pLogo.TabStop = false;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(50, 42);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(165, 24);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Ordem de Serviço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ordem de Serviço";
            // 
            // labLicensedFor
            // 
            this.labLicensedFor.AutoSize = true;
            this.labLicensedFor.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLicensedFor.Location = new System.Drawing.Point(50, 91);
            this.labLicensedFor.Name = "labLicensedFor";
            this.labLicensedFor.Size = new System.Drawing.Size(113, 17);
            this.labLicensedFor.TabIndex = 3;
            this.labLicensedFor.Text = "Licenciado para:";
            // 
            // labLicenseNumber
            // 
            this.labLicenseNumber.AutoSize = true;
            this.labLicenseNumber.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLicenseNumber.Location = new System.Drawing.Point(50, 120);
            this.labLicenseNumber.Name = "labLicenseNumber";
            this.labLicenseNumber.Size = new System.Drawing.Size(61, 17);
            this.labLicenseNumber.TabIndex = 4;
            this.labLicenseNumber.Text = "Licença:";
            // 
            // labLicense
            // 
            this.labLicense.AutoSize = true;
            this.labLicense.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLicense.Location = new System.Drawing.Point(176, 120);
            this.labLicense.Name = "labLicense";
            this.labLicense.Size = new System.Drawing.Size(104, 17);
            this.labLicense.TabIndex = 6;
            this.labLicense.Text = "123456789123";
            // 
            // labCompanyName
            // 
            this.labCompanyName.AutoSize = true;
            this.labCompanyName.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCompanyName.Location = new System.Drawing.Point(176, 91);
            this.labCompanyName.Name = "labCompanyName";
            this.labCompanyName.Size = new System.Drawing.Size(88, 17);
            this.labCompanyName.TabIndex = 5;
            this.labCompanyName.Text = "DR Sistemas";
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInfo.Location = new System.Drawing.Point(50, 353);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(216, 17);
            this.labInfo.TabIndex = 7;
            this.labInfo.Text = "Conectando com banco de dados";
            // 
            // tToClose
            // 
            this.tToClose.Enabled = true;
            this.tToClose.Interval = 400;
            this.tToClose.Tick += new System.EventHandler(this.tToClose_Tick);
            // 
            // labShortcut
            // 
            this.labShortcut.AutoSize = true;
            this.labShortcut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(184)))));
            this.labShortcut.Location = new System.Drawing.Point(670, 383);
            this.labShortcut.Name = "labShortcut";
            this.labShortcut.Size = new System.Drawing.Size(128, 15);
            this.labShortcut.TabIndex = 8;
            this.labShortcut.Text = "Configurações ( F12 )";
            // 
            // SplashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.labShortcut);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.labLicense);
            this.Controls.Add(this.labCompanyName);
            this.Controls.Add(this.labLicenseNumber);
            this.Controls.Add(this.labLicensedFor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.pLogo);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SplashScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labLicensedFor;
        private System.Windows.Forms.Label labLicenseNumber;
        private System.Windows.Forms.Label labLicense;
        private System.Windows.Forms.Label labCompanyName;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.Timer tToClose;
        private System.Windows.Forms.Label labShortcut;
    }
}