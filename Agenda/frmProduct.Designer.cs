namespace Agenda
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.pTitle = new System.Windows.Forms.Panel();
            this.labSaved = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labInformation = new System.Windows.Forms.Label();
            this.pInformation = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbxInactive = new System.Windows.Forms.CheckBox();
            this.labID = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tShowSaved = new System.Windows.Forms.Timer(this.components);
            this.pTitle.SuspendLayout();
            this.pInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.White;
            this.pTitle.Controls.Add(this.labSaved);
            this.pTitle.Controls.Add(this.btnNew);
            this.pTitle.Controls.Add(this.btnCancel);
            this.pTitle.Controls.Add(this.labInformation);
            this.pTitle.Controls.Add(this.pInformation);
            this.pTitle.Controls.Add(this.btnSave);
            this.pTitle.Location = new System.Drawing.Point(0, 50);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(600, 193);
            this.pTitle.TabIndex = 0;
            // 
            // labSaved
            // 
            this.labSaved.AutoSize = true;
            this.labSaved.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.labSaved.Location = new System.Drawing.Point(26, 143);
            this.labSaved.Name = "labSaved";
            this.labSaved.Size = new System.Drawing.Size(142, 24);
            this.labSaved.TabIndex = 13;
            this.labSaved.Text = "Registro salvo!";
            this.labSaved.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Roboto Bk", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(280, 140);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 30);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Roboto Bk", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(480, 140);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labInformation
            // 
            this.labInformation.AutoSize = true;
            this.labInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labInformation.Location = new System.Drawing.Point(30, 17);
            this.labInformation.Name = "labInformation";
            this.labInformation.Padding = new System.Windows.Forms.Padding(5);
            this.labInformation.Size = new System.Drawing.Size(64, 25);
            this.labInformation.TabIndex = 2;
            this.labInformation.Text = "Sistema";
            // 
            // pInformation
            // 
            this.pInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pInformation.Controls.Add(this.txtID);
            this.pInformation.Controls.Add(this.txtName);
            this.pInformation.Controls.Add(this.cbxInactive);
            this.pInformation.Controls.Add(this.labID);
            this.pInformation.Controls.Add(this.labName);
            this.pInformation.Location = new System.Drawing.Point(30, 35);
            this.pInformation.Name = "pInformation";
            this.pInformation.Size = new System.Drawing.Size(540, 83);
            this.pInformation.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(222, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(175, 23);
            this.txtID.TabIndex = 4;
            this.txtID.Text = "0";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 23);
            this.txtName.TabIndex = 3;
            // 
            // cbxInactive
            // 
            this.cbxInactive.AutoSize = true;
            this.cbxInactive.Location = new System.Drawing.Point(455, 10);
            this.cbxInactive.Name = "cbxInactive";
            this.cbxInactive.Size = new System.Drawing.Size(70, 19);
            this.cbxInactive.TabIndex = 2;
            this.cbxInactive.Text = "Inativar";
            this.cbxInactive.UseVisualStyleBackColor = true;
            this.cbxInactive.CheckedChanged += new System.EventHandler(this.cbxInactive_CheckedChanged);
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(219, 22);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(23, 15);
            this.labID.TabIndex = 1;
            this.labID.Text = "ID:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(12, 22);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(44, 15);
            this.labName.TabIndex = 0;
            this.labName.Text = "Nome:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Roboto Bk", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(380, 140);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(260, 14);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(80, 23);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Sistema";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(550, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tShowSaved
            // 
            this.tShowSaved.Interval = 2000;
            this.tShowSaved.Tick += new System.EventHandler(this.tShowSaved_Tick);
            // 
            // frmProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pTitle);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProduto_KeyDown);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.pInformation.ResumeLayout(false);
            this.pInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Panel pInformation;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labInformation;
        private System.Windows.Forms.CheckBox cbxInactive;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer tShowSaved;
        private System.Windows.Forms.Label labSaved;
    }
}