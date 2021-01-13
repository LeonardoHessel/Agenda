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
            this.tcSO = new System.Windows.Forms.TabControl();
            this.tpSO = new System.Windows.Forms.TabPage();
            this.cbWhoLaunched = new System.Windows.Forms.ComboBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.labWhoLaunch = new System.Windows.Forms.Label();
            this.labCustomer = new System.Windows.Forms.Label();
            this.txtCustomerCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.labIServiceOrderID = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtServiceOrderID = new System.Windows.Forms.TextBox();
            this.labCustomerCNPJ = new System.Windows.Forms.Label();
            this.cbServiceOrderInactive = new System.Windows.Forms.CheckBox();
            this.labWhoRequested = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtWhoRequested = new System.Windows.Forms.TextBox();
            this.dtpServiceEndDate = new System.Windows.Forms.DateTimePicker();
            this.labUser = new System.Windows.Forms.Label();
            this.dtpServiceCreationDate = new System.Windows.Forms.DateTimePicker();
            this.labSubject = new System.Windows.Forms.Label();
            this.dtpServiceStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.labServiceEndDate = new System.Windows.Forms.Label();
            this.labDescription = new System.Windows.Forms.Label();
            this.cbServiceMode = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.labServiceMode = new System.Windows.Forms.Label();
            this.labSolution = new System.Windows.Forms.Label();
            this.labServiceStartDate = new System.Windows.Forms.Label();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.labServiceCreationDate = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.labProduct = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.labSaved = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tShowSaved = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pForm.SuspendLayout();
            this.tcSO.SuspendLayout();
            this.tpSO.SuspendLayout();
            this.SuspendLayout();
            // 
            // pForm
            // 
            this.pForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pForm.BackColor = System.Drawing.Color.White;
            this.pForm.Controls.Add(this.tcSO);
            this.pForm.Controls.Add(this.labSaved);
            this.pForm.Controls.Add(this.btnNew);
            this.pForm.Controls.Add(this.btnCancel);
            this.pForm.Controls.Add(this.btnSave);
            this.pForm.Location = new System.Drawing.Point(1, 42);
            this.pForm.Name = "pForm";
            this.pForm.Size = new System.Drawing.Size(798, 472);
            this.pForm.TabIndex = 0;
            // 
            // tcSO
            // 
            this.tcSO.Controls.Add(this.tpSO);
            this.tcSO.Location = new System.Drawing.Point(13, 10);
            this.tcSO.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.tcSO.Name = "tcSO";
            this.tcSO.SelectedIndex = 0;
            this.tcSO.Size = new System.Drawing.Size(773, 410);
            this.tcSO.TabIndex = 14;
            // 
            // tpSO
            // 
            this.tpSO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tpSO.Controls.Add(this.cbWhoLaunched);
            this.tpSO.Controls.Add(this.txtCustomer);
            this.tpSO.Controls.Add(this.labWhoLaunch);
            this.tpSO.Controls.Add(this.labCustomer);
            this.tpSO.Controls.Add(this.txtCustomerCNPJ);
            this.tpSO.Controls.Add(this.labIServiceOrderID);
            this.tpSO.Controls.Add(this.btnAddProduct);
            this.tpSO.Controls.Add(this.txtServiceOrderID);
            this.tpSO.Controls.Add(this.labCustomerCNPJ);
            this.tpSO.Controls.Add(this.cbServiceOrderInactive);
            this.tpSO.Controls.Add(this.labWhoRequested);
            this.tpSO.Controls.Add(this.btnSearchCustomer);
            this.tpSO.Controls.Add(this.txtWhoRequested);
            this.tpSO.Controls.Add(this.dtpServiceEndDate);
            this.tpSO.Controls.Add(this.labUser);
            this.tpSO.Controls.Add(this.dtpServiceCreationDate);
            this.tpSO.Controls.Add(this.labSubject);
            this.tpSO.Controls.Add(this.dtpServiceStartDate);
            this.tpSO.Controls.Add(this.txtSubject);
            this.tpSO.Controls.Add(this.labServiceEndDate);
            this.tpSO.Controls.Add(this.labDescription);
            this.tpSO.Controls.Add(this.cbServiceMode);
            this.tpSO.Controls.Add(this.txtDescription);
            this.tpSO.Controls.Add(this.labServiceMode);
            this.tpSO.Controls.Add(this.labSolution);
            this.tpSO.Controls.Add(this.labServiceStartDate);
            this.tpSO.Controls.Add(this.txtSolution);
            this.tpSO.Controls.Add(this.labServiceCreationDate);
            this.tpSO.Controls.Add(this.cbUser);
            this.tpSO.Controls.Add(this.labStatus);
            this.tpSO.Controls.Add(this.cbProduct);
            this.tpSO.Controls.Add(this.labProduct);
            this.tpSO.Controls.Add(this.cbStatus);
            this.tpSO.Location = new System.Drawing.Point(4, 24);
            this.tpSO.Name = "tpSO";
            this.tpSO.Padding = new System.Windows.Forms.Padding(3);
            this.tpSO.Size = new System.Drawing.Size(765, 382);
            this.tpSO.TabIndex = 0;
            this.tpSO.Text = "Ordem de Serviço";
            // 
            // cbWhoLaunched
            // 
            this.cbWhoLaunched.DisplayMember = "Name";
            this.cbWhoLaunched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWhoLaunched.Enabled = false;
            this.cbWhoLaunched.FormattingEnabled = true;
            this.cbWhoLaunched.Location = new System.Drawing.Point(578, 49);
            this.cbWhoLaunched.Margin = new System.Windows.Forms.Padding(5);
            this.cbWhoLaunched.Name = "cbWhoLaunched";
            this.cbWhoLaunched.Size = new System.Drawing.Size(168, 23);
            this.cbWhoLaunched.TabIndex = 34;
            this.cbWhoLaunched.TabStop = false;
            // 
            // txtCustomer
            // 
            this.txtCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomer.Location = new System.Drawing.Point(96, 16);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(383, 23);
            this.txtCustomer.TabIndex = 0;
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyDown);
            // 
            // labWhoLaunch
            // 
            this.labWhoLaunch.AutoSize = true;
            this.labWhoLaunch.Location = new System.Drawing.Point(487, 52);
            this.labWhoLaunch.Name = "labWhoLaunch";
            this.labWhoLaunch.Size = new System.Drawing.Size(81, 15);
            this.labWhoLaunch.TabIndex = 33;
            this.labWhoLaunch.Text = "Lançado por:";
            // 
            // labCustomer
            // 
            this.labCustomer.AutoSize = true;
            this.labCustomer.Location = new System.Drawing.Point(27, 19);
            this.labCustomer.Name = "labCustomer";
            this.labCustomer.Size = new System.Drawing.Size(61, 15);
            this.labCustomer.TabIndex = 0;
            this.labCustomer.Text = "Empresa:";
            // 
            // txtCustomerCNPJ
            // 
            this.txtCustomerCNPJ.Location = new System.Drawing.Point(96, 49);
            this.txtCustomerCNPJ.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomerCNPJ.Mask = "99,999,999/9999-99";
            this.txtCustomerCNPJ.Name = "txtCustomerCNPJ";
            this.txtCustomerCNPJ.ReadOnly = true;
            this.txtCustomerCNPJ.Size = new System.Drawing.Size(132, 23);
            this.txtCustomerCNPJ.TabIndex = 1;
            this.txtCustomerCNPJ.TabStop = false;
            // 
            // labIServiceOrderID
            // 
            this.labIServiceOrderID.AutoSize = true;
            this.labIServiceOrderID.Location = new System.Drawing.Point(549, 20);
            this.labIServiceOrderID.Name = "labIServiceOrderID";
            this.labIServiceOrderID.Size = new System.Drawing.Size(23, 15);
            this.labIServiceOrderID.TabIndex = 2;
            this.labIServiceOrderID.Text = "ID:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(286, 275);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(23, 23);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.TabStop = false;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtServiceOrderID
            // 
            this.txtServiceOrderID.BackColor = System.Drawing.SystemColors.Info;
            this.txtServiceOrderID.Location = new System.Drawing.Point(578, 16);
            this.txtServiceOrderID.Margin = new System.Windows.Forms.Padding(5);
            this.txtServiceOrderID.Name = "txtServiceOrderID";
            this.txtServiceOrderID.ReadOnly = true;
            this.txtServiceOrderID.Size = new System.Drawing.Size(100, 23);
            this.txtServiceOrderID.TabIndex = 3;
            this.txtServiceOrderID.TabStop = false;
            this.txtServiceOrderID.Text = "0";
            this.txtServiceOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labCustomerCNPJ
            // 
            this.labCustomerCNPJ.AutoSize = true;
            this.labCustomerCNPJ.Location = new System.Drawing.Point(46, 52);
            this.labCustomerCNPJ.Name = "labCustomerCNPJ";
            this.labCustomerCNPJ.Size = new System.Drawing.Size(42, 15);
            this.labCustomerCNPJ.TabIndex = 4;
            this.labCustomerCNPJ.Text = "CNPJ:";
            // 
            // cbServiceOrderInactive
            // 
            this.cbServiceOrderInactive.AutoSize = true;
            this.cbServiceOrderInactive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbServiceOrderInactive.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServiceOrderInactive.Location = new System.Drawing.Point(686, 20);
            this.cbServiceOrderInactive.Name = "cbServiceOrderInactive";
            this.cbServiceOrderInactive.Size = new System.Drawing.Size(60, 17);
            this.cbServiceOrderInactive.TabIndex = 30;
            this.cbServiceOrderInactive.Text = "Inativo";
            this.cbServiceOrderInactive.UseVisualStyleBackColor = true;
            this.cbServiceOrderInactive.CheckedChanged += new System.EventHandler(this.cbServiceOrderInactive_CheckedChanged);
            // 
            // labWhoRequested
            // 
            this.labWhoRequested.AutoSize = true;
            this.labWhoRequested.Location = new System.Drawing.Point(236, 52);
            this.labWhoRequested.Name = "labWhoRequested";
            this.labWhoRequested.Size = new System.Drawing.Size(70, 15);
            this.labWhoRequested.TabIndex = 6;
            this.labWhoRequested.Text = "Solicitante:";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.Image")));
            this.btnSearchCustomer.Location = new System.Drawing.Point(487, 16);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(23, 23);
            this.btnSearchCustomer.TabIndex = 3;
            this.btnSearchCustomer.TabStop = false;
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtWhoRequested
            // 
            this.txtWhoRequested.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWhoRequested.Location = new System.Drawing.Point(314, 49);
            this.txtWhoRequested.Margin = new System.Windows.Forms.Padding(5);
            this.txtWhoRequested.Name = "txtWhoRequested";
            this.txtWhoRequested.Size = new System.Drawing.Size(165, 23);
            this.txtWhoRequested.TabIndex = 1;
            // 
            // dtpServiceEndDate
            // 
            this.dtpServiceEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpServiceEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpServiceEndDate.Location = new System.Drawing.Point(606, 341);
            this.dtpServiceEndDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpServiceEndDate.Name = "dtpServiceEndDate";
            this.dtpServiceEndDate.Size = new System.Drawing.Size(140, 23);
            this.dtpServiceEndDate.TabIndex = 11;
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(512, 85);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(56, 15);
            this.labUser.TabIndex = 8;
            this.labUser.Text = "Técnico:";
            // 
            // dtpServiceCreationDate
            // 
            this.dtpServiceCreationDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpServiceCreationDate.Enabled = false;
            this.dtpServiceCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpServiceCreationDate.Location = new System.Drawing.Point(606, 275);
            this.dtpServiceCreationDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpServiceCreationDate.Name = "dtpServiceCreationDate";
            this.dtpServiceCreationDate.Size = new System.Drawing.Size(140, 23);
            this.dtpServiceCreationDate.TabIndex = 9;
            this.dtpServiceCreationDate.TabStop = false;
            // 
            // labSubject
            // 
            this.labSubject.AutoSize = true;
            this.labSubject.Location = new System.Drawing.Point(31, 85);
            this.labSubject.Name = "labSubject";
            this.labSubject.Size = new System.Drawing.Size(57, 15);
            this.labSubject.TabIndex = 10;
            this.labSubject.Text = "Assunto:";
            // 
            // dtpServiceStartDate
            // 
            this.dtpServiceStartDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpServiceStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpServiceStartDate.Location = new System.Drawing.Point(606, 308);
            this.dtpServiceStartDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpServiceStartDate.Name = "dtpServiceStartDate";
            this.dtpServiceStartDate.Size = new System.Drawing.Size(140, 23);
            this.dtpServiceStartDate.TabIndex = 10;
            // 
            // txtSubject
            // 
            this.txtSubject.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubject.Location = new System.Drawing.Point(96, 82);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(5);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(379, 23);
            this.txtSubject.TabIndex = 2;
            // 
            // labServiceEndDate
            // 
            this.labServiceEndDate.AutoSize = true;
            this.labServiceEndDate.Location = new System.Drawing.Point(540, 344);
            this.labServiceEndDate.Name = "labServiceEndDate";
            this.labServiceEndDate.Size = new System.Drawing.Size(58, 15);
            this.labServiceEndDate.TabIndex = 25;
            this.labServiceEndDate.Text = "Termino:";
            // 
            // labDescription
            // 
            this.labDescription.AutoSize = true;
            this.labDescription.Location = new System.Drawing.Point(19, 118);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(69, 15);
            this.labDescription.TabIndex = 12;
            this.labDescription.Text = "Descrição:";
            // 
            // cbServiceMode
            // 
            this.cbServiceMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServiceMode.FormattingEnabled = true;
            this.cbServiceMode.Items.AddRange(new object[] {
            "E-mail",
            "Skype",
            "Telefone",
            "WhatsApp",
            "Local"});
            this.cbServiceMode.Location = new System.Drawing.Point(96, 308);
            this.cbServiceMode.Margin = new System.Windows.Forms.Padding(5);
            this.cbServiceMode.Name = "cbServiceMode";
            this.cbServiceMode.Size = new System.Drawing.Size(182, 23);
            this.cbServiceMode.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.Location = new System.Drawing.Point(96, 115);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(650, 70);
            this.txtDescription.TabIndex = 4;
            // 
            // labServiceMode
            // 
            this.labServiceMode.AutoSize = true;
            this.labServiceMode.Location = new System.Drawing.Point(6, 311);
            this.labServiceMode.Name = "labServiceMode";
            this.labServiceMode.Size = new System.Drawing.Size(82, 15);
            this.labServiceMode.TabIndex = 22;
            this.labServiceMode.Text = "Atendimento:";
            // 
            // labSolution
            // 
            this.labSolution.AutoSize = true;
            this.labSolution.Location = new System.Drawing.Point(32, 198);
            this.labSolution.Name = "labSolution";
            this.labSolution.Size = new System.Drawing.Size(56, 15);
            this.labSolution.TabIndex = 14;
            this.labSolution.Text = "Solução:";
            // 
            // labServiceStartDate
            // 
            this.labServiceStartDate.AutoSize = true;
            this.labServiceStartDate.Location = new System.Drawing.Point(557, 311);
            this.labServiceStartDate.Name = "labServiceStartDate";
            this.labServiceStartDate.Size = new System.Drawing.Size(41, 15);
            this.labServiceStartDate.TabIndex = 24;
            this.labServiceStartDate.Text = "Início:";
            // 
            // txtSolution
            // 
            this.txtSolution.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSolution.Location = new System.Drawing.Point(96, 195);
            this.txtSolution.Margin = new System.Windows.Forms.Padding(5);
            this.txtSolution.Multiline = true;
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolution.Size = new System.Drawing.Size(650, 70);
            this.txtSolution.TabIndex = 5;
            // 
            // labServiceCreationDate
            // 
            this.labServiceCreationDate.AutoSize = true;
            this.labServiceCreationDate.Location = new System.Drawing.Point(544, 281);
            this.labServiceCreationDate.Name = "labServiceCreationDate";
            this.labServiceCreationDate.Size = new System.Drawing.Size(54, 15);
            this.labServiceCreationDate.TabIndex = 23;
            this.labServiceCreationDate.Text = "Criação:";
            // 
            // cbUser
            // 
            this.cbUser.DisplayMember = "Name";
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(578, 82);
            this.cbUser.Margin = new System.Windows.Forms.Padding(5);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(168, 23);
            this.cbUser.TabIndex = 3;
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(41, 344);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(47, 15);
            this.labStatus.TabIndex = 21;
            this.labStatus.Text = "Status:";
            // 
            // cbProduct
            // 
            this.cbProduct.DisplayMember = "Name";
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(96, 275);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(5);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(182, 23);
            this.cbProduct.TabIndex = 6;
            // 
            // labProduct
            // 
            this.labProduct.AutoSize = true;
            this.labProduct.Location = new System.Drawing.Point(31, 278);
            this.labProduct.Name = "labProduct";
            this.labProduct.Size = new System.Drawing.Size(57, 15);
            this.labProduct.TabIndex = 20;
            this.labProduct.Text = "Sistema:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Agendado",
            "Cancelado",
            "Finalizado",
            "Pendente"});
            this.cbStatus.Location = new System.Drawing.Point(96, 341);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(5);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(182, 23);
            this.cbStatus.TabIndex = 8;
            // 
            // labSaved
            // 
            this.labSaved.AutoSize = true;
            this.labSaved.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.labSaved.Location = new System.Drawing.Point(13, 431);
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
            this.btnNew.Location = new System.Drawing.Point(496, 430);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 30);
            this.btnNew.TabIndex = 1;
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
            this.btnCancel.Location = new System.Drawing.Point(696, 430);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 3;
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
            this.btnSave.Location = new System.Drawing.Point(596, 430);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tShowSaved
            // 
            this.tShowSaved.Interval = 2000;
            this.tShowSaved.Tick += new System.EventHandler(this.tShowSaved_Tick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(754, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labTitle
            // 
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTitle.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(0, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(800, 42);
            this.labTitle.TabIndex = 7;
            this.labTitle.Text = "Ordem de Serviço";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labTitle_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Teste Minimizar tudo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmServiceOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.button1);
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
            this.Load += new System.EventHandler(this.frmServiceOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmServiceOrder_KeyDown);
            this.pForm.ResumeLayout(false);
            this.pForm.PerformLayout();
            this.tcSO.ResumeLayout(false);
            this.tpSO.ResumeLayout(false);
            this.tpSO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pForm;
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
        private System.Windows.Forms.ComboBox cbWhoLaunched;
        private System.Windows.Forms.Label labWhoLaunch;
        private System.Windows.Forms.TabControl tcSO;
        private System.Windows.Forms.TabPage tpSO;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button button1;
    }
}