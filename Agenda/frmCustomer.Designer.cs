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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.labTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pTitle = new System.Windows.Forms.Panel();
            this.labTitleProduct = new System.Windows.Forms.Label();
            this.labTitleAccountant = new System.Windows.Forms.Label();
            this.pProduct = new System.Windows.Forms.Panel();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.labTitleAddress = new System.Windows.Forms.Label();
            this.pAccountant = new System.Windows.Forms.Panel();
            this.labTitleInfo = new System.Windows.Forms.Label();
            this.pAddress = new System.Windows.Forms.Panel();
            this.txtState = new System.Windows.Forms.TextBox();
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
            this.pInfo = new System.Windows.Forms.Panel();
            this.labCellphone = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.txtIE = new System.Windows.Forms.MaskedTextBox();
            this.labIE = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.labObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labTelphone = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.labCNPJ = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labRazao = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.cbxIsInactive = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAccountantEmail = new System.Windows.Forms.TextBox();
            this.labAcconuntantEmail = new System.Windows.Forms.Label();
            this.txtAccountant = new System.Windows.Forms.TextBox();
            this.labAccountant = new System.Windows.Forms.Label();
            this.labModule = new System.Windows.Forms.Label();
            this.labProduct = new System.Windows.Forms.Label();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.pTitle.SuspendLayout();
            this.pProduct.SuspendLayout();
            this.pAccountant.SuspendLayout();
            this.pAddress.SuspendLayout();
            this.pInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(415, 14);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(70, 23);
            this.labTitle.TabIndex = 3;
            this.labTitle.Text = "Cliente";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(850, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.White;
            this.pTitle.Controls.Add(this.labTitleProduct);
            this.pTitle.Controls.Add(this.labTitleAccountant);
            this.pTitle.Controls.Add(this.pProduct);
            this.pTitle.Controls.Add(this.labTitleAddress);
            this.pTitle.Controls.Add(this.pAccountant);
            this.pTitle.Controls.Add(this.labTitleInfo);
            this.pTitle.Controls.Add(this.pAddress);
            this.pTitle.Controls.Add(this.pInfo);
            this.pTitle.Controls.Add(this.btnNew);
            this.pTitle.Controls.Add(this.btnCancel);
            this.pTitle.Controls.Add(this.btnSave);
            this.pTitle.Location = new System.Drawing.Point(0, 50);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(900, 600);
            this.pTitle.TabIndex = 4;
            // 
            // labTitleProduct
            // 
            this.labTitleProduct.AutoSize = true;
            this.labTitleProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labTitleProduct.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleProduct.Location = new System.Drawing.Point(85, 462);
            this.labTitleProduct.Name = "labTitleProduct";
            this.labTitleProduct.Padding = new System.Windows.Forms.Padding(3);
            this.labTitleProduct.Size = new System.Drawing.Size(60, 21);
            this.labTitleProduct.TabIndex = 11;
            this.labTitleProduct.Text = "Sistema";
            // 
            // labTitleAccountant
            // 
            this.labTitleAccountant.AutoSize = true;
            this.labTitleAccountant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labTitleAccountant.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleAccountant.Location = new System.Drawing.Point(85, 400);
            this.labTitleAccountant.Name = "labTitleAccountant";
            this.labTitleAccountant.Padding = new System.Windows.Forms.Padding(3);
            this.labTitleAccountant.Size = new System.Drawing.Size(68, 21);
            this.labTitleAccountant.TabIndex = 9;
            this.labTitleAccountant.Text = "Escritório";
            // 
            // pProduct
            // 
            this.pProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pProduct.Controls.Add(this.txtModule);
            this.pProduct.Controls.Add(this.labModule);
            this.pProduct.Controls.Add(this.cbProduct);
            this.pProduct.Controls.Add(this.labProduct);
            this.pProduct.Location = new System.Drawing.Point(85, 474);
            this.pProduct.Name = "pProduct";
            this.pProduct.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.pProduct.Size = new System.Drawing.Size(730, 61);
            this.pProduct.TabIndex = 10;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(129, 13);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(193, 23);
            this.cbProduct.TabIndex = 0;
            // 
            // labTitleAddress
            // 
            this.labTitleAddress.AutoSize = true;
            this.labTitleAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labTitleAddress.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleAddress.Location = new System.Drawing.Point(85, 307);
            this.labTitleAddress.Name = "labTitleAddress";
            this.labTitleAddress.Padding = new System.Windows.Forms.Padding(3);
            this.labTitleAddress.Size = new System.Drawing.Size(67, 21);
            this.labTitleAddress.TabIndex = 9;
            this.labTitleAddress.Text = "Endereço";
            // 
            // pAccountant
            // 
            this.pAccountant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pAccountant.Controls.Add(this.txtAccountantEmail);
            this.pAccountant.Controls.Add(this.txtAccountant);
            this.pAccountant.Controls.Add(this.labAcconuntantEmail);
            this.pAccountant.Controls.Add(this.labAccountant);
            this.pAccountant.Location = new System.Drawing.Point(85, 412);
            this.pAccountant.Name = "pAccountant";
            this.pAccountant.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.pAccountant.Size = new System.Drawing.Size(730, 47);
            this.pAccountant.TabIndex = 8;
            // 
            // labTitleInfo
            // 
            this.labTitleInfo.AutoSize = true;
            this.labTitleInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labTitleInfo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleInfo.Location = new System.Drawing.Point(85, 27);
            this.labTitleInfo.Name = "labTitleInfo";
            this.labTitleInfo.Padding = new System.Windows.Forms.Padding(3);
            this.labTitleInfo.Size = new System.Drawing.Size(86, 21);
            this.labTitleInfo.TabIndex = 7;
            this.labTitleInfo.Text = "Informações";
            // 
            // pAddress
            // 
            this.pAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pAddress.Controls.Add(this.txtState);
            this.pAddress.Controls.Add(this.labState);
            this.pAddress.Controls.Add(this.txtCity);
            this.pAddress.Controls.Add(this.labCity);
            this.pAddress.Controls.Add(this.txtDistrict);
            this.pAddress.Controls.Add(this.labDistrict);
            this.pAddress.Controls.Add(this.txtCEP);
            this.pAddress.Controls.Add(this.labCEP);
            this.pAddress.Controls.Add(this.labStreet);
            this.pAddress.Controls.Add(this.txtStreet);
            this.pAddress.Controls.Add(this.labNumber);
            this.pAddress.Controls.Add(this.txtNumber);
            this.pAddress.Location = new System.Drawing.Point(85, 319);
            this.pAddress.Name = "pAddress";
            this.pAddress.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.pAddress.Size = new System.Drawing.Size(730, 78);
            this.pAddress.TabIndex = 8;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(584, 40);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(103, 23);
            this.txtState.TabIndex = 35;
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Location = new System.Drawing.Point(530, 43);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(49, 15);
            this.labState.TabIndex = 41;
            this.labState.Text = "Estado:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(337, 40);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(187, 23);
            this.txtCity.TabIndex = 34;
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.Location = new System.Drawing.Point(282, 43);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(49, 15);
            this.labCity.TabIndex = 40;
            this.labCity.Text = "Cidade:";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(129, 40);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(147, 23);
            this.txtDistrict.TabIndex = 33;
            // 
            // labDistrict
            // 
            this.labDistrict.AutoSize = true;
            this.labDistrict.Location = new System.Drawing.Point(43, 43);
            this.labDistrict.Name = "labDistrict";
            this.labDistrict.Size = new System.Drawing.Size(45, 15);
            this.labDistrict.TabIndex = 39;
            this.labDistrict.Text = "Bairro:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(129, 11);
            this.txtCEP.Mask = "99,999-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(104, 23);
            this.txtCEP.TabIndex = 30;
            // 
            // labCEP
            // 
            this.labCEP.AutoSize = true;
            this.labCEP.Location = new System.Drawing.Point(43, 14);
            this.labCEP.Name = "labCEP";
            this.labCEP.Size = new System.Drawing.Size(33, 15);
            this.labCEP.TabIndex = 38;
            this.labCEP.Text = "CEP:";
            // 
            // labStreet
            // 
            this.labStreet.AutoSize = true;
            this.labStreet.Location = new System.Drawing.Point(239, 14);
            this.labStreet.Name = "labStreet";
            this.labStreet.Size = new System.Drawing.Size(32, 15);
            this.labStreet.TabIndex = 36;
            this.labStreet.Text = "Rua:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(277, 11);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(298, 23);
            this.txtStreet.TabIndex = 31;
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Location = new System.Drawing.Point(581, 14);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(24, 15);
            this.labNumber.TabIndex = 37;
            this.labNumber.Text = "N°:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(611, 11);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(76, 23);
            this.txtNumber.TabIndex = 32;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pInfo
            // 
            this.pInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pInfo.Controls.Add(this.labCellphone);
            this.pInfo.Controls.Add(this.txtCellphone);
            this.pInfo.Controls.Add(this.txtIE);
            this.pInfo.Controls.Add(this.labIE);
            this.pInfo.Controls.Add(this.txtCNPJ);
            this.pInfo.Controls.Add(this.labObs);
            this.pInfo.Controls.Add(this.txtObs);
            this.pInfo.Controls.Add(this.labEmail);
            this.pInfo.Controls.Add(this.txtEmail);
            this.pInfo.Controls.Add(this.labTelphone);
            this.pInfo.Controls.Add(this.txtTelephone);
            this.pInfo.Controls.Add(this.labCNPJ);
            this.pInfo.Controls.Add(this.labName);
            this.pInfo.Controls.Add(this.txtName);
            this.pInfo.Controls.Add(this.labRazao);
            this.pInfo.Controls.Add(this.txtRazao);
            this.pInfo.Controls.Add(this.cbxIsInactive);
            this.pInfo.Controls.Add(this.txtID);
            this.pInfo.Controls.Add(this.labID);
            this.pInfo.Location = new System.Drawing.Point(85, 39);
            this.pInfo.Name = "pInfo";
            this.pInfo.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.pInfo.Size = new System.Drawing.Size(730, 265);
            this.pInfo.TabIndex = 6;
            // 
            // labCellphone
            // 
            this.labCellphone.AutoSize = true;
            this.labCellphone.Location = new System.Drawing.Point(355, 131);
            this.labCellphone.Name = "labCellphone";
            this.labCellphone.Size = new System.Drawing.Size(50, 15);
            this.labCellphone.TabIndex = 20;
            this.labCellphone.Text = "Celular:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(424, 128);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(263, 23);
            this.txtCellphone.TabIndex = 19;
            // 
            // txtIE
            // 
            this.txtIE.Location = new System.Drawing.Point(424, 99);
            this.txtIE.Mask = "999,999,999";
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(100, 23);
            this.txtIE.TabIndex = 18;
            // 
            // labIE
            // 
            this.labIE.AutoSize = true;
            this.labIE.Location = new System.Drawing.Point(384, 102);
            this.labIE.Name = "labIE";
            this.labIE.Size = new System.Drawing.Size(21, 15);
            this.labIE.TabIndex = 17;
            this.labIE.Text = "IE:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(129, 99);
            this.txtCNPJ.Mask = "99,999,999/9999-99";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(147, 23);
            this.txtCNPJ.TabIndex = 16;
            // 
            // labObs
            // 
            this.labObs.AutoSize = true;
            this.labObs.Location = new System.Drawing.Point(43, 189);
            this.labObs.Name = "labObs";
            this.labObs.Size = new System.Drawing.Size(80, 15);
            this.labObs.TabIndex = 15;
            this.labObs.Text = "Observação:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(129, 186);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(558, 65);
            this.txtObs.TabIndex = 14;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(43, 160);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(41, 15);
            this.labEmail.TabIndex = 13;
            this.labEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(558, 23);
            this.txtEmail.TabIndex = 12;
            // 
            // labTelphone
            // 
            this.labTelphone.AutoSize = true;
            this.labTelphone.Location = new System.Drawing.Point(43, 131);
            this.labTelphone.Name = "labTelphone";
            this.labTelphone.Size = new System.Drawing.Size(60, 15);
            this.labTelphone.TabIndex = 11;
            this.labTelphone.Text = "Telefone:";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(129, 128);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(202, 23);
            this.txtTelephone.TabIndex = 10;
            // 
            // labCNPJ
            // 
            this.labCNPJ.AutoSize = true;
            this.labCNPJ.Location = new System.Drawing.Point(43, 102);
            this.labCNPJ.Name = "labCNPJ";
            this.labCNPJ.Size = new System.Drawing.Size(42, 15);
            this.labCNPJ.TabIndex = 9;
            this.labCNPJ.Text = "CNPJ:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(43, 73);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(59, 15);
            this.labName.TabIndex = 7;
            this.labName.Text = "Fantasia:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(558, 23);
            this.txtName.TabIndex = 6;
            // 
            // labRazao
            // 
            this.labRazao.AutoSize = true;
            this.labRazao.Location = new System.Drawing.Point(43, 44);
            this.labRazao.Name = "labRazao";
            this.labRazao.Size = new System.Drawing.Size(46, 15);
            this.labRazao.TabIndex = 5;
            this.labRazao.Text = "Razão:";
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(129, 41);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(558, 23);
            this.txtRazao.TabIndex = 4;
            // 
            // cbxIsInactive
            // 
            this.cbxIsInactive.AutoSize = true;
            this.cbxIsInactive.Location = new System.Drawing.Point(622, 14);
            this.cbxIsInactive.Name = "cbxIsInactive";
            this.cbxIsInactive.Size = new System.Drawing.Size(65, 19);
            this.cbxIsInactive.TabIndex = 2;
            this.cbxIsInactive.Text = "Inativo";
            this.cbxIsInactive.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(129, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 1;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(43, 15);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(23, 15);
            this.labID.TabIndex = 0;
            this.labID.Text = "ID:";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Roboto Bk", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(525, 552);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 30);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Roboto Bk", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(725, 552);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Roboto Bk", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(625, 552);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtAccountantEmail
            // 
            this.txtAccountantEmail.Location = new System.Drawing.Point(383, 11);
            this.txtAccountantEmail.Name = "txtAccountantEmail";
            this.txtAccountantEmail.Size = new System.Drawing.Size(304, 23);
            this.txtAccountantEmail.TabIndex = 43;
            // 
            // labAcconuntantEmail
            // 
            this.labAcconuntantEmail.AutoSize = true;
            this.labAcconuntantEmail.Location = new System.Drawing.Point(336, 14);
            this.labAcconuntantEmail.Name = "labAcconuntantEmail";
            this.labAcconuntantEmail.Size = new System.Drawing.Size(41, 15);
            this.labAcconuntantEmail.TabIndex = 45;
            this.labAcconuntantEmail.Text = "Email:";
            // 
            // txtAccountant
            // 
            this.txtAccountant.Location = new System.Drawing.Point(129, 11);
            this.txtAccountant.Name = "txtAccountant";
            this.txtAccountant.Size = new System.Drawing.Size(193, 23);
            this.txtAccountant.TabIndex = 42;
            // 
            // labAccountant
            // 
            this.labAccountant.AutoSize = true;
            this.labAccountant.Location = new System.Drawing.Point(43, 14);
            this.labAccountant.Name = "labAccountant";
            this.labAccountant.Size = new System.Drawing.Size(62, 15);
            this.labAccountant.TabIndex = 44;
            this.labAccountant.Text = "Contador:";
            // 
            // labModule
            // 
            this.labModule.AutoSize = true;
            this.labModule.Location = new System.Drawing.Point(340, 16);
            this.labModule.Name = "labModule";
            this.labModule.Size = new System.Drawing.Size(52, 15);
            this.labModule.TabIndex = 47;
            this.labModule.Text = "Modulo:";
            // 
            // labProduct
            // 
            this.labProduct.AutoSize = true;
            this.labProduct.Location = new System.Drawing.Point(43, 16);
            this.labProduct.Name = "labProduct";
            this.labProduct.Size = new System.Drawing.Size(57, 15);
            this.labProduct.TabIndex = 46;
            this.labProduct.Text = "Sistema:";
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(398, 13);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(289, 23);
            this.txtModule.TabIndex = 46;
            // 
            // frmCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.ControlBox = false;
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.pProduct.ResumeLayout(false);
            this.pProduct.PerformLayout();
            this.pAccountant.ResumeLayout(false);
            this.pAccountant.PerformLayout();
            this.pAddress.ResumeLayout(false);
            this.pAddress.PerformLayout();
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Label labTitleInfo;
        private System.Windows.Forms.Label labTitleProduct;
        private System.Windows.Forms.Label labTitleAccountant;
        private System.Windows.Forms.Panel pProduct;
        private System.Windows.Forms.Label labTitleAddress;
        private System.Windows.Forms.Panel pAccountant;
        private System.Windows.Forms.Panel pAddress;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.CheckBox cbxIsInactive;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labCellphone;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.MaskedTextBox txtIE;
        private System.Windows.Forms.Label labIE;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label labObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labTelphone;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label labCNPJ;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labRazao;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label labState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label labDistrict;
        private System.Windows.Forms.MaskedTextBox txtCEP;
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
    }
}