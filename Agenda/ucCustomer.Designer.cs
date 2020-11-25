namespace Agenda
{
    partial class ucCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbActiveStatus = new System.Windows.Forms.GroupBox();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.pbSearchImage = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pTitle = new System.Windows.Forms.Panel();
            this.labTitle = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.labSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResponsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProspecting = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFinancialPending = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCellphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountantEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComponents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerminals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsInactive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbActiveStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchImage)).BeginInit();
            this.pTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbActiveStatus
            // 
            this.gbActiveStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbActiveStatus.Controls.Add(this.rbInactive);
            this.gbActiveStatus.Controls.Add(this.rbActive);
            this.gbActiveStatus.Controls.Add(this.rbAll);
            this.gbActiveStatus.Location = new System.Drawing.Point(850, 115);
            this.gbActiveStatus.Name = "gbActiveStatus";
            this.gbActiveStatus.Size = new System.Drawing.Size(210, 48);
            this.gbActiveStatus.TabIndex = 1;
            this.gbActiveStatus.TabStop = false;
            this.gbActiveStatus.Text = "Status";
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Location = new System.Drawing.Point(140, 19);
            this.rbInactive.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(64, 19);
            this.rbInactive.TabIndex = 2;
            this.rbInactive.Text = "Inativo";
            this.rbInactive.UseVisualStyleBackColor = true;
            this.rbInactive.CheckedChanged += new System.EventHandler(this.SearchChanged);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(73, 19);
            this.rbActive.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(61, 19);
            this.rbActive.TabIndex = 1;
            this.rbActive.Text = "Ativos";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.SearchChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(6, 19);
            this.rbAll.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(61, 19);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Todos";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.SearchChanged);
            // 
            // pbSearchImage
            // 
            this.pbSearchImage.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchImage.Image")));
            this.pbSearchImage.Location = new System.Drawing.Point(30, 90);
            this.pbSearchImage.Name = "pbSearchImage";
            this.pbSearchImage.Size = new System.Drawing.Size(64, 64);
            this.pbSearchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchImage.TabIndex = 15;
            this.pbSearchImage.TabStop = false;
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
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.EditCustomer);
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
            this.pTitle.TabIndex = 5;
            // 
            // labTitle
            // 
            this.labTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Roboto Bk", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(502, 16);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(96, 28);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Clientes";
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
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.labSearch.Location = new System.Drawing.Point(108, 115);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(335, 15);
            this.labSearch.TabIndex = 18;
            this.labSearch.Text = "Pesquisa por CNPJ, IE, razão, Fantasia, telefone e celular.";
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Location = new System.Drawing.Point(111, 131);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(430, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.SearchChanged);
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
            this.dgvData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeight = 35;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colRazao,
            this.colName,
            this.colResponsible,
            this.colProspecting,
            this.colFinancialPending,
            this.colCNPJ,
            this.colIE,
            this.colTelephone,
            this.colCellphone,
            this.colSince,
            this.colEmail,
            this.colObs,
            this.colAddress,
            this.colAccountant,
            this.colAccountantEmail,
            this.colProduct,
            this.colComponents,
            this.colTerminals,
            this.colIsInactive});
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
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
            this.dgvData.TabIndex = 4;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditCustomer);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colID.DefaultCellStyle = dataGridViewCellStyle2;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 50;
            // 
            // colRazao
            // 
            this.colRazao.DataPropertyName = "Razao";
            this.colRazao.HeaderText = "Razao";
            this.colRazao.Name = "colRazao";
            this.colRazao.ReadOnly = true;
            this.colRazao.Width = 300;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Fantasia";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // colResponsible
            // 
            this.colResponsible.DataPropertyName = "Responsible";
            this.colResponsible.HeaderText = "Responsável";
            this.colResponsible.Name = "colResponsible";
            this.colResponsible.ReadOnly = true;
            this.colResponsible.Visible = false;
            // 
            // colProspecting
            // 
            this.colProspecting.DataPropertyName = "Prospecting";
            this.colProspecting.HeaderText = "Prospecção";
            this.colProspecting.Name = "colProspecting";
            this.colProspecting.ReadOnly = true;
            this.colProspecting.Visible = false;
            // 
            // colFinancialPending
            // 
            this.colFinancialPending.DataPropertyName = "FinancialPending";
            this.colFinancialPending.HeaderText = "Pendência F.";
            this.colFinancialPending.Name = "colFinancialPending";
            this.colFinancialPending.ReadOnly = true;
            this.colFinancialPending.Visible = false;
            // 
            // colCNPJ
            // 
            this.colCNPJ.DataPropertyName = "CNPJ";
            this.colCNPJ.HeaderText = "CNPJ";
            this.colCNPJ.Name = "colCNPJ";
            this.colCNPJ.ReadOnly = true;
            this.colCNPJ.Width = 125;
            // 
            // colIE
            // 
            this.colIE.DataPropertyName = "IE";
            this.colIE.HeaderText = "IE";
            this.colIE.Name = "colIE";
            this.colIE.ReadOnly = true;
            this.colIE.Visible = false;
            this.colIE.Width = 95;
            // 
            // colTelephone
            // 
            this.colTelephone.DataPropertyName = "Telephone";
            this.colTelephone.HeaderText = "Telefone";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.ReadOnly = true;
            this.colTelephone.Width = 105;
            // 
            // colCellphone
            // 
            this.colCellphone.DataPropertyName = "Cellphone";
            this.colCellphone.HeaderText = "Celular";
            this.colCellphone.Name = "colCellphone";
            this.colCellphone.ReadOnly = true;
            this.colCellphone.Width = 105;
            // 
            // colSince
            // 
            this.colSince.DataPropertyName = "Since";
            this.colSince.HeaderText = "Cli. Desde";
            this.colSince.Name = "colSince";
            this.colSince.ReadOnly = true;
            this.colSince.Visible = false;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "E-Mail";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 250;
            // 
            // colObs
            // 
            this.colObs.DataPropertyName = "Obs";
            this.colObs.HeaderText = "Observações";
            this.colObs.Name = "colObs";
            this.colObs.ReadOnly = true;
            this.colObs.Visible = false;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Endereço";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Visible = false;
            // 
            // colAccountant
            // 
            this.colAccountant.DataPropertyName = "Accountant";
            this.colAccountant.HeaderText = "Contador";
            this.colAccountant.Name = "colAccountant";
            this.colAccountant.ReadOnly = true;
            this.colAccountant.Visible = false;
            // 
            // colAccountantEmail
            // 
            this.colAccountantEmail.DataPropertyName = "AccountantEmail";
            this.colAccountantEmail.HeaderText = "Email Cont.";
            this.colAccountantEmail.Name = "colAccountantEmail";
            this.colAccountantEmail.ReadOnly = true;
            this.colAccountantEmail.Visible = false;
            // 
            // colProduct
            // 
            this.colProduct.DataPropertyName = "Product";
            this.colProduct.HeaderText = "Produto";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            this.colProduct.Visible = false;
            // 
            // colComponents
            // 
            this.colComponents.DataPropertyName = "Components";
            this.colComponents.HeaderText = "Modulos";
            this.colComponents.Name = "colComponents";
            this.colComponents.ReadOnly = true;
            this.colComponents.Visible = false;
            // 
            // colTerminals
            // 
            this.colTerminals.DataPropertyName = "Terminals";
            this.colTerminals.HeaderText = "Qtd. Terminais";
            this.colTerminals.Name = "colTerminals";
            this.colTerminals.ReadOnly = true;
            this.colTerminals.Visible = false;
            // 
            // colIsInactive
            // 
            this.colIsInactive.DataPropertyName = "IsInactive";
            this.colIsInactive.HeaderText = "Inativo";
            this.colIsInactive.Name = "colIsInactive";
            this.colIsInactive.ReadOnly = true;
            this.colIsInactive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsInactive.Visible = false;
            this.colIsInactive.Width = 70;
            // 
            // ucCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gbActiveStatus);
            this.Controls.Add(this.pbSearchImage);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pTitle);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucCustomer";
            this.Size = new System.Drawing.Size(1100, 1024);
            this.Load += new System.EventHandler(this.ucCustomer_Load);
            this.gbActiveStatus.ResumeLayout(false);
            this.gbActiveStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchImage)).EndInit();
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbActiveStatus;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.PictureBox pbSearchImage;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResponsible;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colProspecting;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFinancialPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCellphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSince;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountantEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComponents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerminals;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsInactive;
    }
}
