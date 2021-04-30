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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWhoLaunched = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.labStatus = new System.Windows.Forms.Label();
            this.labUser = new System.Windows.Forms.Label();
            this.labAfter = new System.Windows.Forms.Label();
            this.dtpAfter = new System.Windows.Forms.DateTimePicker();
            this.dtpBefore = new System.Windows.Forms.DateTimePicker();
            this.labBefore = new System.Windows.Forms.Label();
            this.labGreen = new System.Windows.Forms.Label();
            this.labYellow = new System.Windows.Forms.Label();
            this.labBabyBlue = new System.Windows.Forms.Label();
            this.labRed = new System.Windows.Forms.Label();
            this.pGreen = new System.Windows.Forms.Panel();
            this.labSTGreen = new System.Windows.Forms.Label();
            this.labTGreen = new System.Windows.Forms.Label();
            this.pBlue = new System.Windows.Forms.Panel();
            this.labSTBlue = new System.Windows.Forms.Label();
            this.labTBlue = new System.Windows.Forms.Label();
            this.pYellow = new System.Windows.Forms.Panel();
            this.labSTYellow = new System.Windows.Forms.Label();
            this.labTYellow = new System.Windows.Forms.Label();
            this.pRed = new System.Windows.Forms.Panel();
            this.labSTRed = new System.Windows.Forms.Label();
            this.labTRed = new System.Windows.Forms.Label();
            this.pAll = new System.Windows.Forms.Panel();
            this.labTAll = new System.Windows.Forms.Label();
            this.labSTall = new System.Windows.Forms.Label();
            this.labAll = new System.Windows.Forms.Label();
            this.cbxPreViewSO = new System.Windows.Forms.CheckBox();
            this.pBackground = new System.Windows.Forms.Panel();
            this.flpPreviewSO = new System.Windows.Forms.FlowLayoutPanel();
            this.pStrutA = new System.Windows.Forms.Panel();
            this.labSubject = new System.Windows.Forms.Label();
            this.labDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.pStrutB = new System.Windows.Forms.Panel();
            this.labID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labSolution = new System.Windows.Forms.Label();
            this.txtSolution = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pGreen.SuspendLayout();
            this.pBlue.SuspendLayout();
            this.pYellow.SuspendLayout();
            this.pRed.SuspendLayout();
            this.pAll.SuspendLayout();
            this.pBackground.SuspendLayout();
            this.flpPreviewSO.SuspendLayout();
            this.pStrutA.SuspendLayout();
            this.pStrutB.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Location = new System.Drawing.Point(89, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.Search_Changed);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.labSearch.Location = new System.Drawing.Point(86, 15);
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
            this.btnEdit.Location = new System.Drawing.Point(26, 156);
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
            this.btnNew.Location = new System.Drawing.Point(134, 156);
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
            this.pbSearchImage.Location = new System.Drawing.Point(13, 13);
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
            this.dgvData.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.colUserName,
            this.colStart,
            this.colEnd,
            this.colWhoLaunched,
            this.colCustomer,
            this.colWhoRequested,
            this.colUser,
            this.colDescription,
            this.colSolution,
            this.colProduct,
            this.colService,
            this.colCreation,
            this.colIsInactive});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvData.RowTemplate.Height = 35;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(800, 202);
            this.dgvData.TabIndex = 7;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditServiceOrder);
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
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
            // colUserName
            // 
            this.colUserName.DataPropertyName = "UserName";
            this.colUserName.HeaderText = "Técnico";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
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
            // colWhoLaunched
            // 
            this.colWhoLaunched.DataPropertyName = "WhoLaunched";
            this.colWhoLaunched.HeaderText = "Quem Lançou";
            this.colWhoLaunched.Name = "colWhoLaunched";
            this.colWhoLaunched.ReadOnly = true;
            this.colWhoLaunched.Visible = false;
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
            "Finalizado",
            "Pendente",
            "Atrasado"});
            this.cbStatus.Location = new System.Drawing.Point(445, 31);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(150, 23);
            this.cbStatus.TabIndex = 1;
            this.cbStatus.Visible = false;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.Search_Changed);
            // 
            // cbUser
            // 
            this.cbUser.DisplayMember = "Login";
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(89, 75);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(150, 23);
            this.cbUser.TabIndex = 2;
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.Search_Changed);
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.labStatus.Location = new System.Drawing.Point(442, 13);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(47, 15);
            this.labStatus.TabIndex = 12;
            this.labStatus.Text = "Status:";
            this.labStatus.Visible = false;
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.labUser.Location = new System.Drawing.Point(86, 57);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(56, 15);
            this.labUser.TabIndex = 13;
            this.labUser.Text = "Técnico:";
            // 
            // labAfter
            // 
            this.labAfter.AutoSize = true;
            this.labAfter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.labAfter.Location = new System.Drawing.Point(242, 57);
            this.labAfter.Name = "labAfter";
            this.labAfter.Size = new System.Drawing.Size(52, 15);
            this.labAfter.TabIndex = 14;
            this.labAfter.Text = "A partir:";
            // 
            // dtpAfter
            // 
            this.dtpAfter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAfter.Location = new System.Drawing.Point(245, 75);
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
            this.dtpBefore.Location = new System.Drawing.Point(401, 75);
            this.dtpBefore.Name = "dtpBefore";
            this.dtpBefore.ShowCheckBox = true;
            this.dtpBefore.Size = new System.Drawing.Size(150, 23);
            this.dtpBefore.TabIndex = 4;
            this.dtpBefore.ValueChanged += new System.EventHandler(this.Search_Changed);
            // 
            // labBefore
            // 
            this.labBefore.AutoSize = true;
            this.labBefore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.labBefore.Location = new System.Drawing.Point(400, 57);
            this.labBefore.Name = "labBefore";
            this.labBefore.Size = new System.Drawing.Size(29, 15);
            this.labBefore.TabIndex = 16;
            this.labBefore.Text = "Até:";
            // 
            // labGreen
            // 
            this.labGreen.AutoSize = true;
            this.labGreen.Location = new System.Drawing.Point(3, 5);
            this.labGreen.Name = "labGreen";
            this.labGreen.Size = new System.Drawing.Size(64, 15);
            this.labGreen.TabIndex = 18;
            this.labGreen.Text = "Agendado";
            this.labGreen.Click += new System.EventHandler(this.pGreen_Click);
            // 
            // labYellow
            // 
            this.labYellow.AutoSize = true;
            this.labYellow.Location = new System.Drawing.Point(3, 5);
            this.labYellow.Name = "labYellow";
            this.labYellow.Size = new System.Drawing.Size(61, 15);
            this.labYellow.TabIndex = 24;
            this.labYellow.Text = "Pendente";
            this.labYellow.Click += new System.EventHandler(this.pYellow_Click);
            // 
            // labBabyBlue
            // 
            this.labBabyBlue.AutoSize = true;
            this.labBabyBlue.Location = new System.Drawing.Point(3, 5);
            this.labBabyBlue.Name = "labBabyBlue";
            this.labBabyBlue.Size = new System.Drawing.Size(65, 15);
            this.labBabyBlue.TabIndex = 22;
            this.labBabyBlue.Text = "Finalizado";
            this.labBabyBlue.Click += new System.EventHandler(this.pBlue_Click);
            // 
            // labRed
            // 
            this.labRed.AutoSize = true;
            this.labRed.Location = new System.Drawing.Point(3, 5);
            this.labRed.Name = "labRed";
            this.labRed.Size = new System.Drawing.Size(59, 15);
            this.labRed.TabIndex = 20;
            this.labRed.Text = "Atrasado";
            this.labRed.Click += new System.EventHandler(this.pRed_Click);
            // 
            // pGreen
            // 
            this.pGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(254)))), ((int)(((byte)(90)))));
            this.pGreen.Controls.Add(this.labSTGreen);
            this.pGreen.Controls.Add(this.labTGreen);
            this.pGreen.Controls.Add(this.labGreen);
            this.pGreen.Location = new System.Drawing.Point(248, 132);
            this.pGreen.Name = "pGreen";
            this.pGreen.Size = new System.Drawing.Size(80, 80);
            this.pGreen.TabIndex = 26;
            this.pGreen.Click += new System.EventHandler(this.pGreen_Click);
            // 
            // labSTGreen
            // 
            this.labSTGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labSTGreen.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSTGreen.Location = new System.Drawing.Point(0, 47);
            this.labSTGreen.Name = "labSTGreen";
            this.labSTGreen.Size = new System.Drawing.Size(80, 33);
            this.labSTGreen.TabIndex = 29;
            this.labSTGreen.Text = "0";
            this.labSTGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labSTGreen.Click += new System.EventHandler(this.pGreen_Click);
            // 
            // labTGreen
            // 
            this.labTGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labTGreen.Location = new System.Drawing.Point(0, 25);
            this.labTGreen.Name = "labTGreen";
            this.labTGreen.Size = new System.Drawing.Size(80, 15);
            this.labTGreen.TabIndex = 28;
            this.labTGreen.Text = "0";
            this.labTGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labTGreen.Click += new System.EventHandler(this.pGreen_Click);
            // 
            // pBlue
            // 
            this.pBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pBlue.Controls.Add(this.labSTBlue);
            this.pBlue.Controls.Add(this.labTBlue);
            this.pBlue.Controls.Add(this.labBabyBlue);
            this.pBlue.Location = new System.Drawing.Point(334, 132);
            this.pBlue.Name = "pBlue";
            this.pBlue.Size = new System.Drawing.Size(80, 80);
            this.pBlue.TabIndex = 30;
            this.pBlue.Click += new System.EventHandler(this.pBlue_Click);
            // 
            // labSTBlue
            // 
            this.labSTBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labSTBlue.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSTBlue.Location = new System.Drawing.Point(0, 47);
            this.labSTBlue.Name = "labSTBlue";
            this.labSTBlue.Size = new System.Drawing.Size(80, 33);
            this.labSTBlue.TabIndex = 29;
            this.labSTBlue.Text = "0";
            this.labSTBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labSTBlue.Click += new System.EventHandler(this.pBlue_Click);
            // 
            // labTBlue
            // 
            this.labTBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labTBlue.Location = new System.Drawing.Point(0, 25);
            this.labTBlue.Name = "labTBlue";
            this.labTBlue.Size = new System.Drawing.Size(80, 15);
            this.labTBlue.TabIndex = 28;
            this.labTBlue.Text = "0";
            this.labTBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labTBlue.Click += new System.EventHandler(this.pBlue_Click);
            // 
            // pYellow
            // 
            this.pYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(86)))));
            this.pYellow.Controls.Add(this.labSTYellow);
            this.pYellow.Controls.Add(this.labTYellow);
            this.pYellow.Controls.Add(this.labYellow);
            this.pYellow.Location = new System.Drawing.Point(420, 132);
            this.pYellow.Name = "pYellow";
            this.pYellow.Size = new System.Drawing.Size(80, 80);
            this.pYellow.TabIndex = 31;
            this.pYellow.Click += new System.EventHandler(this.pYellow_Click);
            // 
            // labSTYellow
            // 
            this.labSTYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labSTYellow.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSTYellow.Location = new System.Drawing.Point(0, 47);
            this.labSTYellow.Name = "labSTYellow";
            this.labSTYellow.Size = new System.Drawing.Size(80, 33);
            this.labSTYellow.TabIndex = 29;
            this.labSTYellow.Text = "0";
            this.labSTYellow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labSTYellow.Click += new System.EventHandler(this.pYellow_Click);
            // 
            // labTYellow
            // 
            this.labTYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labTYellow.Location = new System.Drawing.Point(0, 25);
            this.labTYellow.Name = "labTYellow";
            this.labTYellow.Size = new System.Drawing.Size(80, 15);
            this.labTYellow.TabIndex = 28;
            this.labTYellow.Text = "0";
            this.labTYellow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labTYellow.Click += new System.EventHandler(this.pYellow_Click);
            // 
            // pRed
            // 
            this.pRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pRed.Controls.Add(this.labSTRed);
            this.pRed.Controls.Add(this.labTRed);
            this.pRed.Controls.Add(this.labRed);
            this.pRed.Location = new System.Drawing.Point(506, 132);
            this.pRed.Name = "pRed";
            this.pRed.Size = new System.Drawing.Size(80, 80);
            this.pRed.TabIndex = 31;
            this.pRed.Click += new System.EventHandler(this.pRed_Click);
            // 
            // labSTRed
            // 
            this.labSTRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labSTRed.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSTRed.Location = new System.Drawing.Point(0, 47);
            this.labSTRed.Name = "labSTRed";
            this.labSTRed.Size = new System.Drawing.Size(80, 33);
            this.labSTRed.TabIndex = 29;
            this.labSTRed.Text = "0";
            this.labSTRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labSTRed.Click += new System.EventHandler(this.pRed_Click);
            // 
            // labTRed
            // 
            this.labTRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labTRed.Location = new System.Drawing.Point(0, 25);
            this.labTRed.Name = "labTRed";
            this.labTRed.Size = new System.Drawing.Size(80, 15);
            this.labTRed.TabIndex = 28;
            this.labTRed.Text = "0";
            this.labTRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labTRed.Click += new System.EventHandler(this.pRed_Click);
            // 
            // pAll
            // 
            this.pAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.pAll.Controls.Add(this.labTAll);
            this.pAll.Controls.Add(this.labSTall);
            this.pAll.Controls.Add(this.labAll);
            this.pAll.Location = new System.Drawing.Point(592, 132);
            this.pAll.Name = "pAll";
            this.pAll.Size = new System.Drawing.Size(80, 80);
            this.pAll.TabIndex = 32;
            this.pAll.Click += new System.EventHandler(this.pAll_Click);
            // 
            // labTAll
            // 
            this.labTAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labTAll.ForeColor = System.Drawing.Color.White;
            this.labTAll.Location = new System.Drawing.Point(0, 25);
            this.labTAll.Name = "labTAll";
            this.labTAll.Size = new System.Drawing.Size(80, 15);
            this.labTAll.TabIndex = 30;
            this.labTAll.Text = "0";
            this.labTAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labTAll.Click += new System.EventHandler(this.pAll_Click);
            // 
            // labSTall
            // 
            this.labSTall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labSTall.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSTall.ForeColor = System.Drawing.Color.White;
            this.labSTall.Location = new System.Drawing.Point(0, 47);
            this.labSTall.Name = "labSTall";
            this.labSTall.Size = new System.Drawing.Size(80, 33);
            this.labSTall.TabIndex = 29;
            this.labSTall.Text = "0";
            this.labSTall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labSTall.Click += new System.EventHandler(this.pAll_Click);
            // 
            // labAll
            // 
            this.labAll.AutoSize = true;
            this.labAll.ForeColor = System.Drawing.Color.White;
            this.labAll.Location = new System.Drawing.Point(3, 5);
            this.labAll.Name = "labAll";
            this.labAll.Size = new System.Drawing.Size(36, 15);
            this.labAll.TabIndex = 20;
            this.labAll.Text = "Total";
            this.labAll.Click += new System.EventHandler(this.pAll_Click);
            // 
            // cbxPreViewSO
            // 
            this.cbxPreViewSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPreViewSO.AutoSize = true;
            this.cbxPreViewSO.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxPreViewSO.Checked = true;
            this.cbxPreViewSO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxPreViewSO.Location = new System.Drawing.Point(663, 66);
            this.cbxPreViewSO.Name = "cbxPreViewSO";
            this.cbxPreViewSO.Size = new System.Drawing.Size(125, 19);
            this.cbxPreViewSO.TabIndex = 33;
            this.cbxPreViewSO.Text = "Pré-Visualização";
            this.cbxPreViewSO.UseVisualStyleBackColor = true;
            this.cbxPreViewSO.CheckedChanged += new System.EventHandler(this.cbxPreViewSO_CheckedChanged);
            // 
            // pBackground
            // 
            this.pBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBackground.BackColor = System.Drawing.Color.White;
            this.pBackground.Controls.Add(this.dgvData);
            this.pBackground.Controls.Add(this.flpPreviewSO);
            this.pBackground.Location = new System.Drawing.Point(0, 218);
            this.pBackground.Name = "pBackground";
            this.pBackground.Size = new System.Drawing.Size(800, 382);
            this.pBackground.TabIndex = 34;
            // 
            // flpPreviewSO
            // 
            this.flpPreviewSO.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flpPreviewSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpPreviewSO.Controls.Add(this.pStrutA);
            this.flpPreviewSO.Controls.Add(this.pStrutB);
            this.flpPreviewSO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpPreviewSO.Location = new System.Drawing.Point(0, 202);
            this.flpPreviewSO.Name = "flpPreviewSO";
            this.flpPreviewSO.Size = new System.Drawing.Size(800, 180);
            this.flpPreviewSO.TabIndex = 8;
            // 
            // pStrutA
            // 
            this.pStrutA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pStrutA.Controls.Add(this.labSubject);
            this.pStrutA.Controls.Add(this.labDescription);
            this.pStrutA.Controls.Add(this.txtDescription);
            this.pStrutA.Controls.Add(this.txtSubject);
            this.pStrutA.Location = new System.Drawing.Point(10, 10);
            this.pStrutA.Margin = new System.Windows.Forms.Padding(10);
            this.pStrutA.Name = "pStrutA";
            this.pStrutA.Size = new System.Drawing.Size(375, 160);
            this.pStrutA.TabIndex = 8;
            // 
            // labSubject
            // 
            this.labSubject.AutoSize = true;
            this.labSubject.Location = new System.Drawing.Point(-3, 0);
            this.labSubject.Name = "labSubject";
            this.labSubject.Size = new System.Drawing.Size(57, 15);
            this.labSubject.TabIndex = 4;
            this.labSubject.Text = "Assunto:";
            // 
            // labDescription
            // 
            this.labDescription.AutoSize = true;
            this.labDescription.Location = new System.Drawing.Point(-3, 50);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(69, 15);
            this.labDescription.TabIndex = 5;
            this.labDescription.Text = "Descrição:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.Location = new System.Drawing.Point(0, 68);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(375, 92);
            this.txtDescription.TabIndex = 1;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubject.Location = new System.Drawing.Point(0, 18);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(375, 23);
            this.txtSubject.TabIndex = 0;
            // 
            // pStrutB
            // 
            this.pStrutB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pStrutB.Controls.Add(this.labID);
            this.pStrutB.Controls.Add(this.txtID);
            this.pStrutB.Controls.Add(this.labSolution);
            this.pStrutB.Controls.Add(this.txtSolution);
            this.pStrutB.Location = new System.Drawing.Point(405, 10);
            this.pStrutB.Margin = new System.Windows.Forms.Padding(10);
            this.pStrutB.Name = "pStrutB";
            this.pStrutB.Size = new System.Drawing.Size(375, 160);
            this.pStrutB.TabIndex = 9;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(3, 0);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(23, 15);
            this.labID.TabIndex = 6;
            this.labID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Info;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Location = new System.Drawing.Point(0, 18);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(148, 23);
            this.txtID.TabIndex = 3;
            // 
            // labSolution
            // 
            this.labSolution.AutoSize = true;
            this.labSolution.Location = new System.Drawing.Point(-3, 50);
            this.labSolution.Name = "labSolution";
            this.labSolution.Size = new System.Drawing.Size(56, 15);
            this.labSolution.TabIndex = 7;
            this.labSolution.Text = "Solução:";
            // 
            // txtSolution
            // 
            this.txtSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolution.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSolution.Location = new System.Drawing.Point(0, 68);
            this.txtSolution.Multiline = true;
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.ReadOnly = true;
            this.txtSolution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolution.Size = new System.Drawing.Size(375, 92);
            this.txtSolution.TabIndex = 2;
            // 
            // ucSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbxPreViewSO);
            this.Controls.Add(this.pAll);
            this.Controls.Add(this.pRed);
            this.Controls.Add(this.pYellow);
            this.Controls.Add(this.pBlue);
            this.Controls.Add(this.pGreen);
            this.Controls.Add(this.dtpBefore);
            this.Controls.Add(this.labBefore);
            this.Controls.Add(this.dtpAfter);
            this.Controls.Add(this.labAfter);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.pbSearchImage);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pBackground);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucSchedule";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.ucSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pGreen.ResumeLayout(false);
            this.pGreen.PerformLayout();
            this.pBlue.ResumeLayout(false);
            this.pBlue.PerformLayout();
            this.pYellow.ResumeLayout(false);
            this.pYellow.PerformLayout();
            this.pRed.ResumeLayout(false);
            this.pRed.PerformLayout();
            this.pAll.ResumeLayout(false);
            this.pAll.PerformLayout();
            this.pBackground.ResumeLayout(false);
            this.flpPreviewSO.ResumeLayout(false);
            this.pStrutA.ResumeLayout(false);
            this.pStrutA.PerformLayout();
            this.pStrutB.ResumeLayout(false);
            this.pStrutB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pbSearchImage;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labAfter;
        private System.Windows.Forms.DateTimePicker dtpAfter;
        private System.Windows.Forms.DateTimePicker dtpBefore;
        private System.Windows.Forms.Label labBefore;
        private System.Windows.Forms.Label labGreen;
        private System.Windows.Forms.Label labYellow;
        private System.Windows.Forms.Label labBabyBlue;
        private System.Windows.Forms.Label labRed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerRazao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerComponents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhoLaunched;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhoRequested;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsInactive;
        private System.Windows.Forms.Panel pGreen;
        private System.Windows.Forms.Label labSTGreen;
        private System.Windows.Forms.Label labTGreen;
        private System.Windows.Forms.Panel pBlue;
        private System.Windows.Forms.Label labSTBlue;
        private System.Windows.Forms.Label labTBlue;
        private System.Windows.Forms.Panel pYellow;
        private System.Windows.Forms.Label labSTYellow;
        private System.Windows.Forms.Label labTYellow;
        private System.Windows.Forms.Panel pRed;
        private System.Windows.Forms.Label labSTRed;
        private System.Windows.Forms.Label labTRed;
        private System.Windows.Forms.Panel pAll;
        private System.Windows.Forms.Label labSTall;
        private System.Windows.Forms.Label labAll;
        private System.Windows.Forms.Label labTAll;
        private System.Windows.Forms.CheckBox cbxPreViewSO;
        private System.Windows.Forms.Panel pBackground;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label labSolution;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labDescription;
        private System.Windows.Forms.Label labSubject;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel pStrutB;
        private System.Windows.Forms.Panel pStrutA;
        private System.Windows.Forms.FlowLayoutPanel flpPreviewSO;
    }
}
