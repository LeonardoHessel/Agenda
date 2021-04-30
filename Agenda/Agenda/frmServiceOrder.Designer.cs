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
            this.gbxServiceOrder = new System.Windows.Forms.GroupBox();
            this.cbWhoLaunched = new System.Windows.Forms.ComboBox();
            this.labCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.labWhoLaunch = new System.Windows.Forms.Label();
            this.labProduct = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.txtCustomerCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.labIServiceOrderID = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.labServiceCreationDate = new System.Windows.Forms.Label();
            this.txtServiceOrderID = new System.Windows.Forms.TextBox();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.labCustomerCNPJ = new System.Windows.Forms.Label();
            this.labServiceStartDate = new System.Windows.Forms.Label();
            this.cbServiceOrderInactive = new System.Windows.Forms.CheckBox();
            this.labSolution = new System.Windows.Forms.Label();
            this.labWhoRequested = new System.Windows.Forms.Label();
            this.labServiceMode = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtWhoRequested = new System.Windows.Forms.TextBox();
            this.cbServiceMode = new System.Windows.Forms.ComboBox();
            this.dtpServiceEndDate = new System.Windows.Forms.DateTimePicker();
            this.labDescription = new System.Windows.Forms.Label();
            this.labUser = new System.Windows.Forms.Label();
            this.labServiceEndDate = new System.Windows.Forms.Label();
            this.dtpServiceCreationDate = new System.Windows.Forms.DateTimePicker();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.labSubject = new System.Windows.Forms.Label();
            this.dtpServiceStartDate = new System.Windows.Forms.DateTimePicker();
            this.labAlert = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tShowSaved = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.pForm.SuspendLayout();
            this.gbxServiceOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pForm
            // 
            this.pForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pForm.Controls.Add(this.gbxServiceOrder);
            this.pForm.Controls.Add(this.labAlert);
            this.pForm.Controls.Add(this.btnNew);
            this.pForm.Controls.Add(this.btnCancel);
            this.pForm.Controls.Add(this.btnSave);
            this.pForm.Location = new System.Drawing.Point(1, 37);
            this.pForm.Name = "pForm";
            this.pForm.Size = new System.Drawing.Size(790, 460);
            this.pForm.TabIndex = 0;
            // 
            // gbxServiceOrder
            // 
            this.gbxServiceOrder.Controls.Add(this.cbWhoLaunched);
            this.gbxServiceOrder.Controls.Add(this.labCustomer);
            this.gbxServiceOrder.Controls.Add(this.txtCustomer);
            this.gbxServiceOrder.Controls.Add(this.cbStatus);
            this.gbxServiceOrder.Controls.Add(this.labWhoLaunch);
            this.gbxServiceOrder.Controls.Add(this.labProduct);
            this.gbxServiceOrder.Controls.Add(this.cbProduct);
            this.gbxServiceOrder.Controls.Add(this.txtCustomerCNPJ);
            this.gbxServiceOrder.Controls.Add(this.labStatus);
            this.gbxServiceOrder.Controls.Add(this.labIServiceOrderID);
            this.gbxServiceOrder.Controls.Add(this.cbUser);
            this.gbxServiceOrder.Controls.Add(this.btnAddProduct);
            this.gbxServiceOrder.Controls.Add(this.labServiceCreationDate);
            this.gbxServiceOrder.Controls.Add(this.txtServiceOrderID);
            this.gbxServiceOrder.Controls.Add(this.txtSolution);
            this.gbxServiceOrder.Controls.Add(this.labCustomerCNPJ);
            this.gbxServiceOrder.Controls.Add(this.labServiceStartDate);
            this.gbxServiceOrder.Controls.Add(this.cbServiceOrderInactive);
            this.gbxServiceOrder.Controls.Add(this.labSolution);
            this.gbxServiceOrder.Controls.Add(this.labWhoRequested);
            this.gbxServiceOrder.Controls.Add(this.labServiceMode);
            this.gbxServiceOrder.Controls.Add(this.btnSearchCustomer);
            this.gbxServiceOrder.Controls.Add(this.txtDescription);
            this.gbxServiceOrder.Controls.Add(this.txtWhoRequested);
            this.gbxServiceOrder.Controls.Add(this.cbServiceMode);
            this.gbxServiceOrder.Controls.Add(this.dtpServiceEndDate);
            this.gbxServiceOrder.Controls.Add(this.labDescription);
            this.gbxServiceOrder.Controls.Add(this.labUser);
            this.gbxServiceOrder.Controls.Add(this.labServiceEndDate);
            this.gbxServiceOrder.Controls.Add(this.dtpServiceCreationDate);
            this.gbxServiceOrder.Controls.Add(this.txtSubject);
            this.gbxServiceOrder.Controls.Add(this.labSubject);
            this.gbxServiceOrder.Controls.Add(this.dtpServiceStartDate);
            this.gbxServiceOrder.Location = new System.Drawing.Point(15, 10);
            this.gbxServiceOrder.Margin = new System.Windows.Forms.Padding(10);
            this.gbxServiceOrder.Name = "gbxServiceOrder";
            this.gbxServiceOrder.Padding = new System.Windows.Forms.Padding(10);
            this.gbxServiceOrder.Size = new System.Drawing.Size(760, 390);
            this.gbxServiceOrder.TabIndex = 0;
            this.gbxServiceOrder.TabStop = false;
            this.gbxServiceOrder.Text = "Ordem de Serviço";
            // 
            // cbWhoLaunched
            // 
            this.cbWhoLaunched.DisplayMember = "Name";
            this.cbWhoLaunched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWhoLaunched.Enabled = false;
            this.cbWhoLaunched.FormattingEnabled = true;
            this.cbWhoLaunched.Location = new System.Drawing.Point(580, 58);
            this.cbWhoLaunched.Margin = new System.Windows.Forms.Padding(5);
            this.cbWhoLaunched.Name = "cbWhoLaunched";
            this.cbWhoLaunched.Size = new System.Drawing.Size(165, 23);
            this.cbWhoLaunched.TabIndex = 34;
            this.cbWhoLaunched.TabStop = false;
            // 
            // labCustomer
            // 
            this.labCustomer.AutoSize = true;
            this.labCustomer.Location = new System.Drawing.Point(31, 28);
            this.labCustomer.Name = "labCustomer";
            this.labCustomer.Size = new System.Drawing.Size(61, 15);
            this.labCustomer.TabIndex = 0;
            this.labCustomer.Text = "Empresa:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomer.Location = new System.Drawing.Point(100, 25);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(383, 23);
            this.txtCustomer.TabIndex = 0;
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyDown);
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
            this.cbStatus.Location = new System.Drawing.Point(100, 350);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(5);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 23);
            this.cbStatus.TabIndex = 7;
            // 
            // labWhoLaunch
            // 
            this.labWhoLaunch.AutoSize = true;
            this.labWhoLaunch.Location = new System.Drawing.Point(491, 61);
            this.labWhoLaunch.Name = "labWhoLaunch";
            this.labWhoLaunch.Size = new System.Drawing.Size(81, 15);
            this.labWhoLaunch.TabIndex = 33;
            this.labWhoLaunch.Text = "Lançado por:";
            // 
            // labProduct
            // 
            this.labProduct.AutoSize = true;
            this.labProduct.Location = new System.Drawing.Point(35, 287);
            this.labProduct.Name = "labProduct";
            this.labProduct.Size = new System.Drawing.Size(57, 15);
            this.labProduct.TabIndex = 20;
            this.labProduct.Text = "Sistema:";
            // 
            // cbProduct
            // 
            this.cbProduct.DisplayMember = "Name";
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(100, 284);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(5);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(200, 23);
            this.cbProduct.TabIndex = 5;
            // 
            // txtCustomerCNPJ
            // 
            this.txtCustomerCNPJ.Location = new System.Drawing.Point(100, 58);
            this.txtCustomerCNPJ.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomerCNPJ.Mask = "99,999,999/9999-99";
            this.txtCustomerCNPJ.Name = "txtCustomerCNPJ";
            this.txtCustomerCNPJ.ReadOnly = true;
            this.txtCustomerCNPJ.Size = new System.Drawing.Size(132, 23);
            this.txtCustomerCNPJ.TabIndex = 1;
            this.txtCustomerCNPJ.TabStop = false;
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(45, 353);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(47, 15);
            this.labStatus.TabIndex = 21;
            this.labStatus.Text = "Status:";
            // 
            // labIServiceOrderID
            // 
            this.labIServiceOrderID.AutoSize = true;
            this.labIServiceOrderID.Location = new System.Drawing.Point(549, 28);
            this.labIServiceOrderID.Name = "labIServiceOrderID";
            this.labIServiceOrderID.Size = new System.Drawing.Size(23, 15);
            this.labIServiceOrderID.TabIndex = 2;
            this.labIServiceOrderID.Text = "ID:";
            // 
            // cbUser
            // 
            this.cbUser.DisplayMember = "Name";
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(580, 91);
            this.cbUser.Margin = new System.Windows.Forms.Padding(5);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(165, 23);
            this.cbUser.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(308, 284);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(23, 23);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.TabStop = false;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // labServiceCreationDate
            // 
            this.labServiceCreationDate.AutoSize = true;
            this.labServiceCreationDate.Location = new System.Drawing.Point(543, 287);
            this.labServiceCreationDate.Name = "labServiceCreationDate";
            this.labServiceCreationDate.Size = new System.Drawing.Size(54, 15);
            this.labServiceCreationDate.TabIndex = 23;
            this.labServiceCreationDate.Text = "Criação:";
            // 
            // txtServiceOrderID
            // 
            this.txtServiceOrderID.BackColor = System.Drawing.SystemColors.Info;
            this.txtServiceOrderID.Location = new System.Drawing.Point(580, 25);
            this.txtServiceOrderID.Margin = new System.Windows.Forms.Padding(5);
            this.txtServiceOrderID.Name = "txtServiceOrderID";
            this.txtServiceOrderID.ReadOnly = true;
            this.txtServiceOrderID.Size = new System.Drawing.Size(97, 23);
            this.txtServiceOrderID.TabIndex = 3;
            this.txtServiceOrderID.TabStop = false;
            this.txtServiceOrderID.Text = "0";
            this.txtServiceOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSolution
            // 
            this.txtSolution.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSolution.Location = new System.Drawing.Point(100, 204);
            this.txtSolution.Margin = new System.Windows.Forms.Padding(5);
            this.txtSolution.Multiline = true;
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolution.Size = new System.Drawing.Size(645, 70);
            this.txtSolution.TabIndex = 4;
            // 
            // labCustomerCNPJ
            // 
            this.labCustomerCNPJ.AutoSize = true;
            this.labCustomerCNPJ.Location = new System.Drawing.Point(50, 61);
            this.labCustomerCNPJ.Name = "labCustomerCNPJ";
            this.labCustomerCNPJ.Size = new System.Drawing.Size(42, 15);
            this.labCustomerCNPJ.TabIndex = 4;
            this.labCustomerCNPJ.Text = "CNPJ:";
            // 
            // labServiceStartDate
            // 
            this.labServiceStartDate.AutoSize = true;
            this.labServiceStartDate.Location = new System.Drawing.Point(556, 320);
            this.labServiceStartDate.Name = "labServiceStartDate";
            this.labServiceStartDate.Size = new System.Drawing.Size(41, 15);
            this.labServiceStartDate.TabIndex = 24;
            this.labServiceStartDate.Text = "Início:";
            // 
            // cbServiceOrderInactive
            // 
            this.cbServiceOrderInactive.AutoSize = true;
            this.cbServiceOrderInactive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbServiceOrderInactive.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServiceOrderInactive.Location = new System.Drawing.Point(685, 29);
            this.cbServiceOrderInactive.Name = "cbServiceOrderInactive";
            this.cbServiceOrderInactive.Size = new System.Drawing.Size(60, 17);
            this.cbServiceOrderInactive.TabIndex = 30;
            this.cbServiceOrderInactive.Text = "Inativo";
            this.cbServiceOrderInactive.UseVisualStyleBackColor = true;
            this.cbServiceOrderInactive.CheckedChanged += new System.EventHandler(this.cbServiceOrderInactive_CheckedChanged);
            // 
            // labSolution
            // 
            this.labSolution.AutoSize = true;
            this.labSolution.Location = new System.Drawing.Point(36, 207);
            this.labSolution.Name = "labSolution";
            this.labSolution.Size = new System.Drawing.Size(56, 15);
            this.labSolution.TabIndex = 14;
            this.labSolution.Text = "Solução:";
            // 
            // labWhoRequested
            // 
            this.labWhoRequested.AutoSize = true;
            this.labWhoRequested.Location = new System.Drawing.Point(240, 61);
            this.labWhoRequested.Name = "labWhoRequested";
            this.labWhoRequested.Size = new System.Drawing.Size(70, 15);
            this.labWhoRequested.TabIndex = 6;
            this.labWhoRequested.Text = "Solicitante:";
            // 
            // labServiceMode
            // 
            this.labServiceMode.AutoSize = true;
            this.labServiceMode.Location = new System.Drawing.Point(10, 320);
            this.labServiceMode.Name = "labServiceMode";
            this.labServiceMode.Size = new System.Drawing.Size(82, 15);
            this.labServiceMode.TabIndex = 22;
            this.labServiceMode.Text = "Atendimento:";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.Image")));
            this.btnSearchCustomer.Location = new System.Drawing.Point(491, 25);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(23, 23);
            this.btnSearchCustomer.TabIndex = 3;
            this.btnSearchCustomer.TabStop = false;
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.Location = new System.Drawing.Point(100, 124);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(645, 70);
            this.txtDescription.TabIndex = 3;
            // 
            // txtWhoRequested
            // 
            this.txtWhoRequested.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWhoRequested.Location = new System.Drawing.Point(318, 58);
            this.txtWhoRequested.Margin = new System.Windows.Forms.Padding(5);
            this.txtWhoRequested.Name = "txtWhoRequested";
            this.txtWhoRequested.Size = new System.Drawing.Size(165, 23);
            this.txtWhoRequested.TabIndex = 1;
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
            this.cbServiceMode.Location = new System.Drawing.Point(100, 317);
            this.cbServiceMode.Margin = new System.Windows.Forms.Padding(5);
            this.cbServiceMode.Name = "cbServiceMode";
            this.cbServiceMode.Size = new System.Drawing.Size(200, 23);
            this.cbServiceMode.TabIndex = 6;
            // 
            // dtpServiceEndDate
            // 
            this.dtpServiceEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpServiceEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpServiceEndDate.Location = new System.Drawing.Point(605, 350);
            this.dtpServiceEndDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpServiceEndDate.Name = "dtpServiceEndDate";
            this.dtpServiceEndDate.Size = new System.Drawing.Size(140, 23);
            this.dtpServiceEndDate.TabIndex = 10;
            // 
            // labDescription
            // 
            this.labDescription.AutoSize = true;
            this.labDescription.Location = new System.Drawing.Point(23, 127);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(69, 15);
            this.labDescription.TabIndex = 12;
            this.labDescription.Text = "Descrição:";
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(516, 94);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(56, 15);
            this.labUser.TabIndex = 8;
            this.labUser.Text = "Técnico:";
            // 
            // labServiceEndDate
            // 
            this.labServiceEndDate.AutoSize = true;
            this.labServiceEndDate.Location = new System.Drawing.Point(539, 353);
            this.labServiceEndDate.Name = "labServiceEndDate";
            this.labServiceEndDate.Size = new System.Drawing.Size(58, 15);
            this.labServiceEndDate.TabIndex = 25;
            this.labServiceEndDate.Text = "Término:";
            // 
            // dtpServiceCreationDate
            // 
            this.dtpServiceCreationDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpServiceCreationDate.Enabled = false;
            this.dtpServiceCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpServiceCreationDate.Location = new System.Drawing.Point(605, 284);
            this.dtpServiceCreationDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpServiceCreationDate.Name = "dtpServiceCreationDate";
            this.dtpServiceCreationDate.Size = new System.Drawing.Size(140, 23);
            this.dtpServiceCreationDate.TabIndex = 8;
            this.dtpServiceCreationDate.TabStop = false;
            // 
            // txtSubject
            // 
            this.txtSubject.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubject.Location = new System.Drawing.Point(100, 91);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(5);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(383, 23);
            this.txtSubject.TabIndex = 2;
            // 
            // labSubject
            // 
            this.labSubject.AutoSize = true;
            this.labSubject.Location = new System.Drawing.Point(35, 94);
            this.labSubject.Name = "labSubject";
            this.labSubject.Size = new System.Drawing.Size(57, 15);
            this.labSubject.TabIndex = 10;
            this.labSubject.Text = "Assunto:";
            // 
            // dtpServiceStartDate
            // 
            this.dtpServiceStartDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpServiceStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpServiceStartDate.Location = new System.Drawing.Point(605, 317);
            this.dtpServiceStartDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpServiceStartDate.Name = "dtpServiceStartDate";
            this.dtpServiceStartDate.Size = new System.Drawing.Size(140, 23);
            this.dtpServiceStartDate.TabIndex = 9;
            // 
            // labAlert
            // 
            this.labAlert.AutoSize = true;
            this.labAlert.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.labAlert.Location = new System.Drawing.Point(11, 416);
            this.labAlert.Name = "labAlert";
            this.labAlert.Size = new System.Drawing.Size(118, 24);
            this.labAlert.TabIndex = 13;
            this.labAlert.Text = "Informação!";
            this.labAlert.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnNew.Enabled = false;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Roboto Bk", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(485, 415);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 30);
            this.btnNew.TabIndex = 0;
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
            this.btnCancel.Location = new System.Drawing.Point(685, 415);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 2;
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
            this.btnSave.Location = new System.Drawing.Point(585, 415);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 1;
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
            this.btnClose.Location = new System.Drawing.Point(746, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 35);
            this.btnClose.TabIndex = 1;
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
            this.labTitle.Size = new System.Drawing.Size(792, 30);
            this.labTitle.TabIndex = 7;
            this.labTitle.Text = "Ordem de Serviço";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labTitle_MouseDown);
            // 
            // frmServiceOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(792, 498);
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
            this.gbxServiceOrder.ResumeLayout(false);
            this.gbxServiceOrder.PerformLayout();
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
        private System.Windows.Forms.Label labAlert;
        private System.Windows.Forms.ComboBox cbWhoLaunched;
        private System.Windows.Forms.Label labWhoLaunch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.GroupBox gbxServiceOrder;
    }
}