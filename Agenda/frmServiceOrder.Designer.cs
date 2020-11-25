namespace Agenda
{
    partial class frmServiceOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceOrder));
            this.pForm = new System.Windows.Forms.Panel();
            this.labSaved = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labTabInfo = new System.Windows.Forms.Label();
            this.pTabInfo = new System.Windows.Forms.Panel();
            this.txtCustomerCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbServiceOrderInactive = new System.Windows.Forms.CheckBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.dtpServiceEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpServiceCreationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpServiceStartDate = new System.Windows.Forms.DateTimePicker();
            this.labServiceEndDate = new System.Windows.Forms.Label();
            this.cbServiceMode = new System.Windows.Forms.ComboBox();
            this.labServiceMode = new System.Windows.Forms.Label();
            this.labServiceStartDate = new System.Windows.Forms.Label();
            this.labServiceCreationDate = new System.Windows.Forms.Label();
            this.labStatus = new System.Windows.Forms.Label();
            this.labProduct = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.labSolution = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.labDescription = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.labSubject = new System.Windows.Forms.Label();
            this.labUser = new System.Windows.Forms.Label();
            this.txtWhoRequested = new System.Windows.Forms.TextBox();
            this.labWhoRequested = new System.Windows.Forms.Label();
            this.labCustomerCNPJ = new System.Windows.Forms.Label();
            this.txtServiceOrderID = new System.Windows.Forms.TextBox();
            this.labIServiceOrderID = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.labCustomer = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tShowSaved = new System.Windows.Forms.Timer(this.components);
            this.pForm.SuspendLayout();
            this.pTabInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pForm
            // 
            this.pForm.BackColor = System.Drawing.Color.White;
            this.pForm.Controls.Add(this.labSaved);
            this.pForm.Controls.Add(this.btnNew);
            this.pForm.Controls.Add(this.btnCancel);
            this.pForm.Controls.Add(this.btnSave);
            this.pForm.Controls.Add(this.labTabInfo);
            this.pForm.Controls.Add(this.pTabInfo);
            this.pForm.Location = new System.Drawing.Point(0, 60);
            this.pForm.Name = "pForm";
            this.pForm.Size = new System.Drawing.Size(1024, 556);
            this.pForm.TabIndex = 0;
            // 
            // labSaved
            // 
            this.labSaved.AutoSize = true;
            this.labSaved.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.labSaved.Location = new System.Drawing.Point(76, 494);
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
            this.btnNew.Location = new System.Drawing.Point(657, 491);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 30);
            this.btnNew.TabIndex = 20;
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
            this.btnCancel.Location = new System.Drawing.Point(857, 491);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Roboto Bk", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(757, 491);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labTabInfo
            // 
            this.labTabInfo.AutoSize = true;
            this.labTabInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labTabInfo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTabInfo.Location = new System.Drawing.Point(77, 16);
            this.labTabInfo.Name = "labTabInfo";
            this.labTabInfo.Padding = new System.Windows.Forms.Padding(2);
            this.labTabInfo.Size = new System.Drawing.Size(84, 19);
            this.labTabInfo.TabIndex = 0;
            this.labTabInfo.Text = "Informações";
            // 
            // pTabInfo
            // 
            this.pTabInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pTabInfo.Controls.Add(this.txtCustomerCNPJ);
            this.pTabInfo.Controls.Add(this.btnAddProduct);
            this.pTabInfo.Controls.Add(this.cbServiceOrderInactive);
            this.pTabInfo.Controls.Add(this.btnSearchCustomer);
            this.pTabInfo.Controls.Add(this.dtpServiceEndDate);
            this.pTabInfo.Controls.Add(this.dtpServiceCreationDate);
            this.pTabInfo.Controls.Add(this.dtpServiceStartDate);
            this.pTabInfo.Controls.Add(this.labServiceEndDate);
            this.pTabInfo.Controls.Add(this.cbServiceMode);
            this.pTabInfo.Controls.Add(this.labServiceMode);
            this.pTabInfo.Controls.Add(this.labServiceStartDate);
            this.pTabInfo.Controls.Add(this.labServiceCreationDate);
            this.pTabInfo.Controls.Add(this.labStatus);
            this.pTabInfo.Controls.Add(this.labProduct);
            this.pTabInfo.Controls.Add(this.cbStatus);
            this.pTabInfo.Controls.Add(this.cbProduct);
            this.pTabInfo.Controls.Add(this.cbUser);
            this.pTabInfo.Controls.Add(this.txtSolution);
            this.pTabInfo.Controls.Add(this.labSolution);
            this.pTabInfo.Controls.Add(this.txtDescription);
            this.pTabInfo.Controls.Add(this.labDescription);
            this.pTabInfo.Controls.Add(this.txtSubject);
            this.pTabInfo.Controls.Add(this.labSubject);
            this.pTabInfo.Controls.Add(this.labUser);
            this.pTabInfo.Controls.Add(this.txtWhoRequested);
            this.pTabInfo.Controls.Add(this.labWhoRequested);
            this.pTabInfo.Controls.Add(this.labCustomerCNPJ);
            this.pTabInfo.Controls.Add(this.txtServiceOrderID);
            this.pTabInfo.Controls.Add(this.labIServiceOrderID);
            this.pTabInfo.Controls.Add(this.txtCustomer);
            this.pTabInfo.Controls.Add(this.labCustomer);
            this.pTabInfo.Location = new System.Drawing.Point(77, 35);
            this.pTabInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pTabInfo.Name = "pTabInfo";
            this.pTabInfo.Size = new System.Drawing.Size(870, 424);
            this.pTabInfo.TabIndex = 17;
            // 
            // txtCustomerCNPJ
            // 
            this.txtCustomerCNPJ.Location = new System.Drawing.Point(158, 79);
            this.txtCustomerCNPJ.Mask = "99,999,999/9999-99";
            this.txtCustomerCNPJ.Name = "txtCustomerCNPJ";
            this.txtCustomerCNPJ.ReadOnly = true;
            this.txtCustomerCNPJ.Size = new System.Drawing.Size(132, 23);
            this.txtCustomerCNPJ.TabIndex = 32;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(346, 303);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(23, 23);
            this.btnAddProduct.TabIndex = 31;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cbServiceOrderInactive
            // 
            this.cbServiceOrderInactive.AutoSize = true;
            this.cbServiceOrderInactive.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServiceOrderInactive.Location = new System.Drawing.Point(740, 20);
            this.cbServiceOrderInactive.Name = "cbServiceOrderInactive";
            this.cbServiceOrderInactive.Size = new System.Drawing.Size(60, 17);
            this.cbServiceOrderInactive.TabIndex = 30;
            this.cbServiceOrderInactive.Text = "Inativo";
            this.cbServiceOrderInactive.UseVisualStyleBackColor = true;
            this.cbServiceOrderInactive.CheckedChanged += new System.EventHandler(this.cbServiceOrderInactive_CheckedChanged);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.Image")));
            this.btnSearchCustomer.Location = new System.Drawing.Point(543, 43);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(23, 23);
            this.btnSearchCustomer.TabIndex = 29;
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // dtpServiceEndDate
            // 
            this.dtpServiceEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpServiceEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpServiceEndDate.Location = new System.Drawing.Point(643, 370);
            this.dtpServiceEndDate.Name = "dtpServiceEndDate";
            this.dtpServiceEndDate.Size = new System.Drawing.Size(157, 23);
            this.dtpServiceEndDate.TabIndex = 28;
            // 
            // dtpServiceCreationDate
            // 
            this.dtpServiceCreationDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpServiceCreationDate.Enabled = false;
            this.dtpServiceCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpServiceCreationDate.Location = new System.Drawing.Point(643, 300);
            this.dtpServiceCreationDate.Name = "dtpServiceCreationDate";
            this.dtpServiceCreationDate.Size = new System.Drawing.Size(157, 23);
            this.dtpServiceCreationDate.TabIndex = 27;
            // 
            // dtpServiceStartDate
            // 
            this.dtpServiceStartDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpServiceStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpServiceStartDate.Location = new System.Drawing.Point(643, 335);
            this.dtpServiceStartDate.Name = "dtpServiceStartDate";
            this.dtpServiceStartDate.Size = new System.Drawing.Size(157, 23);
            this.dtpServiceStartDate.TabIndex = 26;
            // 
            // labServiceEndDate
            // 
            this.labServiceEndDate.AutoSize = true;
            this.labServiceEndDate.Location = new System.Drawing.Point(555, 376);
            this.labServiceEndDate.Name = "labServiceEndDate";
            this.labServiceEndDate.Size = new System.Drawing.Size(58, 15);
            this.labServiceEndDate.TabIndex = 25;
            this.labServiceEndDate.Text = "Termino:";
            // 
            // cbServiceMode
            // 
            this.cbServiceMode.FormattingEnabled = true;
            this.cbServiceMode.Items.AddRange(new object[] {
            "E-mail",
            "Skype",
            "Telefone",
            "WhatsApp",
            "Local"});
            this.cbServiceMode.Location = new System.Drawing.Point(158, 336);
            this.cbServiceMode.Name = "cbServiceMode";
            this.cbServiceMode.Size = new System.Drawing.Size(182, 23);
            this.cbServiceMode.TabIndex = 19;
            // 
            // labServiceMode
            // 
            this.labServiceMode.AutoSize = true;
            this.labServiceMode.Location = new System.Drawing.Point(70, 339);
            this.labServiceMode.Name = "labServiceMode";
            this.labServiceMode.Size = new System.Drawing.Size(82, 15);
            this.labServiceMode.TabIndex = 22;
            this.labServiceMode.Text = "Atendimento:";
            // 
            // labServiceStartDate
            // 
            this.labServiceStartDate.AutoSize = true;
            this.labServiceStartDate.Location = new System.Drawing.Point(555, 341);
            this.labServiceStartDate.Name = "labServiceStartDate";
            this.labServiceStartDate.Size = new System.Drawing.Size(41, 15);
            this.labServiceStartDate.TabIndex = 24;
            this.labServiceStartDate.Text = "Início:";
            // 
            // labServiceCreationDate
            // 
            this.labServiceCreationDate.AutoSize = true;
            this.labServiceCreationDate.Location = new System.Drawing.Point(555, 306);
            this.labServiceCreationDate.Name = "labServiceCreationDate";
            this.labServiceCreationDate.Size = new System.Drawing.Size(54, 15);
            this.labServiceCreationDate.TabIndex = 23;
            this.labServiceCreationDate.Text = "Criação:";
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(70, 373);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(47, 15);
            this.labStatus.TabIndex = 21;
            this.labStatus.Text = "Status:";
            // 
            // labProduct
            // 
            this.labProduct.AutoSize = true;
            this.labProduct.Location = new System.Drawing.Point(70, 306);
            this.labProduct.Name = "labProduct";
            this.labProduct.Size = new System.Drawing.Size(57, 15);
            this.labProduct.TabIndex = 20;
            this.labProduct.Text = "Sistema:";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Agendado",
            "Cancelado",
            "Finalizado",
            "Pendente"});
            this.cbStatus.Location = new System.Drawing.Point(158, 370);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(182, 23);
            this.cbStatus.TabIndex = 18;
            // 
            // cbProduct
            // 
            this.cbProduct.DisplayMember = "Name";
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(158, 303);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(182, 23);
            this.cbProduct.TabIndex = 17;
            // 
            // cbUser
            // 
            this.cbUser.DisplayMember = "Name";
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(630, 79);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(170, 23);
            this.cbUser.TabIndex = 16;
            // 
            // txtSolution
            // 
            this.txtSolution.Location = new System.Drawing.Point(158, 226);
            this.txtSolution.Multiline = true;
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.Size = new System.Drawing.Size(642, 62);
            this.txtSolution.TabIndex = 15;
            // 
            // labSolution
            // 
            this.labSolution.AutoSize = true;
            this.labSolution.Location = new System.Drawing.Point(70, 229);
            this.labSolution.Name = "labSolution";
            this.labSolution.Size = new System.Drawing.Size(56, 15);
            this.labSolution.TabIndex = 14;
            this.labSolution.Text = "Solução:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(158, 149);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(642, 62);
            this.txtDescription.TabIndex = 13;
            // 
            // labDescription
            // 
            this.labDescription.AutoSize = true;
            this.labDescription.Location = new System.Drawing.Point(70, 152);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(69, 15);
            this.labDescription.TabIndex = 12;
            this.labDescription.Text = "Descrição:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(158, 114);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(379, 23);
            this.txtSubject.TabIndex = 11;
            // 
            // labSubject
            // 
            this.labSubject.AutoSize = true;
            this.labSubject.Location = new System.Drawing.Point(70, 117);
            this.labSubject.Name = "labSubject";
            this.labSubject.Size = new System.Drawing.Size(57, 15);
            this.labSubject.TabIndex = 10;
            this.labSubject.Text = "Assunto:";
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(568, 82);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(56, 15);
            this.labUser.TabIndex = 8;
            this.labUser.Text = "Técnico:";
            // 
            // txtWhoRequested
            // 
            this.txtWhoRequested.Location = new System.Drawing.Point(372, 79);
            this.txtWhoRequested.Name = "txtWhoRequested";
            this.txtWhoRequested.Size = new System.Drawing.Size(165, 23);
            this.txtWhoRequested.TabIndex = 7;
            // 
            // labWhoRequested
            // 
            this.labWhoRequested.AutoSize = true;
            this.labWhoRequested.Location = new System.Drawing.Point(296, 82);
            this.labWhoRequested.Name = "labWhoRequested";
            this.labWhoRequested.Size = new System.Drawing.Size(70, 15);
            this.labWhoRequested.TabIndex = 6;
            this.labWhoRequested.Text = "Solicitante:";
            // 
            // labCustomerCNPJ
            // 
            this.labCustomerCNPJ.AutoSize = true;
            this.labCustomerCNPJ.Location = new System.Drawing.Point(70, 82);
            this.labCustomerCNPJ.Name = "labCustomerCNPJ";
            this.labCustomerCNPJ.Size = new System.Drawing.Size(42, 15);
            this.labCustomerCNPJ.TabIndex = 4;
            this.labCustomerCNPJ.Text = "CNPJ:";
            // 
            // txtServiceOrderID
            // 
            this.txtServiceOrderID.Enabled = false;
            this.txtServiceOrderID.Location = new System.Drawing.Point(700, 43);
            this.txtServiceOrderID.Name = "txtServiceOrderID";
            this.txtServiceOrderID.Size = new System.Drawing.Size(100, 23);
            this.txtServiceOrderID.TabIndex = 3;
            this.txtServiceOrderID.Text = "0";
            this.txtServiceOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labIServiceOrderID
            // 
            this.labIServiceOrderID.AutoSize = true;
            this.labIServiceOrderID.Location = new System.Drawing.Point(671, 46);
            this.labIServiceOrderID.Name = "labIServiceOrderID";
            this.labIServiceOrderID.Size = new System.Drawing.Size(23, 15);
            this.labIServiceOrderID.TabIndex = 2;
            this.labIServiceOrderID.Text = "ID:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(158, 43);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(379, 23);
            this.txtCustomer.TabIndex = 1;
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyDown);
            // 
            // labCustomer
            // 
            this.labCustomer.AutoSize = true;
            this.labCustomer.Location = new System.Drawing.Point(70, 46);
            this.labCustomer.Name = "labCustomer";
            this.labCustomer.Size = new System.Drawing.Size(61, 15);
            this.labCustomer.TabIndex = 0;
            this.labCustomer.Text = "Empresa:";
            // 
            // labTitle
            // 
            this.labTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(426, 18);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(163, 24);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Ordem de serviço";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(964, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 60);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tShowSaved
            // 
            this.tShowSaved.Interval = 2000;
            this.tShowSaved.Tick += new System.EventHandler(this.tShowSaved_Tick);
            // 
            // frmServiceOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1024, 676);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.pForm);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServiceOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oredm de Serviço";
            this.Load += new System.EventHandler(this.frmServiceOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmServiceOrder_KeyDown);
            this.pForm.ResumeLayout(false);
            this.pForm.PerformLayout();
            this.pTabInfo.ResumeLayout(false);
            this.pTabInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pForm;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pTabInfo;
        private System.Windows.Forms.Label labTabInfo;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.Label labSolution;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label labDescription;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label labSubject;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.TextBox txtWhoRequested;
        private System.Windows.Forms.Label labWhoRequested;
        private System.Windows.Forms.Label labCustomerCNPJ;
        private System.Windows.Forms.TextBox txtServiceOrderID;
        private System.Windows.Forms.Label labIServiceOrderID;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label labCustomer;
        private System.Windows.Forms.ComboBox cbServiceMode;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label labServiceMode;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label labProduct;
        private System.Windows.Forms.Label labServiceEndDate;
        private System.Windows.Forms.Label labServiceStartDate;
        private System.Windows.Forms.Label labServiceCreationDate;
        private System.Windows.Forms.DateTimePicker dtpServiceStartDate;
        private System.Windows.Forms.DateTimePicker dtpServiceEndDate;
        private System.Windows.Forms.DateTimePicker dtpServiceCreationDate;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.CheckBox cbServiceOrderInactive;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.MaskedTextBox txtCustomerCNPJ;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Timer tShowSaved;
        private System.Windows.Forms.Label labSaved;
    }
}