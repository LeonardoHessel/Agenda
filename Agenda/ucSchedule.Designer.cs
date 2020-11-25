namespace Agenda
{
    partial class ucSchedule
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSchedule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pTitle = new System.Windows.Forms.Panel();
            this.labTitle = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pbSearchImage = new System.Windows.Forms.PictureBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerRazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerComponents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWhoRequested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsInactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.labStatusFilter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labAfter = new System.Windows.Forms.Label();
            this.dtpAfter = new System.Windows.Forms.DateTimePicker();
            this.dtpBefore = new System.Windows.Forms.DateTimePicker();
            this.labBefore = new System.Windows.Forms.Label();
            this.labCaption = new System.Windows.Forms.Label();
            this.labStatusBlue = new System.Windows.Forms.Label();
            this.pbStatusBlue = new System.Windows.Forms.PictureBox();
            this.pbStatusRed = new System.Windows.Forms.PictureBox();
            this.labStatusRed = new System.Windows.Forms.Label();
            this.pbStatusYellow = new System.Windows.Forms.PictureBox();
            this.labStatusYellow = new System.Windows.Forms.Label();
            this.pbStatusGreen = new System.Windows.Forms.PictureBox();
            this.labStatusGreen = new System.Windows.Forms.Label();
            this.pTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.pTitle.Controls.Add(this.labTitle);
            this.pTitle.Controls.Add(this.btnHide);
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(1100, 60);
            this.pTitle.TabIndex = 8;
            // 
            // labTitle
            // 
            this.labTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Roboto Bk", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(505, 16);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(90, 28);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Agenda";
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            this.btnHide.Location = new System.Drawing.Point(1030, 0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(70, 60);
            this.btnHide.TabIndex = 0;
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Location = new System.Drawing.Point(111, 131);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(430, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.Search_Changed);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.labSearch.Location = new System.Drawing.Point(108, 115);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(345, 15);
            this.labSearch.TabIndex = 3;
            this.labSearch.Text = "Pesquise por razão, fantasia, assunto, descrição, solução...";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Roboto Bk", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(26, 220);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.EditServiceOrder);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Roboto Bk", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(134, 220);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 35);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pbSearchImage
            // 
            this.pbSearchImage.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchImage.Image")));
            this.pbSearchImage.Location = new System.Drawing.Point(30, 90);
            this.pbSearchImage.Name = "pbSearchImage";
            this.pbSearchImage.Size = new System.Drawing.Size(64, 64);
            this.pbSearchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchImage.TabIndex = 6;
            this.pbSearchImage.TabStop = false;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.ColumnHeadersHeight = 35;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCustomerRazao,
            this.colCustomerCNPJ,
            this.colSubject,
            this.colProductName,
            this.colCustomerComponents,
            this.colStatus,
            this.colStart,
            this.colEnd,
            this.colUserName,
            this.colCustomer,
            this.colWhoRequested,
            this.colUser,
            this.colDescription,
            this.colSolution,
            this.colProduct,
            this.colService,
            this.colCreation,
            this.colIsInactive});
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvData.Location = new System.Drawing.Point(0, 279);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvData.RowTemplate.Height = 35;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1100, 745);
            this.dgvData.TabIndex = 7;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditServiceOrder);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 50;
            // 
            // colCustomerRazao
            // 
            this.colCustomerRazao.DataPropertyName = "CustomerRazao";
            this.colCustomerRazao.HeaderText = "Razão";
            this.colCustomerRazao.Name = "colCustomerRazao";
            this.colCustomerRazao.ReadOnly = true;
            this.colCustomerRazao.Width = 200;
            // 
            // colCustomerCNPJ
            // 
            this.colCustomerCNPJ.DataPropertyName = "CustomerCNPJ";
            this.colCustomerCNPJ.HeaderText = "CNPJ";
            this.colCustomerCNPJ.Name = "colCustomerCNPJ";
            this.colCustomerCNPJ.ReadOnly = true;
            this.colCustomerCNPJ.Width = 125;
            // 
            // colSubject
            // 
            this.colSubject.DataPropertyName = "Subject";
            this.colSubject.HeaderText = "Assunto";
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            this.colSubject.Width = 150;
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.HeaderText = "Sistema";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colCustomerComponents
            // 
            this.colCustomerComponents.DataPropertyName = "CustomerComponents";
            this.colCustomerComponents.HeaderText = "Modulos";
            this.colCustomerComponents.Name = "colCustomerComponents";
            this.colCustomerComponents.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colStart
            // 
            this.colStart.DataPropertyName = "Start";
            this.colStart.HeaderText = "Início";
            this.colStart.Name = "colStart";
            this.colStart.ReadOnly = true;
            this.colStart.Width = 110;
            // 
            // colEnd
            // 
            this.colEnd.DataPropertyName = "End";
            this.colEnd.HeaderText = "Final";
            this.colEnd.Name = "colEnd";
            this.colEnd.ReadOnly = true;
            this.colEnd.Width = 110;
            // 
            // colUserName
            // 
            this.colUserName.DataPropertyName = "UserName";
            this.colUserName.HeaderText = "Técnico";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            // 
            // colCustomer
            // 
            this.colCustomer.DataPropertyName = "Customer";
            this.colCustomer.HeaderText = "Cliente";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            this.colCustomer.Visible = false;
            // 
            // colWhoRequested
            // 
            this.colWhoRequested.DataPropertyName = "WhoRequested";
            this.colWhoRequested.HeaderText = "Solicitante";
            this.colWhoRequested.Name = "colWhoRequested";
            this.colWhoRequested.ReadOnly = true;
            this.colWhoRequested.Visible = false;
            // 
            // colUser
            // 
            this.colUser.DataPropertyName = "User";
            this.colUser.HeaderText = "Usuário";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            this.colUser.Visible = false;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Descrição";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Visible = false;
            // 
            // colSolution
            // 
            this.colSolution.DataPropertyName = "Solution";
            this.colSolution.HeaderText = "Solução";
            this.colSolution.Name = "colSolution";
            this.colSolution.ReadOnly = true;
            this.colSolution.Visible = false;
            // 
            // colProduct
            // 
            this.colProduct.DataPropertyName = "Product";
            this.colProduct.HeaderText = "Produto";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            this.colProduct.Visible = false;
            // 
            // colService
            // 
            this.colService.DataPropertyName = "Service";
            this.colService.HeaderText = "Atendimento";
            this.colService.Name = "colService";
            this.colService.ReadOnly = true;
            this.colService.Visible = false;
            // 
            // colCreation
            // 
            this.colCreation.DataPropertyName = "Creation";
            this.colCreation.HeaderText = "Criação";
            this.colCreation.Name = "colCreation";
            this.colCreation.ReadOnly = true;
            this.colCreation.Visible = false;
            // 
            // colIsInactive
            // 
            this.colIsInactive.DataPropertyName = "IsInactive";
            this.colIsInactive.HeaderText = "Inativo";
            this.colIsInactive.Name = "colIsInactive";
            this.colIsInactive.ReadOnly = true;
            this.colIsInactive.Visible = false;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Todos",
            "Agendado",
            "Cancelado",
            "Finalizado",
            "Pendente"});
            this.cbStatus.Location = new System.Drawing.Point(568, 100);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(150, 23);
            this.cbStatus.TabIndex = 1;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.Search_Changed);
            // 
            // cbUser
            // 
            this.cbUser.DisplayMember = "Login";
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(568, 144);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(150, 23);
            this.cbUser.TabIndex = 2;
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.Search_Changed);
            // 
            // labStatusFilter
            // 
            this.labStatusFilter.AutoSize = true;
            this.labStatusFilter.Location = new System.Drawing.Point(565, 82);
            this.labStatusFilter.Name = "labStatusFilter";
            this.labStatusFilter.Size = new System.Drawing.Size(101, 15);
            this.labStatusFilter.TabIndex = 12;
            this.labStatusFilter.Text = "Filtro por Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filtro por Técnico:";
            // 
            // labAfter
            // 
            this.labAfter.AutoSize = true;
            this.labAfter.Location = new System.Drawing.Point(565, 170);
            this.labAfter.Name = "labAfter";
            this.labAfter.Size = new System.Drawing.Size(52, 15);
            this.labAfter.TabIndex = 14;
            this.labAfter.Text = "A partir:";
            // 
            // dtpAfter
            // 
            this.dtpAfter.Checked = false;
            this.dtpAfter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAfter.Location = new System.Drawing.Point(568, 189);
            this.dtpAfter.Name = "dtpAfter";
            this.dtpAfter.ShowCheckBox = true;
            this.dtpAfter.Size = new System.Drawing.Size(150, 23);
            this.dtpAfter.TabIndex = 3;
            this.dtpAfter.ValueChanged += new System.EventHandler(this.Search_Changed);
            // 
            // dtpBefore
            // 
            this.dtpBefore.Checked = false;
            this.dtpBefore.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBefore.Location = new System.Drawing.Point(568, 234);
            this.dtpBefore.Name = "dtpBefore";
            this.dtpBefore.ShowCheckBox = true;
            this.dtpBefore.Size = new System.Drawing.Size(150, 23);
            this.dtpBefore.TabIndex = 4;
            this.dtpBefore.ValueChanged += new System.EventHandler(this.Search_Changed);
            // 
            // labBefore
            // 
            this.labBefore.AutoSize = true;
            this.labBefore.Location = new System.Drawing.Point(565, 215);
            this.labBefore.Name = "labBefore";
            this.labBefore.Size = new System.Drawing.Size(29, 15);
            this.labBefore.TabIndex = 16;
            this.labBefore.Text = "Até:";
            // 
            // labCaption
            // 
            this.labCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labCaption.AutoSize = true;
            this.labCaption.Location = new System.Drawing.Point(983, 115);
            this.labCaption.Name = "labCaption";
            this.labCaption.Size = new System.Drawing.Size(59, 15);
            this.labCaption.TabIndex = 17;
            this.labCaption.Text = "Legenda:";
            // 
            // labStatusBlue
            // 
            this.labStatusBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labStatusBlue.AutoSize = true;
            this.labStatusBlue.Location = new System.Drawing.Point(1007, 137);
            this.labStatusBlue.Name = "labStatusBlue";
            this.labStatusBlue.Size = new System.Drawing.Size(64, 15);
            this.labStatusBlue.TabIndex = 18;
            this.labStatusBlue.Text = "Agendado";
            // 
            // pbStatusBlue
            // 
            this.pbStatusBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbStatusBlue.Image = ((System.Drawing.Image)(resources.GetObject("pbStatusBlue.Image")));
            this.pbStatusBlue.Location = new System.Drawing.Point(986, 137);
            this.pbStatusBlue.Name = "pbStatusBlue";
            this.pbStatusBlue.Size = new System.Drawing.Size(15, 15);
            this.pbStatusBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStatusBlue.TabIndex = 19;
            this.pbStatusBlue.TabStop = false;
            // 
            // pbStatusRed
            // 
            this.pbStatusRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbStatusRed.Image = ((System.Drawing.Image)(resources.GetObject("pbStatusRed.Image")));
            this.pbStatusRed.Location = new System.Drawing.Point(986, 158);
            this.pbStatusRed.Name = "pbStatusRed";
            this.pbStatusRed.Size = new System.Drawing.Size(15, 15);
            this.pbStatusRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStatusRed.TabIndex = 21;
            this.pbStatusRed.TabStop = false;
            // 
            // labStatusRed
            // 
            this.labStatusRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labStatusRed.AutoSize = true;
            this.labStatusRed.Location = new System.Drawing.Point(1007, 158);
            this.labStatusRed.Name = "labStatusRed";
            this.labStatusRed.Size = new System.Drawing.Size(67, 15);
            this.labStatusRed.TabIndex = 20;
            this.labStatusRed.Text = "Cancelado";
            // 
            // pbStatusYellow
            // 
            this.pbStatusYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbStatusYellow.Image = ((System.Drawing.Image)(resources.GetObject("pbStatusYellow.Image")));
            this.pbStatusYellow.Location = new System.Drawing.Point(986, 200);
            this.pbStatusYellow.Name = "pbStatusYellow";
            this.pbStatusYellow.Size = new System.Drawing.Size(15, 15);
            this.pbStatusYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStatusYellow.TabIndex = 25;
            this.pbStatusYellow.TabStop = false;
            // 
            // labStatusYellow
            // 
            this.labStatusYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labStatusYellow.AutoSize = true;
            this.labStatusYellow.Location = new System.Drawing.Point(1007, 200);
            this.labStatusYellow.Name = "labStatusYellow";
            this.labStatusYellow.Size = new System.Drawing.Size(61, 15);
            this.labStatusYellow.TabIndex = 24;
            this.labStatusYellow.Text = "Pendente";
            // 
            // pbStatusGreen
            // 
            this.pbStatusGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbStatusGreen.Image = ((System.Drawing.Image)(resources.GetObject("pbStatusGreen.Image")));
            this.pbStatusGreen.Location = new System.Drawing.Point(986, 179);
            this.pbStatusGreen.Name = "pbStatusGreen";
            this.pbStatusGreen.Size = new System.Drawing.Size(15, 15);
            this.pbStatusGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStatusGreen.TabIndex = 23;
            this.pbStatusGreen.TabStop = false;
            // 
            // labStatusGreen
            // 
            this.labStatusGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labStatusGreen.AutoSize = true;
            this.labStatusGreen.Location = new System.Drawing.Point(1007, 179);
            this.labStatusGreen.Name = "labStatusGreen";
            this.labStatusGreen.Size = new System.Drawing.Size(65, 15);
            this.labStatusGreen.TabIndex = 22;
            this.labStatusGreen.Text = "Finalizado";
            // 
            // ucSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbStatusYellow);
            this.Controls.Add(this.labStatusYellow);
            this.Controls.Add(this.pbStatusGreen);
            this.Controls.Add(this.labStatusGreen);
            this.Controls.Add(this.pbStatusRed);
            this.Controls.Add(this.labStatusRed);
            this.Controls.Add(this.pbStatusBlue);
            this.Controls.Add(this.labStatusBlue);
            this.Controls.Add(this.labCaption);
            this.Controls.Add(this.dtpBefore);
            this.Controls.Add(this.labBefore);
            this.Controls.Add(this.dtpAfter);
            this.Controls.Add(this.labAfter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labStatusFilter);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pbSearchImage);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pTitle);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucSchedule";
            this.Size = new System.Drawing.Size(1100, 1024);
            this.Load += new System.EventHandler(this.ucSchedule_Load);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pbSearchImage;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label labStatusFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labAfter;
        private System.Windows.Forms.DateTimePicker dtpAfter;
        private System.Windows.Forms.DateTimePicker dtpBefore;
        private System.Windows.Forms.Label labBefore;
        private System.Windows.Forms.Label labCaption;
        private System.Windows.Forms.Label labStatusBlue;
        private System.Windows.Forms.PictureBox pbStatusBlue;
        private System.Windows.Forms.PictureBox pbStatusRed;
        private System.Windows.Forms.Label labStatusRed;
        private System.Windows.Forms.PictureBox pbStatusYellow;
        private System.Windows.Forms.Label labStatusYellow;
        private System.Windows.Forms.PictureBox pbStatusGreen;
        private System.Windows.Forms.Label labStatusGreen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerRazao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerComponents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhoRequested;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsInactive;
    }
}
