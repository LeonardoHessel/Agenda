namespace Agenda
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.pForm = new System.Windows.Forms.Panel();
            this.labSaved = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.tcUser = new System.Windows.Forms.TabControl();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.btnDropIMG = new System.Windows.Forms.Button();
            this.btnAddIMG = new System.Windows.Forms.Button();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.btnQueryCEP = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.labState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.labCity = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.labDistrict = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.labCEP = new System.Windows.Forms.Label();
            this.labStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.labNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.gbDocs = new System.Windows.Forms.GroupBox();
            this.labCNH = new System.Windows.Forms.Label();
            this.txtCNH = new System.Windows.Forms.MaskedTextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.labSex = new System.Windows.Forms.Label();
            this.labCPF = new System.Windows.Forms.Label();
            this.labBorn = new System.Windows.Forms.Label();
            this.labRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.labLogin = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.cbxIsInactive = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tpAccess = new System.Windows.Forms.TabPage();
            this.labDev = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tShowSaved = new System.Windows.Forms.Timer(this.components);
            this.pForm.SuspendLayout();
            this.tcUser.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.gbDocs.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tpAccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // pForm
            // 
            this.pForm.BackColor = System.Drawing.Color.White;
            this.pForm.Controls.Add(this.labSaved);
            this.pForm.Controls.Add(this.btnNew);
            this.pForm.Controls.Add(this.tcUser);
            this.pForm.Controls.Add(this.btnCancel);
            this.pForm.Controls.Add(this.btnSave);
            this.pForm.Location = new System.Drawing.Point(1, 42);
            this.pForm.Name = "pForm";
            this.pForm.Size = new System.Drawing.Size(818, 483);
            this.pForm.TabIndex = 0;
            // 
            // labSaved
            // 
            this.labSaved.AutoSize = true;
            this.labSaved.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.labSaved.Location = new System.Drawing.Point(9, 443);
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
            this.btnNew.Location = new System.Drawing.Point(515, 442);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 30);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tcUser
            // 
            this.tcUser.Controls.Add(this.tpInfo);
            this.tcUser.Controls.Add(this.tpAccess);
            this.tcUser.Location = new System.Drawing.Point(13, 10);
            this.tcUser.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.tcUser.Name = "tcUser";
            this.tcUser.SelectedIndex = 0;
            this.tcUser.Size = new System.Drawing.Size(792, 422);
            this.tcUser.TabIndex = 0;
            // 
            // tpInfo
            // 
            this.tpInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tpInfo.Controls.Add(this.btnDropIMG);
            this.tpInfo.Controls.Add(this.btnAddIMG);
            this.tpInfo.Controls.Add(this.gbAddress);
            this.tpInfo.Controls.Add(this.gbDocs);
            this.tpInfo.Controls.Add(this.gbLogin);
            this.tpInfo.Controls.Add(this.gbInfo);
            this.tpInfo.Controls.Add(this.pbImage);
            this.tpInfo.Location = new System.Drawing.Point(4, 24);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(784, 394);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Informações";
            // 
            // btnDropIMG
            // 
            this.btnDropIMG.Enabled = false;
            this.btnDropIMG.FlatAppearance.BorderSize = 0;
            this.btnDropIMG.Location = new System.Drawing.Point(702, 232);
            this.btnDropIMG.Name = "btnDropIMG";
            this.btnDropIMG.Size = new System.Drawing.Size(75, 23);
            this.btnDropIMG.TabIndex = 6;
            this.btnDropIMG.Text = "Excluir";
            this.btnDropIMG.UseVisualStyleBackColor = true;
            // 
            // btnAddIMG
            // 
            this.btnAddIMG.Enabled = false;
            this.btnAddIMG.FlatAppearance.BorderSize = 0;
            this.btnAddIMG.Location = new System.Drawing.Point(602, 232);
            this.btnAddIMG.Name = "btnAddIMG";
            this.btnAddIMG.Size = new System.Drawing.Size(75, 23);
            this.btnAddIMG.TabIndex = 5;
            this.btnAddIMG.Text = "Adicionar";
            this.btnAddIMG.UseVisualStyleBackColor = true;
            // 
            // gbAddress
            // 
            this.gbAddress.Controls.Add(this.btnQueryCEP);
            this.gbAddress.Controls.Add(this.cbState);
            this.gbAddress.Controls.Add(this.labState);
            this.gbAddress.Controls.Add(this.txtCity);
            this.gbAddress.Controls.Add(this.labCity);
            this.gbAddress.Controls.Add(this.txtDistrict);
            this.gbAddress.Controls.Add(this.labDistrict);
            this.gbAddress.Controls.Add(this.txtCEP);
            this.gbAddress.Controls.Add(this.labCEP);
            this.gbAddress.Controls.Add(this.labStreet);
            this.gbAddress.Controls.Add(this.txtStreet);
            this.gbAddress.Controls.Add(this.labNumber);
            this.gbAddress.Controls.Add(this.txtNumber);
            this.gbAddress.Location = new System.Drawing.Point(6, 253);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Size = new System.Drawing.Size(771, 135);
            this.gbAddress.TabIndex = 3;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Endereço";
            // 
            // btnQueryCEP
            // 
            this.btnQueryCEP.FlatAppearance.BorderSize = 0;
            this.btnQueryCEP.Location = new System.Drawing.Point(177, 26);
            this.btnQueryCEP.Margin = new System.Windows.Forms.Padding(5);
            this.btnQueryCEP.Name = "btnQueryCEP";
            this.btnQueryCEP.Size = new System.Drawing.Size(102, 23);
            this.btnQueryCEP.TabIndex = 43;
            this.btnQueryCEP.Text = "Consulta CEP";
            this.btnQueryCEP.UseVisualStyleBackColor = true;
            this.btnQueryCEP.Click += new System.EventHandler(this.btnQueryCEP_Click);
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
            this.cbState.Location = new System.Drawing.Point(540, 29);
            this.cbState.Margin = new System.Windows.Forms.Padding(5);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(92, 23);
            this.cbState.TabIndex = 30;
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Location = new System.Drawing.Point(483, 32);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(49, 15);
            this.labState.TabIndex = 29;
            this.labState.Text = "Estado:";
            // 
            // txtCity
            // 
            this.txtCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCity.Location = new System.Drawing.Point(63, 59);
            this.txtCity.Margin = new System.Windows.Forms.Padding(5);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(416, 23);
            this.txtCity.TabIndex = 4;
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.Location = new System.Drawing.Point(6, 62);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(49, 15);
            this.labCity.TabIndex = 27;
            this.labCity.Text = "Cidade:";
            // 
            // txtDistrict
            // 
            this.txtDistrict.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDistrict.Location = new System.Drawing.Point(540, 62);
            this.txtDistrict.Margin = new System.Windows.Forms.Padding(5);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(223, 23);
            this.txtDistrict.TabIndex = 3;
            // 
            // labDistrict
            // 
            this.labDistrict.AutoSize = true;
            this.labDistrict.Location = new System.Drawing.Point(487, 65);
            this.labDistrict.Name = "labDistrict";
            this.labDistrict.Size = new System.Drawing.Size(45, 15);
            this.labDistrict.TabIndex = 25;
            this.labDistrict.Text = "Bairro:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(63, 26);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(5);
            this.txtCEP.Mask = "99,999-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(104, 23);
            this.txtCEP.TabIndex = 0;
            // 
            // labCEP
            // 
            this.labCEP.AutoSize = true;
            this.labCEP.Location = new System.Drawing.Point(6, 29);
            this.labCEP.Name = "labCEP";
            this.labCEP.Size = new System.Drawing.Size(33, 15);
            this.labCEP.TabIndex = 24;
            this.labCEP.Text = "CEP:";
            // 
            // labStreet
            // 
            this.labStreet.AutoSize = true;
            this.labStreet.Location = new System.Drawing.Point(6, 95);
            this.labStreet.Name = "labStreet";
            this.labStreet.Size = new System.Drawing.Size(32, 15);
            this.labStreet.TabIndex = 8;
            this.labStreet.Text = "Rua:";
            // 
            // txtStreet
            // 
            this.txtStreet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStreet.Location = new System.Drawing.Point(63, 92);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(5);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(416, 23);
            this.txtStreet.TabIndex = 1;
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Location = new System.Drawing.Point(508, 95);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(24, 15);
            this.labNumber.TabIndex = 10;
            this.labNumber.Text = "N°:";
            // 
            // txtNumber
            // 
            this.txtNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumber.Location = new System.Drawing.Point(540, 92);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(223, 23);
            this.txtNumber.TabIndex = 2;
            // 
            // gbDocs
            // 
            this.gbDocs.Controls.Add(this.labCNH);
            this.gbDocs.Controls.Add(this.txtCNH);
            this.gbDocs.Controls.Add(this.cbSex);
            this.gbDocs.Controls.Add(this.dtpBorn);
            this.gbDocs.Controls.Add(this.txtCPF);
            this.gbDocs.Controls.Add(this.labSex);
            this.gbDocs.Controls.Add(this.labCPF);
            this.gbDocs.Controls.Add(this.labBorn);
            this.gbDocs.Controls.Add(this.labRG);
            this.gbDocs.Controls.Add(this.txtRG);
            this.gbDocs.Location = new System.Drawing.Point(6, 150);
            this.gbDocs.Name = "gbDocs";
            this.gbDocs.Size = new System.Drawing.Size(589, 97);
            this.gbDocs.TabIndex = 2;
            this.gbDocs.TabStop = false;
            this.gbDocs.Text = "Documentos";
            // 
            // labCNH
            // 
            this.labCNH.AutoSize = true;
            this.labCNH.Location = new System.Drawing.Point(375, 60);
            this.labCNH.Name = "labCNH";
            this.labCNH.Size = new System.Drawing.Size(36, 15);
            this.labCNH.TabIndex = 22;
            this.labCNH.Text = "CNH:";
            // 
            // txtCNH
            // 
            this.txtCNH.Location = new System.Drawing.Point(419, 57);
            this.txtCNH.Margin = new System.Windows.Forms.Padding(5);
            this.txtCNH.Mask = "999 999 999 99";
            this.txtCNH.Name = "txtCNH";
            this.txtCNH.Size = new System.Drawing.Size(134, 23);
            this.txtCNH.TabIndex = 4;
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cbSex.Location = new System.Drawing.Point(63, 24);
            this.cbSex.Margin = new System.Windows.Forms.Padding(5);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(198, 23);
            this.cbSex.TabIndex = 1;
            // 
            // dtpBorn
            // 
            this.dtpBorn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorn.Location = new System.Drawing.Point(366, 21);
            this.dtpBorn.Margin = new System.Windows.Forms.Padding(5);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(134, 23);
            this.dtpBorn.TabIndex = 0;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(233, 57);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(5);
            this.txtCPF.Mask = "999,999,999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(134, 23);
            this.txtCPF.TabIndex = 3;
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Location = new System.Drawing.Point(6, 29);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(39, 15);
            this.labSex.TabIndex = 6;
            this.labSex.Text = "Sexo:";
            // 
            // labCPF
            // 
            this.labCPF.AutoSize = true;
            this.labCPF.Location = new System.Drawing.Point(192, 60);
            this.labCPF.Name = "labCPF";
            this.labCPF.Size = new System.Drawing.Size(33, 15);
            this.labCPF.TabIndex = 20;
            this.labCPF.Text = "CPF:";
            // 
            // labBorn
            // 
            this.labBorn.AutoSize = true;
            this.labBorn.Location = new System.Drawing.Point(285, 27);
            this.labBorn.Name = "labBorn";
            this.labBorn.Size = new System.Drawing.Size(73, 15);
            this.labBorn.TabIndex = 4;
            this.labBorn.Text = "Data Nasc.:";
            // 
            // labRG
            // 
            this.labRG.AutoSize = true;
            this.labRG.Location = new System.Drawing.Point(6, 60);
            this.labRG.Name = "labRG";
            this.labRG.Size = new System.Drawing.Size(27, 15);
            this.labRG.TabIndex = 18;
            this.labRG.Text = "RG:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(63, 57);
            this.txtRG.Margin = new System.Windows.Forms.Padding(5);
            this.txtRG.Mask = "99,999,999-9";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(121, 23);
            this.txtRG.TabIndex = 2;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnShowHide);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.txtLogin);
            this.gbLogin.Controls.Add(this.labPassword);
            this.gbLogin.Controls.Add(this.labLogin);
            this.gbLogin.Location = new System.Drawing.Point(6, 78);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(589, 66);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // btnShowHide
            // 
            this.btnShowHide.Enabled = false;
            this.btnShowHide.FlatAppearance.BorderSize = 0;
            this.btnShowHide.Image = ((System.Drawing.Image)(resources.GetObject("btnShowHide.Image")));
            this.btnShowHide.Location = new System.Drawing.Point(551, 24);
            this.btnShowHide.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(30, 23);
            this.btnShowHide.TabIndex = 44;
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(366, 24);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(175, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Enabled = false;
            this.txtLogin.Location = new System.Drawing.Point(63, 24);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(5);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(241, 23);
            this.txtLogin.TabIndex = 0;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Enabled = false;
            this.labPassword.Location = new System.Drawing.Point(312, 27);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(46, 15);
            this.labPassword.TabIndex = 6;
            this.labPassword.Text = "Senha:";
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Enabled = false;
            this.labLogin.Location = new System.Drawing.Point(6, 27);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(41, 15);
            this.labLogin.TabIndex = 4;
            this.labLogin.Text = "Login:";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.cbxIsInactive);
            this.gbInfo.Controls.Add(this.txtID);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.labID);
            this.gbInfo.Controls.Add(this.labName);
            this.gbInfo.Location = new System.Drawing.Point(6, 6);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(589, 66);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info. Basica";
            // 
            // cbxIsInactive
            // 
            this.cbxIsInactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxIsInactive.AutoSize = true;
            this.cbxIsInactive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxIsInactive.Location = new System.Drawing.Point(510, 26);
            this.cbxIsInactive.Name = "cbxIsInactive";
            this.cbxIsInactive.Size = new System.Drawing.Size(65, 19);
            this.cbxIsInactive.TabIndex = 2;
            this.cbxIsInactive.Text = "Inativo";
            this.cbxIsInactive.UseVisualStyleBackColor = true;
            this.cbxIsInactive.CheckedChanged += new System.EventHandler(this.cbxIsInactive_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Info;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Location = new System.Drawing.Point(402, 24);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "0";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(63, 24);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 23);
            this.txtName.TabIndex = 0;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(371, 27);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(23, 15);
            this.labID.TabIndex = 0;
            this.labID.Text = "ID:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(6, 27);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(44, 15);
            this.labName.TabIndex = 2;
            this.labName.Text = "Nome:";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Enabled = false;
            this.pbImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbImage.ErrorImage")));
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbImage.InitialImage")));
            this.pbImage.Location = new System.Drawing.Point(602, 6);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(175, 220);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // tpAccess
            // 
            this.tpAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tpAccess.Controls.Add(this.labDev);
            this.tpAccess.Location = new System.Drawing.Point(4, 22);
            this.tpAccess.Name = "tpAccess";
            this.tpAccess.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccess.Size = new System.Drawing.Size(784, 396);
            this.tpAccess.TabIndex = 1;
            this.tpAccess.Text = "Permissões";
            // 
            // labDev
            // 
            this.labDev.AutoSize = true;
            this.labDev.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDev.ForeColor = System.Drawing.Color.Silver;
            this.labDev.Location = new System.Drawing.Point(235, 155);
            this.labDev.Name = "labDev";
            this.labDev.Size = new System.Drawing.Size(322, 50);
            this.labDev.TabIndex = 0;
            this.labDev.Text = "Em desenvolvimento";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Roboto Bk", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(715, 442);
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
            this.btnSave.Location = new System.Drawing.Point(615, 442);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labTitle
            // 
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTitle.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(0, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(820, 42);
            this.labTitle.TabIndex = 3;
            this.labTitle.Text = "Técnico";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labTitle_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(774, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tShowSaved
            // 
            this.tShowSaved.Interval = 2000;
            this.tShowSaved.Tick += new System.EventHandler(this.tShowSaved_Tick);
            // 
            // frmUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(820, 526);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pForm);
            this.Controls.Add(this.labTitle);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Técnico";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUser_KeyDown);
            this.pForm.ResumeLayout(false);
            this.pForm.PerformLayout();
            this.tcUser.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.gbDocs.ResumeLayout(false);
            this.gbDocs.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tpAccess.ResumeLayout(false);
            this.tpAccess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pForm;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tcUser;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.TabPage tpAccess;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labCEP;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label labStreet;
        private System.Windows.Forms.MaskedTextBox txtCNH;
        private System.Windows.Forms.Label labCNH;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label labCPF;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.Label labRG;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.CheckBox cbxIsInactive;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.GroupBox gbDocs;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labBorn;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label labState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label labDistrict;
        private System.Windows.Forms.Label labDev;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Timer tShowSaved;
        private System.Windows.Forms.Label labSaved;
        private System.Windows.Forms.Button btnQueryCEP;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Button btnDropIMG;
        private System.Windows.Forms.Button btnAddIMG;
    }
}