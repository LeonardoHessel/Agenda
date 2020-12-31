namespace Agenda
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pMenu = new System.Windows.Forms.Panel();
            this.pSlide = new System.Windows.Forms.Panel();
            this.btnHideMenu = new System.Windows.Forms.Button();
            this.labUserName = new System.Windows.Forms.Label();
            this.labWelcome = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnNewOS = new System.Windows.Forms.Button();
            this.pbLogoHome = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pForm = new System.Windows.Forms.Panel();
            this.labTime = new System.Windows.Forms.Label();
            this.tMoment = new System.Windows.Forms.Timer(this.components);
            this.pTitleBar = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pMenuButtons = new System.Windows.Forms.Panel();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHome)).BeginInit();
            this.pTitleBar.SuspendLayout();
            this.pMenuButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.pMenu.Controls.Add(this.pMenuButtons);
            this.pMenu.Controls.Add(this.labUserName);
            this.pMenu.Controls.Add(this.labWelcome);
            this.pMenu.Controls.Add(this.pbLogoHome);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.ForeColor = System.Drawing.Color.White;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(180, 1005);
            this.pMenu.TabIndex = 0;
            // 
            // pSlide
            // 
            this.pSlide.BackColor = System.Drawing.Color.Gainsboro;
            this.pSlide.Location = new System.Drawing.Point(3, 19);
            this.pSlide.Name = "pSlide";
            this.pSlide.Size = new System.Drawing.Size(8, 50);
            this.pSlide.TabIndex = 6;
            this.pSlide.Visible = false;
            // 
            // btnHideMenu
            // 
            this.btnHideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHideMenu.FlatAppearance.BorderSize = 0;
            this.btnHideMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.btnHideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideMenu.Font = new System.Drawing.Font("Roboto Bk", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideMenu.Image = global::Agenda.Properties.Resources.double_arrow_left_32px;
            this.btnHideMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHideMenu.Location = new System.Drawing.Point(0, 269);
            this.btnHideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnHideMenu.Name = "btnHideMenu";
            this.btnHideMenu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnHideMenu.Size = new System.Drawing.Size(180, 50);
            this.btnHideMenu.TabIndex = 9;
            this.btnHideMenu.UseVisualStyleBackColor = true;
            this.btnHideMenu.Click += new System.EventHandler(this.btnHideMenu_Click);
            // 
            // labUserName
            // 
            this.labUserName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(47, 944);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(87, 19);
            this.labUserName.TabIndex = 7;
            this.labUserName.Text = "User Name";
            this.labUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labWelcome
            // 
            this.labWelcome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labWelcome.AutoSize = true;
            this.labWelcome.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWelcome.Location = new System.Drawing.Point(46, 899);
            this.labWelcome.Name = "labWelcome";
            this.labWelcome.Size = new System.Drawing.Size(88, 19);
            this.labWelcome.TabIndex = 6;
            this.labWelcome.Text = "Bem vindo!";
            // 
            // btnProduct
            // 
            this.btnProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Roboto Bk", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 219);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.btnProduct.Size = new System.Drawing.Size(180, 50);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "Produtos";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Roboto Bk", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnSchedule.Image")));
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(0, 69);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.btnSchedule.Size = new System.Drawing.Size(180, 50);
            this.btnSchedule.TabIndex = 1;
            this.btnSchedule.Text = "Agenda";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Roboto Bk", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 169);
            this.btnUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.btnUser.Size = new System.Drawing.Size(180, 50);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Técnicos";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Roboto Bk", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 119);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.btnCustomer.Size = new System.Drawing.Size(180, 50);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Clientes";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnNewOS
            // 
            this.btnNewOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewOS.FlatAppearance.BorderSize = 0;
            this.btnNewOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.btnNewOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOS.Font = new System.Drawing.Font("Roboto Bk", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOS.Image = ((System.Drawing.Image)(resources.GetObject("btnNewOS.Image")));
            this.btnNewOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewOS.Location = new System.Drawing.Point(0, 19);
            this.btnNewOS.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewOS.Name = "btnNewOS";
            this.btnNewOS.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.btnNewOS.Size = new System.Drawing.Size(180, 50);
            this.btnNewOS.TabIndex = 0;
            this.btnNewOS.Text = "Nova OS";
            this.btnNewOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewOS.UseVisualStyleBackColor = true;
            this.btnNewOS.Click += new System.EventHandler(this.btnNewOS_Click);
            // 
            // pbLogoHome
            // 
            this.pbLogoHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.pbLogoHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogoHome.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoHome.Image")));
            this.pbLogoHome.Location = new System.Drawing.Point(0, 0);
            this.pbLogoHome.Name = "pbLogoHome";
            this.pbLogoHome.Size = new System.Drawing.Size(180, 180);
            this.pbLogoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoHome.TabIndex = 0;
            this.pbLogoHome.TabStop = false;
            this.pbLogoHome.Click += new System.EventHandler(this.pbLogoHome_Click);
            this.pbLogoHome.Resize += new System.EventHandler(this.pbLogoHome_Resize);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Roboto Bk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1049, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Roboto Bk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(999, 1);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 40);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Roboto Bk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(949, 1);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 40);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pForm
            // 
            this.pForm.BackColor = System.Drawing.Color.White;
            this.pForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pForm.BackgroundImage")));
            this.pForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pForm.Location = new System.Drawing.Point(180, 42);
            this.pForm.Name = "pForm";
            this.pForm.Size = new System.Drawing.Size(1100, 963);
            this.pForm.TabIndex = 1;
            // 
            // labTime
            // 
            this.labTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.ForeColor = System.Drawing.Color.White;
            this.labTime.Location = new System.Drawing.Point(822, 9);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(96, 25);
            this.labTime.TabIndex = 5;
            this.labTime.Text = "00:00:00";
            // 
            // tMoment
            // 
            this.tMoment.Enabled = true;
            this.tMoment.Interval = 1000;
            this.tMoment.Tick += new System.EventHandler(this.tMoment_Tick);
            // 
            // pTitleBar
            // 
            this.pTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.pTitleBar.Controls.Add(this.btnReturn);
            this.pTitleBar.Controls.Add(this.labTime);
            this.pTitleBar.Controls.Add(this.btnLogout);
            this.pTitleBar.Controls.Add(this.btnClose);
            this.pTitleBar.Controls.Add(this.btnMinimize);
            this.pTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleBar.Location = new System.Drawing.Point(180, 0);
            this.pTitleBar.Name = "pTitleBar";
            this.pTitleBar.Size = new System.Drawing.Size(1100, 42);
            this.pTitleBar.TabIndex = 3;
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Roboto Bk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(0, 1);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(50, 40);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pMenuButtons
            // 
            this.pMenuButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMenuButtons.Controls.Add(this.pSlide);
            this.pMenuButtons.Controls.Add(this.btnHideMenu);
            this.pMenuButtons.Controls.Add(this.btnNewOS);
            this.pMenuButtons.Controls.Add(this.btnCustomer);
            this.pMenuButtons.Controls.Add(this.btnUser);
            this.pMenuButtons.Controls.Add(this.btnSchedule);
            this.pMenuButtons.Controls.Add(this.btnProduct);
            this.pMenuButtons.Location = new System.Drawing.Point(0, 180);
            this.pMenuButtons.Name = "pMenuButtons";
            this.pMenuButtons.Size = new System.Drawing.Size(180, 361);
            this.pMenuButtons.TabIndex = 10;
            // 
            // frmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 1005);
            this.Controls.Add(this.pForm);
            this.Controls.Add(this.pTitleBar);
            this.Controls.Add(this.pMenu);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHome_KeyDown);
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHome)).EndInit();
            this.pTitleBar.ResumeLayout(false);
            this.pTitleBar.PerformLayout();
            this.pMenuButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.PictureBox pbLogoHome;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnNewOS;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labWelcome;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pForm;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Timer tMoment;
        private System.Windows.Forms.Panel pTitleBar;
        private System.Windows.Forms.Button btnHideMenu;
        private System.Windows.Forms.Panel pSlide;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pMenuButtons;
    }
}