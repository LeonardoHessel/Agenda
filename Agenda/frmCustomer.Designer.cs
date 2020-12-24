namespace Agenda
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.pTitle = new System.Windows.Forms.Panel();
            this.btnQueryCEP = new System.Windows.Forms.Button();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.labNumber = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.labState = new System.Windows.Forms.Label();
            this.labStreet = new System.Windows.Forms.Label();
            this.labCEP = new System.Windows.Forms.Label();
            this.labDistrict = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.labCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.gbxBasicInfo = new System.Windows.Forms.GroupBox();
            this.labSince = new System.Windows.Forms.Label();
            this.cbxProspecting = new System.Windows.Forms.CheckBox();
            this.mtbCellphone = new System.Windows.Forms.MaskedTextBox();
            this.cbxFinancialPending = new System.Windows.Forms.CheckBox();
            this.dtpSince = new System.Windows.Forms.DateTimePicker();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtResponsible = new System.Windows.Forms.TextBox();
            this.labResponsible = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labTelphone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labCNPJ = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labObs = new System.Windows.Forms.Label();
            this.labRazao = new System.Windows.Forms.Label();
            this.labCellphone = new System.Windows.Forms.Label();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.labIE = new System.Windows.Forms.Label();
            this.cbxIsInactive = new System.Windows.Forms.CheckBox();
            this.mtbIE = new System.Windows.Forms.MaskedTextBox();
            this.labID = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.labProduct = new System.Windows.Forms.Label();
            this.labModule = new System.Windows.Forms.Label();
            this.labTerminals = new System.Windows.Forms.Label();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.nudTerminals = new System.Windows.Forms.NumericUpDown();
            this.txtAccountant = new System.Windows.Forms.TextBox();
            this.labAccountant = new System.Windows.Forms.Label();
            this.labAcconuntantEmail = new System.Windows.Forms.Label();
            this.txtAccountantEmail = new System.Windows.Forms.TextBox();
            this.labSaved = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tShowSaved = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.tcInfo = new System.Windows.Forms.TabControl();
            this.tpAddress = new System.Windows.Forms.TabPage();
            this.tbAccountant = new System.Windows.Forms.TabPage();
            this.tbProduct = new System.Windows.Forms.TabPage();
            this.tbCustomer = new System.Windows.Forms.TabControl();
            this.tpCustomer = new System.Windows.Forms.TabPage();
            this.pTitle.SuspendLayout();
            this.gbxBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminals)).BeginInit();
            this.tcInfo.SuspendLayout();
            this.tpAddress.SuspendLayout();
            this.tbAccountant.SuspendLayout();
            this.tbProduct.SuspendLayout();
            this.tbCustomer.SuspendLayout();
            this.tpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.White;
            this.pTitle.Controls.Add(this.tbCustomer);
            this.pTitle.Controls.Add(this.labSaved);
            this.pTitle.Controls.Add(this.btnNew);
            this.pTitle.Controls.Add(this.btnCancel);
            this.pTitle.Controls.Add(this.btnSave);
            this.pTitle.Location = new System.Drawing.Point(1, 42);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(718, 515);
            this.pTitle.TabIndex = 0;
            // 
            // btnQueryCEP
            // 
            this.btnQueryCEP.Location = new System.Drawing.Point(179, 11);
            this.btnQueryCEP.Name = "btnQueryCEP";
            this.btnQueryCEP.Size = new System.Drawing.Size(102, 23);
            this.btnQueryCEP.TabIndex = 42;
            this.btnQueryCEP.Text = "Consulta CEP";
            this.btnQueryCEP.UseVisualStyleBackColor = true;
            this.btnQueryCEP.Click += new System.EventHandler(this.btnQueryCEP_Click);
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(68, 11);
            this.mtbCEP.Mask = "99,999-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(104, 23);
            this.mtbCEP.TabIndex = 0;
            // 
            // cbState
            // 
            this.cbState.DropDownHeight = 80;
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.FormattingEnabled = true;
            this.cbState.IntegralHeight = false;
            this.cbState.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbState.Location = new System.Drawing.Point(402, 11);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(76, 23);
            this.cbState.TabIndex = 5;
            // 
            // txtNumber
            // 
            this.txtNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumber.Location = new System.Drawing.Point(402, 69);
            this.txtNumber.MaxLength = 45;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(97, 23);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Location = new System.Drawing.Point(356, 72);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(24, 15);
            this.labNumber.TabIndex = 37;
            this.labNumber.Text = "N°:";
            // 
            // txtStreet
            // 
            this.txtStreet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStreet.Location = new System.Drawing.Point(68, 69);
            this.txtStreet.MaxLength = 45;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(277, 23);
            this.txtStreet.TabIndex = 1;
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Location = new System.Drawing.Point(347, 14);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(49, 15);
            this.labState.TabIndex = 41;
            this.labState.Text = "Estado:";
            // 
            // labStreet
            // 
            this.labStreet.AutoSize = true;
            this.labStreet.Location = new System.Drawing.Point(13, 72);
            this.labStreet.Name = "labStreet";
            this.labStreet.Size = new System.Drawing.Size(32, 15);
            this.labStreet.TabIndex = 36;
            this.labStreet.Text = "Rua:";
            // 
            // labCEP
            // 
            this.labCEP.AutoSize = true;
            this.labCEP.Location = new System.Drawing.Point(13, 15);
            this.labCEP.Name = "labCEP";
            this.labCEP.Size = new System.Drawing.Size(33, 15);
            this.labCEP.TabIndex = 38;
            this.labCEP.Text = "CEP:";
            // 
            // labDistrict
            // 
            this.labDistrict.AutoSize = true;
            this.labDistrict.Location = new System.Drawing.Point(351, 43);
            this.labDistrict.Name = "labDistrict";
            this.labDistrict.Size = new System.Drawing.Size(45, 15);
            this.labDistrict.TabIndex = 39;
            this.labDistrict.Text = "Bairro:";
            // 
            // txtDistrict
            // 
            this.txtDistrict.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDistrict.Location = new System.Drawing.Point(402, 40);
            this.txtDistrict.MaxLength = 45;
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(224, 23);
            this.txtDistrict.TabIndex = 3;
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.Location = new System.Drawing.Point(13, 43);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(49, 15);
            this.labCity.TabIndex = 40;
            this.labCity.Text = "Cidade:";
            // 
            // txtCity
            // 
            this.txtCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCity.Location = new System.Drawing.Point(68, 40);
            this.txtCity.MaxLength = 45;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(277, 23);
            this.txtCity.TabIndex = 4;
            // 
            // gbxBasicInfo
            // 
            this.gbxBasicInfo.Controls.Add(this.labSince);
            this.gbxBasicInfo.Controls.Add(this.cbxProspecting);
            this.gbxBasicInfo.Controls.Add(this.mtbCellphone);
            this.gbxBasicInfo.Controls.Add(this.cbxFinancialPending);
            this.gbxBasicInfo.Controls.Add(this.dtpSince);
            this.gbxBasicInfo.Controls.Add(this.mtbTelephone);
            this.gbxBasicInfo.Controls.Add(this.txtResponsible);
            this.gbxBasicInfo.Controls.Add(this.labResponsible);
            this.gbxBasicInfo.Controls.Add(this.txtID);
            this.gbxBasicInfo.Controls.Add(this.labTelphone);
            this.gbxBasicInfo.Controls.Add(this.txtEmail);
            this.gbxBasicInfo.Controls.Add(this.labCNPJ);
            this.gbxBasicInfo.Controls.Add(this.labEmail);
            this.gbxBasicInfo.Controls.Add(this.labName);
            this.gbxBasicInfo.Controls.Add(this.txtObs);
            this.gbxBasicInfo.Controls.Add(this.txtName);
            this.gbxBasicInfo.Controls.Add(this.labObs);
            this.gbxBasicInfo.Controls.Add(this.labRazao);
            this.gbxBasicInfo.Controls.Add(this.labCellphone);
            this.gbxBasicInfo.Controls.Add(this.mtbCNPJ);
            this.gbxBasicInfo.Controls.Add(this.txtRazao);
            this.gbxBasicInfo.Controls.Add(this.labIE);
            this.gbxBasicInfo.Controls.Add(this.cbxIsInactive);
            this.gbxBasicInfo.Controls.Add(this.mtbIE);
            this.gbxBasicInfo.Controls.Add(this.labID);
            this.gbxBasicInfo.Location = new System.Drawing.Point(6, 6);
            this.gbxBasicInfo.Name = "gbxBasicInfo";
            this.gbxBasicInfo.Size = new System.Drawing.Size(667, 271);
            this.gbxBasicInfo.TabIndex = 0;
            this.gbxBasicInfo.TabStop = false;
            this.gbxBasicInfo.Text = "Básico";
            // 
            // labSince
            // 
            this.labSince.AutoSize = true;
            this.labSince.Location = new System.Drawing.Point(459, 141);
            this.labSince.Name = "labSince";
            this.labSince.Size = new System.Drawing.Size(87, 15);
            this.labSince.TabIndex = 23;
            this.labSince.Text = "Cliente desde:";
            // 
            // cbxProspecting
            // 
            this.cbxProspecting.AutoSize = true;
            this.cbxProspecting.Location = new System.Drawing.Point(390, 111);
            this.cbxProspecting.Name = "cbxProspecting";
            this.cbxProspecting.Size = new System.Drawing.Size(116, 19);
            this.cbxProspecting.TabIndex = 5;
            this.cbxProspecting.Text = "Em Prospecção";
            this.cbxProspecting.UseVisualStyleBackColor = true;
            // 
            // mtbCellphone
            // 
            this.mtbCellphone.Location = new System.Drawing.Point(261, 138);
            this.mtbCellphone.Mask = "(99) 99999-9999";
            this.mtbCellphone.Name = "mtbCellphone";
            this.mtbCellphone.Size = new System.Drawing.Size(115, 23);
            this.mtbCellphone.TabIndex = 8;
            // 
            // cbxFinancialPending
            // 
            this.cbxFinancialPending.AutoSize = true;
            this.cbxFinancialPending.Location = new System.Drawing.Point(508, 111);
            this.cbxFinancialPending.Name = "cbxFinancialPending";
            this.cbxFinancialPending.Size = new System.Drawing.Size(149, 19);
            this.cbxFinancialPending.TabIndex = 6;
            this.cbxFinancialPending.Text = "Pendência Financeira";
            this.cbxFinancialPending.UseVisualStyleBackColor = true;
            // 
            // dtpSince
            // 
            this.dtpSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSince.Location = new System.Drawing.Point(552, 138);
            this.dtpSince.Name = "dtpSince";
            this.dtpSince.Size = new System.Drawing.Size(105, 23);
            this.dtpSince.TabIndex = 9;
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(99, 138);
            this.mtbTelephone.Mask = "(99) 9999-9999";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(100, 23);
            this.mtbTelephone.TabIndex = 7;
            // 
            // txtResponsible
            // 
            this.txtResponsible.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResponsible.Location = new System.Drawing.Point(99, 22);
            this.txtResponsible.MaxLength = 45;
            this.txtResponsible.Name = "txtResponsible";
            this.txtResponsible.Size = new System.Drawing.Size(352, 23);
            this.txtResponsible.TabIndex = 0;
            // 
            // labResponsible
            // 
            this.labResponsible.AutoSize = true;
            this.labResponsible.Location = new System.Drawing.Point(13, 25);
            this.labResponsible.Name = "labResponsible";
            this.labResponsible.Size = new System.Drawing.Size(84, 15);
            this.labResponsible.TabIndex = 21;
            this.labResponsible.Text = "Responsavel:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(486, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "0";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labTelphone
            // 
            this.labTelphone.AutoSize = true;
            this.labTelphone.Location = new System.Drawing.Point(13, 141);
            this.labTelphone.Name = "labTelphone";
            this.labTelphone.Size = new System.Drawing.Size(60, 15);
            this.labTelphone.TabIndex = 11;
            this.labTelphone.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(99, 167);
            this.txtEmail.MaxLength = 250;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(558, 23);
            this.txtEmail.TabIndex = 10;
            // 
            // labCNPJ
            // 
            this.labCNPJ.AutoSize = true;
            this.labCNPJ.Location = new System.Drawing.Point(13, 112);
            this.labCNPJ.Name = "labCNPJ";
            this.labCNPJ.Size = new System.Drawing.Size(42, 15);
            this.labCNPJ.TabIndex = 9;
            this.labCNPJ.Text = "CNPJ:";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(13, 170);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(41, 15);
            this.labEmail.TabIndex = 13;
            this.labEmail.Text = "Email:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(13, 83);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(59, 15);
            this.labName.TabIndex = 7;
            this.labName.Text = "Fantasia:";
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Location = new System.Drawing.Point(99, 196);
            this.txtObs.MaxLength = 65535;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs.Size = new System.Drawing.Size(558, 65);
            this.txtObs.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(99, 80);
            this.txtName.MaxLength = 250;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(558, 23);
            this.txtName.TabIndex = 2;
            // 
            // labObs
            // 
            this.labObs.AutoSize = true;
            this.labObs.Location = new System.Drawing.Point(13, 199);
            this.labObs.Name = "labObs";
            this.labObs.Size = new System.Drawing.Size(80, 15);
            this.labObs.TabIndex = 15;
            this.labObs.Text = "Observação:";
            // 
            // labRazao
            // 
            this.labRazao.AutoSize = true;
            this.labRazao.Location = new System.Drawing.Point(13, 54);
            this.labRazao.Name = "labRazao";
            this.labRazao.Size = new System.Drawing.Size(46, 15);
            this.labRazao.TabIndex = 5;
            this.labRazao.Text = "Razão:";
            // 
            // labCellphone
            // 
            this.labCellphone.AutoSize = true;
            this.labCellphone.Location = new System.Drawing.Point(205, 141);
            this.labCellphone.Name = "labCellphone";
            this.labCellphone.Size = new System.Drawing.Size(50, 15);
            this.labCellphone.TabIndex = 20;
            this.labCellphone.Text = "Celular:";
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Location = new System.Drawing.Point(99, 109);
            this.mtbCNPJ.Mask = "99,999,999/9999-99";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(125, 23);
            this.mtbCNPJ.TabIndex = 3;
            this.mtbCNPJ.Validated += new System.EventHandler(this.mtbCNPJ_Validated);
            // 
            // txtRazao
            // 
            this.txtRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazao.Location = new System.Drawing.Point(99, 51);
            this.txtRazao.MaxLength = 250;
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(558, 23);
            this.txtRazao.TabIndex = 1;
            // 
            // labIE
            // 
            this.labIE.AutoSize = true;
            this.labIE.Location = new System.Drawing.Point(234, 112);
            this.labIE.Name = "labIE";
            this.labIE.Size = new System.Drawing.Size(21, 15);
            this.labIE.TabIndex = 17;
            this.labIE.Text = "IE:";
            // 
            // cbxIsInactive
            // 
            this.cbxIsInactive.AutoSize = true;
            this.cbxIsInactive.Location = new System.Drawing.Point(592, 24);
            this.cbxIsInactive.Name = "cbxIsInactive";
            this.cbxIsInactive.Size = new System.Drawing.Size(65, 19);
            this.cbxIsInactive.TabIndex = 12;
            this.cbxIsInactive.Text = "Inativo";
            this.cbxIsInactive.UseVisualStyleBackColor = true;
            this.cbxIsInactive.CheckedChanged += new System.EventHandler(this.cbxIsInactive_CheckedChanged);
            // 
            // mtbIE
            // 
            this.mtbIE.Location = new System.Drawing.Point(271, 109);
            this.mtbIE.Mask = "999,999,999,999";
            this.mtbIE.Name = "mtbIE";
            this.mtbIE.Size = new System.Drawing.Size(105, 23);
            this.mtbIE.TabIndex = 4;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(457, 25);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(23, 15);
            this.labID.TabIndex = 0;
            this.labID.Text = "ID:";
            // 
            // cbProduct
            // 
            this.cbProduct.DisplayMember = "Name";
            this.cbProduct.DropDownHeight = 80;
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.IntegralHeight = false;
            this.cbProduct.Location = new System.Drawing.Point(72, 37);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(142, 23);
            this.cbProduct.TabIndex = 0;
            // 
            // labProduct
            // 
            this.labProduct.AutoSize = true;
            this.labProduct.Location = new System.Drawing.Point(9, 40);
            this.labProduct.Name = "labProduct";
            this.labProduct.Size = new System.Drawing.Size(57, 15);
            this.labProduct.TabIndex = 46;
            this.labProduct.Text = "Sistema:";
            // 
            // labModule
            // 
            this.labModule.AutoSize = true;
            this.labModule.Location = new System.Drawing.Point(220, 40);
            this.labModule.Name = "labModule";
            this.labModule.Size = new System.Drawing.Size(59, 15);
            this.labModule.TabIndex = 47;
            this.labModule.Text = "Modulos:";
            // 
            // labTerminals
            // 
            this.labTerminals.AutoSize = true;
            this.labTerminals.Location = new System.Drawing.Point(518, 39);
            this.labTerminals.Name = "labTerminals";
            this.labTerminals.Size = new System.Drawing.Size(68, 15);
            this.labTerminals.TabIndex = 49;
            this.labTerminals.Text = "Terminais:";
            // 
            // txtModule
            // 
            this.txtModule.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModule.Location = new System.Drawing.Point(285, 37);
            this.txtModule.MaxLength = 45;
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(227, 23);
            this.txtModule.TabIndex = 1;
            // 
            // nudTerminals
            // 
            this.nudTerminals.Location = new System.Drawing.Point(592, 37);
            this.nudTerminals.Name = "nudTerminals";
            this.nudTerminals.Size = new System.Drawing.Size(47, 23);
            this.nudTerminals.TabIndex = 2;
            // 
            // txtAccountant
            // 
            this.txtAccountant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccountant.Location = new System.Drawing.Point(81, 37);
            this.txtAccountant.MaxLength = 45;
            this.txtAccountant.Name = "txtAccountant";
            this.txtAccountant.Size = new System.Drawing.Size(193, 23);
            this.txtAccountant.TabIndex = 0;
            // 
            // labAccountant
            // 
            this.labAccountant.AutoSize = true;
            this.labAccountant.Location = new System.Drawing.Point(9, 40);
            this.labAccountant.Name = "labAccountant";
            this.labAccountant.Size = new System.Drawing.Size(62, 15);
            this.labAccountant.TabIndex = 44;
            this.labAccountant.Text = "Contador:";
            // 
            // labAcconuntantEmail
            // 
            this.labAcconuntantEmail.AutoSize = true;
            this.labAcconuntantEmail.Location = new System.Drawing.Point(280, 40);
            this.labAcconuntantEmail.Name = "labAcconuntantEmail";
            this.labAcconuntantEmail.Size = new System.Drawing.Size(41, 15);
            this.labAcconuntantEmail.TabIndex = 45;
            this.labAcconuntantEmail.Text = "Email:";
            // 
            // txtAccountantEmail
            // 
            this.txtAccountantEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccountantEmail.Location = new System.Drawing.Point(327, 37);
            this.txtAccountantEmail.MaxLength = 250;
            this.txtAccountantEmail.Name = "txtAccountantEmail";
            this.txtAccountantEmail.Size = new System.Drawing.Size(316, 23);
            this.txtAccountantEmail.TabIndex = 1;
            // 
            // labSaved
            // 
            this.labSaved.AutoSize = true;
            this.labSaved.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.labSaved.Location = new System.Drawing.Point(9, 469);
            this.labSaved.Name = "labSaved";
            this.labSaved.Size = new System.Drawing.Size(142, 24);
            this.labSaved.TabIndex = 12;
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
            this.btnNew.Location = new System.Drawing.Point(414, 468);
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
            this.btnCancel.Location = new System.Drawing.Point(614, 468);
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
            this.btnSave.Location = new System.Drawing.Point(514, 468);
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
            this.btnClose.Location = new System.Drawing.Point(674, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 40);
            this.btnClose.TabIndex = 4;
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
            this.labTitle.Size = new System.Drawing.Size(720, 42);
            this.labTitle.TabIndex = 5;
            this.labTitle.Text = "Cliente";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcInfo
            // 
            this.tcInfo.Controls.Add(this.tpAddress);
            this.tcInfo.Controls.Add(this.tbProduct);
            this.tcInfo.Controls.Add(this.tbAccountant);
            this.tcInfo.Location = new System.Drawing.Point(6, 283);
            this.tcInfo.Name = "tcInfo";
            this.tcInfo.SelectedIndex = 0;
            this.tcInfo.Size = new System.Drawing.Size(667, 129);
            this.tcInfo.TabIndex = 13;
            // 
            // tpAddress
            // 
            this.tpAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tpAddress.Controls.Add(this.btnQueryCEP);
            this.tpAddress.Controls.Add(this.labCEP);
            this.tpAddress.Controls.Add(this.mtbCEP);
            this.tpAddress.Controls.Add(this.txtCity);
            this.tpAddress.Controls.Add(this.cbState);
            this.tpAddress.Controls.Add(this.labCity);
            this.tpAddress.Controls.Add(this.txtNumber);
            this.tpAddress.Controls.Add(this.txtDistrict);
            this.tpAddress.Controls.Add(this.labNumber);
            this.tpAddress.Controls.Add(this.labDistrict);
            this.tpAddress.Controls.Add(this.txtStreet);
            this.tpAddress.Controls.Add(this.labStreet);
            this.tpAddress.Controls.Add(this.labState);
            this.tpAddress.Location = new System.Drawing.Point(4, 24);
            this.tpAddress.Name = "tpAddress";
            this.tpAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddress.Size = new System.Drawing.Size(659, 101);
            this.tpAddress.TabIndex = 0;
            this.tpAddress.Text = "Endereço";
            // 
            // tbAccountant
            // 
            this.tbAccountant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tbAccountant.Controls.Add(this.txtAccountant);
            this.tbAccountant.Controls.Add(this.labAccountant);
            this.tbAccountant.Controls.Add(this.txtAccountantEmail);
            this.tbAccountant.Controls.Add(this.labAcconuntantEmail);
            this.tbAccountant.Location = new System.Drawing.Point(4, 24);
            this.tbAccountant.Name = "tbAccountant";
            this.tbAccountant.Padding = new System.Windows.Forms.Padding(3);
            this.tbAccountant.Size = new System.Drawing.Size(659, 101);
            this.tbAccountant.TabIndex = 1;
            this.tbAccountant.Text = "Escrítorio Contábil";
            // 
            // tbProduct
            // 
            this.tbProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tbProduct.Controls.Add(this.cbProduct);
            this.tbProduct.Controls.Add(this.labProduct);
            this.tbProduct.Controls.Add(this.nudTerminals);
            this.tbProduct.Controls.Add(this.labModule);
            this.tbProduct.Controls.Add(this.txtModule);
            this.tbProduct.Controls.Add(this.labTerminals);
            this.tbProduct.Location = new System.Drawing.Point(4, 24);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(659, 101);
            this.tbProduct.TabIndex = 2;
            this.tbProduct.Text = "Sistema";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Controls.Add(this.tpCustomer);
            this.tbCustomer.Location = new System.Drawing.Point(13, 10);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.SelectedIndex = 0;
            this.tbCustomer.Size = new System.Drawing.Size(691, 448);
            this.tbCustomer.TabIndex = 14;
            // 
            // tpCustomer
            // 
            this.tpCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tpCustomer.Controls.Add(this.gbxBasicInfo);
            this.tpCustomer.Controls.Add(this.tcInfo);
            this.tpCustomer.Location = new System.Drawing.Point(4, 24);
            this.tpCustomer.Name = "tpCustomer";
            this.tpCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomer.Size = new System.Drawing.Size(683, 420);
            this.tpCustomer.TabIndex = 0;
            this.tpCustomer.Text = "Cliente";
            // 
            // frmCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(720, 558);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.pTitle);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCustomer_KeyDown);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.gbxBasicInfo.ResumeLayout(false);
            this.gbxBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminals)).EndInit();
            this.tcInfo.ResumeLayout(false);
            this.tpAddress.ResumeLayout(false);
            this.tpAddress.PerformLayout();
            this.tbAccountant.ResumeLayout(false);
            this.tbAccountant.PerformLayout();
            this.tbProduct.ResumeLayout(false);
            this.tbProduct.PerformLayout();
            this.tbCustomer.ResumeLayout(false);
            this.tpCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.CheckBox cbxIsInactive;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labCellphone;
        private System.Windows.Forms.MaskedTextBox mtbIE;
        private System.Windows.Forms.Label labIE;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.Label labObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labTelphone;
        private System.Windows.Forms.Label labCNPJ;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labRazao;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.Label labState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label labDistrict;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Label labCEP;
        private System.Windows.Forms.Label labStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAccountantEmail;
        private System.Windows.Forms.TextBox txtAccountant;
        private System.Windows.Forms.Label labAcconuntantEmail;
        private System.Windows.Forms.Label labAccountant;
        private System.Windows.Forms.Label labModule;
        private System.Windows.Forms.Label labProduct;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label labSaved;
        private System.Windows.Forms.Timer tShowSaved;
        private System.Windows.Forms.NumericUpDown nudTerminals;
        private System.Windows.Forms.Label labTerminals;
        private System.Windows.Forms.GroupBox gbxBasicInfo;
        private System.Windows.Forms.TextBox txtResponsible;
        private System.Windows.Forms.Label labResponsible;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.MaskedTextBox mtbCellphone;
        private System.Windows.Forms.CheckBox cbxFinancialPending;
        private System.Windows.Forms.CheckBox cbxProspecting;
        private System.Windows.Forms.Label labSince;
        private System.Windows.Forms.DateTimePicker dtpSince;
        private System.Windows.Forms.Button btnQueryCEP;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.TabControl tcInfo;
        private System.Windows.Forms.TabPage tpAddress;
        private System.Windows.Forms.TabPage tbAccountant;
        private System.Windows.Forms.TabPage tbProduct;
        private System.Windows.Forms.TabControl tbCustomer;
        private System.Windows.Forms.TabPage tpCustomer;
    }
}