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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pMenu = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnNewOS = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.labWelcome = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.pMenu.Controls.Add(this.labUserName);
            this.pMenu.Controls.Add(this.labWelcome);
            this.pMenu.Controls.Add(this.btnProduct);
            this.pMenu.Controls.Add(this.btnSchedule);
            this.pMenu.Controls.Add(this.btnUser);
            this.pMenu.Controls.Add(this.btnCustomer);
            this.pMenu.Controls.Add(this.btnNewOS);
            this.pMenu.Controls.Add(this.pbLogo);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.ForeColor = System.Drawing.Color.White;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(180, 1024);
            this.pMenu.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(180, 180);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnNewOS
            // 
            this.btnNewOS.FlatAppearance.BorderSize = 0;
            this.btnNewOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOS.Font = new System.Drawing.Font("Roboto Bk", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOS.Image = ((System.Drawing.Image)(resources.GetObject("btnNewOS.Image")));
            this.btnNewOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewOS.Location = new System.Drawing.Point(0, 350);
            this.btnNewOS.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewOS.Name = "btnNewOS";
            this.btnNewOS.Size = new System.Drawing.Size(180, 50);
            this.btnNewOS.TabIndex = 1;
            this.btnNewOS.Text = "Novo OS";
            this.btnNewOS.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Roboto Bk", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 410);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(180, 50);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Clientes";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Roboto Bk", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnSchedule.Image")));
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(0, 470);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(180, 50);
            this.btnSchedule.TabIndex = 3;
            this.btnSchedule.Text = "Agenda";
            this.btnSchedule.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Roboto Bk", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 530);
            this.btnUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(180, 50);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "Técnicos";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Roboto Bk", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 590);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(180, 50);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "Produtos";
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // labWelcome
            // 
            this.labWelcome.AutoSize = true;
            this.labWelcome.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWelcome.Location = new System.Drawing.Point(46, 899);
            this.labWelcome.Name = "labWelcome";
            this.labWelcome.Size = new System.Drawing.Size(88, 19);
            this.labWelcome.TabIndex = 6;
            this.labWelcome.Text = "Bem vindo!";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(47, 944);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(87, 19);
            this.labUserName.TabIndex = 7;
            this.labUserName.Text = "User Name";
            this.labUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Roboto Bk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(1150, 40);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 60);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Sair";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Roboto Bk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1075, 40);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 60);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "Minimizar";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Roboto Bk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(1000, 40);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 60);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pMenu);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.PictureBox pbLogo;
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
    }
}