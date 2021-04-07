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
            this.tbCustomer = new System.Windows.Forms.TabControl();
            this.tpCustomer = new System.Windows.Forms.TabPage();
            this.cbxInfoPending = new System.Windows.Forms.CheckBox();
            this.labSince = new System.Windows.Forms.Label();
            this.labResponsible = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.tcInfo = new System.Windows.Forms.TabControl();
            this.tpAddress = new System.Windows.Forms.TabPage();
            this.btnQueryCEP = new System.Windows.Forms.Button();
            this.labCEP = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.labCity = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.labNumber = new System.Windows.Forms.Label();
            this.labDistrict = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.labStreet = new System.Windows.Forms.Label();
            this.labState = new System.Windows.Forms.Label();
            this.tbProduct = new System.Windows.Forms.TabPage();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.labProduct = new System.Windows.Forms.Label();
            this.nudTerminals = new System.Windows.Forms.NumericUpDown();
            this.labModule = new System.Windows.Forms.Label();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.labTerminals = new System.Windows.Forms.Label();
            this.tbAccountant = new System.Windows.Forms.TabPage();
            this.txtAccountant = new System.Windows.Forms.TextBox();
            this.labAccountant = new System.Windows.Forms.Label();
            this.txtAccountantEmail = new System.Windows.Forms.TextBox();
            this.labAcconuntantEmail = new System.Windows.Forms.Label();
            this.cbxProspecting = new System.Windows.Forms.CheckBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labIE = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.mtbCellphone = new System.Windows.Forms.MaskedTextBox();
            this.txtResponsible = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.labObs = new System.Windows.Forms.Label();
            this.cbxIsInactive = new System.Windows.Forms.CheckBox();
            this.cbxFinancialPending = new System.Windows.Forms.CheckBox();
            this.labTelphone = new System.Windows.Forms.Label();
            this.labCNPJ = new System.Windows.Forms.Label();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.labID = new System.Windows.Forms.Label();
            this.labCellphone = new System.Windows.Forms.Label();
            this.labRazao = new System.Windows.Forms.Label();
            this.mtbIE = new System.Windows.Forms.MaskedTextBox();
            this.dtpSince = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labSaved = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tShowSaved = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.pTitle.SuspendLayout();
            this.tbCustomer.SuspendLayout();
            this.tpCustomer.SuspendLayout();
            this.tcInfo.SuspendLayout();
            this.tpAddress.SuspendLayout();
            this.tbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminals)).BeginInit();
            this.tbAccountant.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTitle.BackColor = System.Drawing.Color.White;
            this.pTitle.Controls.Add(this.tbCustomer);
            this.pTitle.Controls.Add(this.labSaved);
            this.pTitle.Controls.Add(this.btnNew);
            this.pTitle.Controls.Add(this.btnCancel);
            this.pTitle.Controls.Add(this.btnSave);
            this.pTitle.Location = new System.Drawing.Point(1, 42);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(898, 497);
            this.pTitle.TabIndex = 0;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomer.Controls.Add(this.tpCustomer);
            this.tbCustomer.Location = new System.Drawing.Point(13, 10);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.SelectedIndex = 0;
            this.tbCustomer.Size = new System.Drawing.Size(873, 427);
            this.tbCustomer.TabIndex = 0;
            // 
            // tpCustomer
            // 
            this.tpCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tpCustomer.Controls.Add(this.cbxInfoPending);
            this.tpCustomer.Controls.Add(this.labSince);
            this.tpCustomer.Controls.Add(this.labResponsible);
            this.tpCustomer.Controls.Add(this.txtObs);
            this.tpCustomer.Controls.Add(this.tcInfo);
            this.tpCustomer.Controls.Add(this.cbxProspecting);
            this.tpCustomer.Controls.Add(this.txtRazao);
            this.tpCustomer.Controls.Add(this.labName);
            this.tpCustomer.Controls.Add(this.labIE);
            this.tpCustomer.Controls.Add(this.txtName);
            this.tpCustomer.Controls.Add(this.txtID);
            this.tpCustomer.Controls.Add(this.mtbCellphone);
            this.tpCustomer.Controls.Add(this.txtResponsible);
            this.tpCustomer.Controls.Add(this.labEmail);
            this.tpCustomer.Controls.Add(this.mtbCNPJ);
            this.tpCustomer.Controls.Add(this.labObs);
            this.tpCustomer.Controls.Add(this.cbxIsInactive);
            this.tpCustomer.Controls.Add(this.cbxFinancialPending);
            this.tpCustomer.Controls.Add(this.labTelphone);
            this.tpCustomer.Controls.Add(this.labCNPJ);
            this.tpCustomer.Controls.Add(this.mtbTelephone);
            this.tpCustomer.Controls.Add(this.labID);
            this.tpCustomer.Controls.Add(this.labCellphone);
            this.tpCustomer.Controls.Add(this.labRazao);
            this.tpCustomer.Controls.Add(this.mtbIE);
            this.tpCustomer.Controls.Add(this.dtpSince);
            this.tpCustomer.Controls.Add(this.txtEmail);
            this.tpCustomer.Location = new System.Drawing.Point(4, 25);
            this.tpCustomer.Name = "tpCustomer";
            this.tpCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomer.Size = new System.Drawing.Size(865, 398);
            this.tpCustomer.TabIndex = 0;
            this.tpCustomer.Text = "Cliente";
            // 
            // cbxInfoPending
            // 
            this.cbxInfoPending.AutoSize = true;
            this.cbxInfoPending.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxInfoPending.Location = new System.Drawing.Point(699, 74);
            this.cbxInfoPending.Margin = new System.Windows.Forms.Padding(5);
            this.cbxInfoPending.Name = "cbxInfoPending";
            this.cbxInfoPending.Size = new System.Drawing.Size(155, 20);
            this.cbxInfoPending.TabIndex = 8;
            this.cbxInfoPending.Text = "Pendência de Dados";
            this.cbxInfoPending.UseVisualStyleBackColor = true;
            // 
            // labSince
            // 
            this.labSince.AutoSize = true;
            this.labSince.Location = new System.Drawing.Point(435, 10);
            this.labSince.Margin = new System.Windows.Forms.Padding(5);
            this.labSince.Name = "labSince";
            this.labSince.Size = new System.Drawing.Size(94, 16);
            this.labSince.TabIndex = 23;
            this.labSince.Text = "Cliente desde:";
            // 
            // labResponsible
            // 
            this.labResponsible.AutoSize = true;
            this.labResponsible.Location = new System.Drawing.Point(8, 11);
            this.labResponsible.Margin = new System.Windows.Forms.Padding(5);
            this.labResponsible.Name = "labResponsible";
            this.labResponsible.Size = new System.Drawing.Size(92, 16);
            this.labResponsible.TabIndex = 21;
            this.labResponsible.Text = "Responsavel:";
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Location = new System.Drawing.Point(110, 136);
            this.txtObs.Margin = new System.Windows.Forms.Padding(5);
            this.txtObs.MaxLength = 65535;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs.Size = new System.Drawing.Size(744, 100);
            this.txtObs.TabIndex = 12;
            // 
            // tcInfo
            // 
            this.tcInfo.Controls.Add(this.tpAddress);
            this.tcInfo.Controls.Add(this.tbProduct);
            this.tcInfo.Controls.Add(this.tbAccountant);
            this.tcInfo.Location = new System.Drawing.Point(11, 246);
            this.tcInfo.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.tcInfo.Name = "tcInfo";
            this.tcInfo.SelectedIndex = 0;
            this.tcInfo.Size = new System.Drawing.Size(843, 142);
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
            this.tpAddress.Location = new System.Drawing.Point(4, 25);
            this.tpAddress.Name = "tpAddress";
            this.tpAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddress.Size = new System.Drawing.Size(835, 113);
            this.tpAddress.TabIndex = 0;
            this.tpAddress.Text = "Endereço";
            // 
            // btnQueryCEP
            // 
            this.btnQueryCEP.Location = new System.Drawing.Point(194, 14);
            this.btnQueryCEP.Margin = new System.Windows.Forms.Padding(5);
            this.btnQueryCEP.Name = "btnQueryCEP";
            this.btnQueryCEP.Size = new System.Drawing.Size(102, 23);
            this.btnQueryCEP.TabIndex = 1;
            this.btnQueryCEP.Text = "Consulta CEP";
            this.btnQueryCEP.UseVisualStyleBackColor = true;
            this.btnQueryCEP.Click += new System.EventHandler(this.btnQueryCEP_Click);
            // 
            // labCEP
            // 
            this.labCEP.AutoSize = true;
            this.labCEP.Location = new System.Drawing.Point(34, 18);
            this.labCEP.Name = "labCEP";
            this.labCEP.Size = new System.Drawing.Size(38, 16);
            this.labCEP.TabIndex = 38;
            this.labCEP.Text = "CEP:";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(80, 15);
            this.mtbCEP.Margin = new System.Windows.Forms.Padding(5);
            this.mtbCEP.Mask = "99,999-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(104, 22);
            this.mtbCEP.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCity.Location = new System.Drawing.Point(80, 47);
            this.txtCity.Margin = new System.Windows.Forms.Padding(5);
            this.txtCity.MaxLength = 45;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(342, 22);
            this.txtCity.TabIndex = 3;
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
            this.cbState.Location = new System.Drawing.Point(391, 13);
            this.cbState.Margin = new System.Windows.Forms.Padding(5);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(76, 24);
            this.cbState.TabIndex = 2;
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.Location = new System.Drawing.Point(17, 50);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(55, 16);
            this.labCity.TabIndex = 40;
            this.labCity.Text = "Cidade:";
            // 
            // txtNumber
            // 
            this.txtNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumber.Location = new System.Drawing.Point(485, 79);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumber.MaxLength = 45;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(133, 22);
            this.txtNumber.TabIndex = 6;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDistrict
            // 
            this.txtDistrict.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDistrict.Location = new System.Drawing.Point(485, 47);
            this.txtDistrict.Margin = new System.Windows.Forms.Padding(5);
            this.txtDistrict.MaxLength = 100;
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(334, 22);
            this.txtDistrict.TabIndex = 4;
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Location = new System.Drawing.Point(452, 82);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(25, 16);
            this.labNumber.TabIndex = 37;
            this.labNumber.Text = "N°:";
            // 
            // labDistrict
            // 
            this.labDistrict.AutoSize = true;
            this.labDistrict.Location = new System.Drawing.Point(430, 50);
            this.labDistrict.Name = "labDistrict";
            this.labDistrict.Size = new System.Drawing.Size(47, 16);
            this.labDistrict.TabIndex = 39;
            this.labDistrict.Text = "Bairro:";
            // 
            // txtStreet
            // 
            this.txtStreet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStreet.Location = new System.Drawing.Point(80, 79);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(5);
            this.txtStreet.MaxLength = 45;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(342, 22);
            this.txtStreet.TabIndex = 5;
            // 
            // labStreet
            // 
            this.labStreet.AutoSize = true;
            this.labStreet.Location = new System.Drawing.Point(36, 82);
            this.labStreet.Name = "labStreet";
            this.labStreet.Size = new System.Drawing.Size(36, 16);
            this.labStreet.TabIndex = 36;
            this.labStreet.Text = "Rua:";
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Location = new System.Drawing.Point(329, 18);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(54, 16);
            this.labState.TabIndex = 41;
            this.labState.Text = "Estado:";
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
            this.tbProduct.Location = new System.Drawing.Point(4, 22);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(835, 116);
            this.tbProduct.TabIndex = 2;
            this.tbProduct.Text = "Sistema";
            // 
            // cbProduct
            // 
            this.cbProduct.DisplayMember = "Name";
            this.cbProduct.DropDownHeight = 80;
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.IntegralHeight = false;
            this.cbProduct.Location = new System.Drawing.Point(80, 15);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(5);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(177, 24);
            this.cbProduct.TabIndex = 0;
            // 
            // labProduct
            // 
            this.labProduct.AutoSize = true;
            this.labProduct.Location = new System.Drawing.Point(12, 18);
            this.labProduct.Name = "labProduct";
            this.labProduct.Size = new System.Drawing.Size(60, 16);
            this.labProduct.TabIndex = 46;
            this.labProduct.Text = "Sistema:";
            // 
            // nudTerminals
            // 
            this.nudTerminals.Location = new System.Drawing.Point(344, 16);
            this.nudTerminals.Margin = new System.Windows.Forms.Padding(5);
            this.nudTerminals.Name = "nudTerminals";
            this.nudTerminals.Size = new System.Drawing.Size(66, 22);
            this.nudTerminals.TabIndex = 1;
            this.nudTerminals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labModule
            // 
            this.labModule.AutoSize = true;
            this.labModule.Location = new System.Drawing.Point(9, 50);
            this.labModule.Name = "labModule";
            this.labModule.Size = new System.Drawing.Size(63, 16);
            this.labModule.TabIndex = 47;
            this.labModule.Text = "Modulos:";
            // 
            // txtModule
            // 
            this.txtModule.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModule.Location = new System.Drawing.Point(80, 47);
            this.txtModule.Margin = new System.Windows.Forms.Padding(5);
            this.txtModule.MaxLength = 45;
            this.txtModule.Multiline = true;
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(741, 50);
            this.txtModule.TabIndex = 2;
            // 
            // labTerminals
            // 
            this.labTerminals.AutoSize = true;
            this.labTerminals.Location = new System.Drawing.Point(265, 18);
            this.labTerminals.Name = "labTerminals";
            this.labTerminals.Size = new System.Drawing.Size(71, 16);
            this.labTerminals.TabIndex = 49;
            this.labTerminals.Text = "Terminais:";
            // 
            // tbAccountant
            // 
            this.tbAccountant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tbAccountant.Controls.Add(this.txtAccountant);
            this.tbAccountant.Controls.Add(this.labAccountant);
            this.tbAccountant.Controls.Add(this.txtAccountantEmail);
            this.tbAccountant.Controls.Add(this.labAcconuntantEmail);
            this.tbAccountant.Location = new System.Drawing.Point(4, 22);
            this.tbAccountant.Name = "tbAccountant";
            this.tbAccountant.Padding = new System.Windows.Forms.Padding(3);
            this.tbAccountant.Size = new System.Drawing.Size(835, 116);
            this.tbAccountant.TabIndex = 1;
            this.tbAccountant.Text = "Escrítorio Contábil";
            // 
            // txtAccountant
            // 
            this.txtAccountant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccountant.Location = new System.Drawing.Point(80, 15);
            this.txtAccountant.Margin = new System.Windows.Forms.Padding(5);
            this.txtAccountant.MaxLength = 45;
            this.txtAccountant.Name = "txtAccountant";
            this.txtAccountant.Size = new System.Drawing.Size(190, 22);
            this.txtAccountant.TabIndex = 0;
            // 
            // labAccountant
            // 
            this.labAccountant.AutoSize = true;
            this.labAccountant.Location = new System.Drawing.Point(6, 18);
            this.labAccountant.Name = "labAccountant";
            this.labAccountant.Size = new System.Drawing.Size(66, 16);
            this.labAccountant.TabIndex = 44;
            this.labAccountant.Text = "Contador:";
            // 
            // txtAccountantEmail
            // 
            this.txtAccountantEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccountantEmail.Location = new System.Drawing.Point(80, 47);
            this.txtAccountantEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtAccountantEmail.MaxLength = 250;
            this.txtAccountantEmail.Name = "txtAccountantEmail";
            this.txtAccountantEmail.Size = new System.Drawing.Size(473, 22);
            this.txtAccountantEmail.TabIndex = 1;
            // 
            // labAcconuntantEmail
            // 
            this.labAcconuntantEmail.AutoSize = true;
            this.labAcconuntantEmail.Location = new System.Drawing.Point(27, 50);
            this.labAcconuntantEmail.Name = "labAcconuntantEmail";
            this.labAcconuntantEmail.Size = new System.Drawing.Size(45, 16);
            this.labAcconuntantEmail.TabIndex = 45;
            this.labAcconuntantEmail.Text = "Email:";
            // 
            // cbxProspecting
            // 
            this.cbxProspecting.AutoSize = true;
            this.cbxProspecting.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxProspecting.Location = new System.Drawing.Point(420, 71);
            this.cbxProspecting.Margin = new System.Windows.Forms.Padding(5);
            this.cbxProspecting.Name = "cbxProspecting";
            this.cbxProspecting.Size = new System.Drawing.Size(101, 20);
            this.cbxProspecting.TabIndex = 6;
            this.cbxProspecting.Text = "Prospecção";
            this.cbxProspecting.UseVisualStyleBackColor = true;
            // 
            // txtRazao
            // 
            this.txtRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazao.Location = new System.Drawing.Point(110, 40);
            this.txtRazao.Margin = new System.Windows.Forms.Padding(5);
            this.txtRazao.MaxLength = 250;
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(315, 22);
            this.txtRazao.TabIndex = 2;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(466, 46);
            this.labName.Margin = new System.Windows.Forms.Padding(5);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(63, 16);
            this.labName.TabIndex = 7;
            this.labName.Text = "Fantasia:";
            // 
            // labIE
            // 
            this.labIE.AutoSize = true;
            this.labIE.Location = new System.Drawing.Point(250, 75);
            this.labIE.Margin = new System.Windows.Forms.Padding(5);
            this.labIE.Name = "labIE";
            this.labIE.Size = new System.Drawing.Size(23, 16);
            this.labIE.TabIndex = 17;
            this.labIE.Text = "IE:";
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(539, 43);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.MaxLength = 250;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(315, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Info;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(684, 8);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(87, 22);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "0";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbCellphone
            // 
            this.mtbCellphone.Location = new System.Drawing.Point(283, 104);
            this.mtbCellphone.Margin = new System.Windows.Forms.Padding(5);
            this.mtbCellphone.Mask = "(99) 99999-9999";
            this.mtbCellphone.Name = "mtbCellphone";
            this.mtbCellphone.Size = new System.Drawing.Size(115, 22);
            this.mtbCellphone.TabIndex = 10;
            // 
            // txtResponsible
            // 
            this.txtResponsible.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResponsible.Location = new System.Drawing.Point(110, 8);
            this.txtResponsible.Margin = new System.Windows.Forms.Padding(5);
            this.txtResponsible.MaxLength = 45;
            this.txtResponsible.Name = "txtResponsible";
            this.txtResponsible.Size = new System.Drawing.Size(315, 22);
            this.txtResponsible.TabIndex = 0;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(408, 107);
            this.labEmail.Margin = new System.Windows.Forms.Padding(5);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(45, 16);
            this.labEmail.TabIndex = 13;
            this.labEmail.Text = "Email:";
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Location = new System.Drawing.Point(110, 72);
            this.mtbCNPJ.Margin = new System.Windows.Forms.Padding(5);
            this.mtbCNPJ.Mask = "99,999,999/9999-99";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(130, 22);
            this.mtbCNPJ.TabIndex = 4;
            this.mtbCNPJ.Validated += new System.EventHandler(this.mtbCNPJ_Validated);
            // 
            // labObs
            // 
            this.labObs.AutoSize = true;
            this.labObs.Location = new System.Drawing.Point(14, 139);
            this.labObs.Margin = new System.Windows.Forms.Padding(5);
            this.labObs.Name = "labObs";
            this.labObs.Size = new System.Drawing.Size(86, 16);
            this.labObs.TabIndex = 15;
            this.labObs.Text = "Observação:";
            // 
            // cbxIsInactive
            // 
            this.cbxIsInactive.AutoSize = true;
            this.cbxIsInactive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxIsInactive.Location = new System.Drawing.Point(779, 10);
            this.cbxIsInactive.Name = "cbxIsInactive";
            this.cbxIsInactive.Size = new System.Drawing.Size(66, 20);
            this.cbxIsInactive.TabIndex = 12;
            this.cbxIsInactive.Text = "Inativo";
            this.cbxIsInactive.UseVisualStyleBackColor = true;
            this.cbxIsInactive.CheckedChanged += new System.EventHandler(this.cbxIsInactive_CheckedChanged);
            // 
            // cbxFinancialPending
            // 
            this.cbxFinancialPending.AutoSize = true;
            this.cbxFinancialPending.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxFinancialPending.Location = new System.Drawing.Point(531, 74);
            this.cbxFinancialPending.Margin = new System.Windows.Forms.Padding(5);
            this.cbxFinancialPending.Name = "cbxFinancialPending";
            this.cbxFinancialPending.Size = new System.Drawing.Size(158, 20);
            this.cbxFinancialPending.TabIndex = 7;
            this.cbxFinancialPending.Text = "Pendência Financeira";
            this.cbxFinancialPending.UseVisualStyleBackColor = true;
            // 
            // labTelphone
            // 
            this.labTelphone.AutoSize = true;
            this.labTelphone.Location = new System.Drawing.Point(35, 107);
            this.labTelphone.Margin = new System.Windows.Forms.Padding(5);
            this.labTelphone.Name = "labTelphone";
            this.labTelphone.Size = new System.Drawing.Size(65, 16);
            this.labTelphone.TabIndex = 11;
            this.labTelphone.Text = "Telefone:";
            // 
            // labCNPJ
            // 
            this.labCNPJ.AutoSize = true;
            this.labCNPJ.Location = new System.Drawing.Point(54, 72);
            this.labCNPJ.Margin = new System.Windows.Forms.Padding(5);
            this.labCNPJ.Name = "labCNPJ";
            this.labCNPJ.Size = new System.Drawing.Size(46, 16);
            this.labCNPJ.TabIndex = 9;
            this.labCNPJ.Text = "CNPJ:";
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(110, 104);
            this.mtbTelephone.Margin = new System.Windows.Forms.Padding(5);
            this.mtbTelephone.Mask = "(99) 9999-9999";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(100, 22);
            this.mtbTelephone.TabIndex = 9;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(652, 11);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(24, 16);
            this.labID.TabIndex = 0;
            this.labID.Text = "ID:";
            // 
            // labCellphone
            // 
            this.labCellphone.AutoSize = true;
            this.labCellphone.Location = new System.Drawing.Point(220, 107);
            this.labCellphone.Margin = new System.Windows.Forms.Padding(5);
            this.labCellphone.Name = "labCellphone";
            this.labCellphone.Size = new System.Drawing.Size(53, 16);
            this.labCellphone.TabIndex = 20;
            this.labCellphone.Text = "Celular:";
            // 
            // labRazao
            // 
            this.labRazao.AutoSize = true;
            this.labRazao.Location = new System.Drawing.Point(49, 40);
            this.labRazao.Margin = new System.Windows.Forms.Padding(5);
            this.labRazao.Name = "labRazao";
            this.labRazao.Size = new System.Drawing.Size(51, 16);
            this.labRazao.TabIndex = 5;
            this.labRazao.Text = "Razão:";
            // 
            // mtbIE
            // 
            this.mtbIE.Location = new System.Drawing.Point(283, 72);
            this.mtbIE.Margin = new System.Windows.Forms.Padding(5);
            this.mtbIE.Mask = "999,999,999,999";
            this.mtbIE.Name = "mtbIE";
            this.mtbIE.Size = new System.Drawing.Size(108, 22);
            this.mtbIE.TabIndex = 5;
            // 
            // dtpSince
            // 
            this.dtpSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSince.Location = new System.Drawing.Point(539, 8);
            this.dtpSince.Margin = new System.Windows.Forms.Padding(5);
            this.dtpSince.Name = "dtpSince";
            this.dtpSince.Size = new System.Drawing.Size(105, 22);
            this.dtpSince.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(463, 104);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.MaxLength = 250;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(391, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // labSaved
            // 
            this.labSaved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labSaved.AutoSize = true;
            this.labSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.labSaved.Location = new System.Drawing.Point(12, 451);
            this.labSaved.Name = "labSaved";
            this.labSaved.Size = new System.Drawing.Size(155, 25);
            this.labSaved.TabIndex = 12;
            this.labSaved.Text = "Registro salvo!";
            this.labSaved.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(592, 450);
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
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(792, 450);
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
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(692, 450);
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
            this.btnClose.Location = new System.Drawing.Point(854, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labTitle
            // 
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(0, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(900, 42);
            this.labTitle.TabIndex = 5;
            this.labTitle.Text = "Cliente";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labTitle_MouseDown);
            // 
            // frmCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.pTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tbCustomer.ResumeLayout(false);
            this.tpCustomer.ResumeLayout(false);
            this.tpCustomer.PerformLayout();
            this.tcInfo.ResumeLayout(false);
            this.tpAddress.ResumeLayout(false);
            this.tpAddress.PerformLayout();
            this.tbProduct.ResumeLayout(false);
            this.tbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminals)).EndInit();
            this.tbAccountant.ResumeLayout(false);
            this.tbAccountant.PerformLayout();
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
        private System.Windows.Forms.CheckBox cbxInfoPending;
    }
}