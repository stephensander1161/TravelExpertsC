namespace ThreadedProject2
{
    partial class frmPackageManager
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
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxPackageDetails = new System.Windows.Forms.GroupBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productExtendedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewPackage = new MetroFramework.Controls.MetroButton();
            this.cmbPackageIds = new System.Windows.Forms.ComboBox();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlProductDetails = new MetroFramework.Controls.MetroPanel();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.cmbProductList = new System.Windows.Forms.ComboBox();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnAddProduct = new MetroFramework.Controls.MetroButton();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnClearEndDate = new MetroFramework.Controls.MetroButton();
            this.btnClearStartDate = new MetroFramework.Controls.MetroButton();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.pnlPackage = new System.Windows.Forms.Panel();
            this.tbxPkgCommission = new System.Windows.Forms.TextBox();
            this.lblDescCharCount = new System.Windows.Forms.Label();
            this.tbxPkgDesc = new System.Windows.Forms.TextBox();
            this.lblNameCharCount = new System.Windows.Forms.Label();
            this.tbxPkgPrice = new System.Windows.Forms.TextBox();
            this.tbxPkgName = new System.Windows.Forms.TextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productExtendedBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.pnlProductDetails.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.pnlPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(201, 162);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(118, 21);
            pkgAgencyCommissionLabel.TabIndex = 58;
            pkgAgencyCommissionLabel.Text = "Commission";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgDescLabel.Location = new System.Drawing.Point(3, 92);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(119, 23);
            pkgDescLabel.TabIndex = 62;
            pkgDescLabel.Text = "Description";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgBasePriceLabel.Location = new System.Drawing.Point(3, 162);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(57, 23);
            pkgBasePriceLabel.TabIndex = 60;
            pkgBasePriceLabel.Text = "Price";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgNameLabel.Location = new System.Drawing.Point(3, 16);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(65, 23);
            pkgNameLabel.TabIndex = 68;
            pkgNameLabel.Text = "Name";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.BackColor = System.Drawing.Color.Transparent;
            pkgStartDateLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgStartDateLabel.Location = new System.Drawing.Point(8, 16);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(107, 23);
            pkgStartDateLabel.TabIndex = 66;
            pkgStartDateLabel.Text = "Start Date";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.BackColor = System.Drawing.Color.Transparent;
            pkgEndDateLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgEndDateLabel.Location = new System.Drawing.Point(9, 91);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(96, 23);
            pkgEndDateLabel.TabIndex = 64;
            pkgEndDateLabel.Text = "End Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 23);
            label1.TabIndex = 81;
            label1.Text = "Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(3, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 23);
            label2.TabIndex = 82;
            label2.Text = "Product";
            // 
            // gbxPackageDetails
            // 
            this.gbxPackageDetails.AutoSize = true;
            this.gbxPackageDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxPackageDetails.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPackageDetails.Location = new System.Drawing.Point(0, 0);
            this.gbxPackageDetails.Margin = new System.Windows.Forms.Padding(0);
            this.gbxPackageDetails.Name = "gbxPackageDetails";
            this.gbxPackageDetails.Padding = new System.Windows.Forms.Padding(0);
            this.gbxPackageDetails.Size = new System.Drawing.Size(0, 0);
            this.gbxPackageDetails.TabIndex = 61;
            this.gbxPackageDetails.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.Controls.Add(this.dtgProducts);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Controls.Add(this.pnlProductDetails);
            this.metroPanel1.Controls.Add(this.metroPanel4);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.pnlPackage);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel1.MaximumSize = new System.Drawing.Size(916, 600);
            this.metroPanel1.MinimumSize = new System.Drawing.Size(916, 600);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(916, 600);
            this.metroPanel1.TabIndex = 71;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // dtgProducts
            // 
            this.dtgProducts.AllowUserToAddRows = false;
            this.dtgProducts.AllowUserToDeleteRows = false;
            this.dtgProducts.AllowUserToOrderColumns = true;
            this.dtgProducts.AllowUserToResizeRows = false;
            this.dtgProducts.AutoGenerateColumns = false;
            this.dtgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProducts.BackgroundColor = System.Drawing.Color.White;
            this.dtgProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2});
            this.dtgProducts.DataSource = this.productExtendedBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProducts.Location = new System.Drawing.Point(14, 336);
            this.dtgProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dtgProducts.MultiSelect = false;
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.ReadOnly = true;
            this.dtgProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProducts.RowHeadersVisible = false;
            this.dtgProducts.RowHeadersWidth = 51;
            this.dtgProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgProducts.RowTemplate.Height = 24;
            this.dtgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProducts.ShowCellErrors = false;
            this.dtgProducts.ShowCellToolTips = false;
            this.dtgProducts.ShowEditingIcon = false;
            this.dtgProducts.ShowRowErrors = false;
            this.dtgProducts.Size = new System.Drawing.Size(884, 146);
            this.dtgProducts.TabIndex = 79;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.FillWeight = 20F;
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn5.FillWeight = 60F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Product";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SupplierName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // productExtendedBindingSource
            // 
            this.productExtendedBindingSource.DataSource = typeof(DBConnector.ProductExtended);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewPackage);
            this.groupBox1.Controls.Add(this.cmbPackageIds);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(440, 71);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Lookup";
            // 
            // btnNewPackage
            // 
            this.btnNewPackage.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNewPackage.Location = new System.Drawing.Point(334, 28);
            this.btnNewPackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewPackage.Name = "btnNewPackage";
            this.btnNewPackage.Size = new System.Drawing.Size(79, 27);
            this.btnNewPackage.TabIndex = 79;
            this.btnNewPackage.Text = "New";
            this.btnNewPackage.UseSelectable = true;
            this.btnNewPackage.Click += new System.EventHandler(this.btnNewPackage_Click);
            // 
            // cmbPackageIds
            // 
            this.cmbPackageIds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPackageIds.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPackageIds.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPackageIds.BackColor = System.Drawing.Color.White;
            this.cmbPackageIds.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.cmbPackageIds.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPackageIds.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPackageIds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbPackageIds.FormattingEnabled = true;
            this.cmbPackageIds.Location = new System.Drawing.Point(9, 28);
            this.cmbPackageIds.Name = "cmbPackageIds";
            this.cmbPackageIds.Size = new System.Drawing.Size(306, 30);
            this.cmbPackageIds.TabIndex = 42;
            this.cmbPackageIds.TabStop = false;
            this.cmbPackageIds.Tag = "PackageControls";
            this.cmbPackageIds.SelectedIndexChanged += new System.EventHandler(this.cmbPackageIds_SelectedIndexChanged);
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(DBConnector.Package);
            // 
            // pnlProductDetails
            // 
            this.pnlProductDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProductDetails.Controls.Add(this.cmbSuppliers);
            this.pnlProductDetails.Controls.Add(this.cmbProductList);
            this.pnlProductDetails.Controls.Add(label2);
            this.pnlProductDetails.Controls.Add(label1);
            this.pnlProductDetails.Controls.Add(this.btnRemove);
            this.pnlProductDetails.Controls.Add(this.btnAddProduct);
            this.pnlProductDetails.HorizontalScrollbarBarColor = true;
            this.pnlProductDetails.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProductDetails.HorizontalScrollbarSize = 8;
            this.pnlProductDetails.Location = new System.Drawing.Point(11, 488);
            this.pnlProductDetails.Margin = new System.Windows.Forms.Padding(2);
            this.pnlProductDetails.Name = "pnlProductDetails";
            this.pnlProductDetails.Size = new System.Drawing.Size(886, 75);
            this.pnlProductDetails.TabIndex = 77;
            this.pnlProductDetails.VerticalScrollbarBarColor = true;
            this.pnlProductDetails.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProductDetails.VerticalScrollbarSize = 8;
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSuppliers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSuppliers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSuppliers.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(124, 42);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(289, 30);
            this.cmbSuppliers.TabIndex = 84;
            this.cmbSuppliers.TabStop = false;
            this.cmbSuppliers.Tag = "PackageControls";
            // 
            // cmbProductList
            // 
            this.cmbProductList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbProductList.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.cmbProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProductList.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbProductList.FormattingEnabled = true;
            this.cmbProductList.Location = new System.Drawing.Point(124, 7);
            this.cmbProductList.Name = "cmbProductList";
            this.cmbProductList.Size = new System.Drawing.Size(289, 30);
            this.cmbProductList.TabIndex = 83;
            this.cmbProductList.TabStop = false;
            this.cmbProductList.Tag = "PackageControls";
            this.cmbProductList.SelectedIndexChanged += new System.EventHandler(this.cmbProductList_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRemove.Location = new System.Drawing.Point(789, 6);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(82, 27);
            this.btnRemove.TabIndex = 80;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddProduct.Location = new System.Drawing.Point(439, 11);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(82, 26);
            this.btnAddProduct.TabIndex = 79;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseSelectable = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.lblPackageName);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 8;
            this.metroPanel4.Location = new System.Drawing.Point(500, 16);
            this.metroPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(373, 72);
            this.metroPanel4.TabIndex = 74;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 8;
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoEllipsis = true;
            this.lblPackageName.BackColor = System.Drawing.Color.Transparent;
            this.lblPackageName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.lblPackageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPackageName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPackageName.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageName.ForeColor = System.Drawing.Color.Black;
            this.lblPackageName.Location = new System.Drawing.Point(0, 0);
            this.lblPackageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(373, 72);
            this.lblPackageName.TabIndex = 63;
            this.lblPackageName.Text = "ProductName";
            this.lblPackageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DBConnector.Product);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.Controls.Add(this.btnCancel);
            this.metroPanel3.Controls.Add(this.btnClearEndDate);
            this.metroPanel3.Controls.Add(this.btnClearStartDate);
            this.metroPanel3.Controls.Add(pkgStartDateLabel);
            this.metroPanel3.Controls.Add(this.dtpPkgStartDate);
            this.metroPanel3.Controls.Add(this.dtpPkgEndDate);
            this.metroPanel3.Controls.Add(pkgEndDateLabel);
            this.metroPanel3.Controls.Add(this.btnSave);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 8;
            this.metroPanel3.Location = new System.Drawing.Point(488, 93);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(412, 228);
            this.metroPanel3.TabIndex = 73;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancel.Location = new System.Drawing.Point(212, 181);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 34);
            this.btnCancel.TabIndex = 78;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClearEndDate
            // 
            this.btnClearEndDate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClearEndDate.Location = new System.Drawing.Point(312, 114);
            this.btnClearEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearEndDate.Name = "btnClearEndDate";
            this.btnClearEndDate.Size = new System.Drawing.Size(73, 28);
            this.btnClearEndDate.TabIndex = 76;
            this.btnClearEndDate.TabStop = false;
            this.btnClearEndDate.Text = "Clear";
            this.btnClearEndDate.UseSelectable = true;
            this.btnClearEndDate.Click += new System.EventHandler(this.btnClearEndDate_Click);
            // 
            // btnClearStartDate
            // 
            this.btnClearStartDate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClearStartDate.Location = new System.Drawing.Point(311, 35);
            this.btnClearStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearStartDate.Name = "btnClearStartDate";
            this.btnClearStartDate.Size = new System.Drawing.Size(73, 28);
            this.btnClearStartDate.TabIndex = 75;
            this.btnClearStartDate.TabStop = false;
            this.btnClearStartDate.Text = "Clear";
            this.btnClearStartDate.UseSelectable = true;
            this.btnClearStartDate.Click += new System.EventHandler(this.btnClearStartDate_Click);
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPkgStartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpPkgStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.dtpPkgStartDate.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPkgStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPkgStartDate.Location = new System.Drawing.Point(11, 39);
            this.dtpPkgStartDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpPkgStartDate.MinDate = new System.DateTime(2000, 2, 5, 0, 0, 0, 0);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(278, 30);
            this.dtpPkgStartDate.TabIndex = 49;
            this.dtpPkgStartDate.ValueChanged += new System.EventHandler(this.dtpPkgStartDate_ValueChanged);
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPkgEndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpPkgEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.dtpPkgEndDate.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPkgEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPkgEndDate.Location = new System.Drawing.Point(12, 114);
            this.dtpPkgEndDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpPkgEndDate.MinDate = new System.DateTime(2000, 2, 5, 0, 0, 0, 0);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(278, 30);
            this.dtpPkgEndDate.TabIndex = 50;
            this.dtpPkgEndDate.ValueChanged += new System.EventHandler(this.dtpPkgEndDate_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(13, 182);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 34);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlPackage
            // 
            this.pnlPackage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPackage.BackColor = System.Drawing.Color.White;
            this.pnlPackage.Controls.Add(this.tbxPkgCommission);
            this.pnlPackage.Controls.Add(pkgAgencyCommissionLabel);
            this.pnlPackage.Controls.Add(pkgDescLabel);
            this.pnlPackage.Controls.Add(this.lblDescCharCount);
            this.pnlPackage.Controls.Add(this.tbxPkgDesc);
            this.pnlPackage.Controls.Add(this.lblNameCharCount);
            this.pnlPackage.Controls.Add(this.tbxPkgPrice);
            this.pnlPackage.Controls.Add(this.tbxPkgName);
            this.pnlPackage.Controls.Add(pkgBasePriceLabel);
            this.pnlPackage.Controls.Add(pkgNameLabel);
            this.pnlPackage.Location = new System.Drawing.Point(14, 93);
            this.pnlPackage.Name = "pnlPackage";
            this.pnlPackage.Size = new System.Drawing.Size(437, 228);
            this.pnlPackage.TabIndex = 68;
            this.pnlPackage.Tag = "";
            // 
            // tbxPkgCommission
            // 
            this.tbxPkgCommission.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPkgCommission.BackColor = System.Drawing.Color.White;
            this.tbxPkgCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.tbxPkgCommission.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgCommission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxPkgCommission.Location = new System.Drawing.Point(204, 189);
            this.tbxPkgCommission.Name = "tbxPkgCommission";
            this.tbxPkgCommission.Size = new System.Drawing.Size(207, 30);
            this.tbxPkgCommission.TabIndex = 48;
            this.tbxPkgCommission.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPkgCommission_Validating);
            this.tbxPkgCommission.Validated += new System.EventHandler(this.tbxPkgCommission_Validated);
            // 
            // lblDescCharCount
            // 
            this.lblDescCharCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescCharCount.AutoSize = true;
            this.lblDescCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCharCount.ForeColor = System.Drawing.Color.Gray;
            this.lblDescCharCount.Location = new System.Drawing.Point(369, 96);
            this.lblDescCharCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescCharCount.Name = "lblDescCharCount";
            this.lblDescCharCount.Size = new System.Drawing.Size(44, 18);
            this.lblDescCharCount.TabIndex = 73;
            this.lblDescCharCount.Text = "14/50";
            this.lblDescCharCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPkgDesc
            // 
            this.tbxPkgDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPkgDesc.BackColor = System.Drawing.Color.White;
            this.tbxPkgDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.tbxPkgDesc.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxPkgDesc.Location = new System.Drawing.Point(7, 119);
            this.tbxPkgDesc.Name = "tbxPkgDesc";
            this.tbxPkgDesc.Size = new System.Drawing.Size(404, 30);
            this.tbxPkgDesc.TabIndex = 46;
            this.tbxPkgDesc.TextChanged += new System.EventHandler(this.tbxPkgDesc_TextChanged);
            this.tbxPkgDesc.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPkgDesc_Validating);
            this.tbxPkgDesc.Validated += new System.EventHandler(this.tbxPkgDesc_Validated);
            // 
            // lblNameCharCount
            // 
            this.lblNameCharCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameCharCount.AutoSize = true;
            this.lblNameCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCharCount.ForeColor = System.Drawing.Color.Gray;
            this.lblNameCharCount.Location = new System.Drawing.Point(369, 21);
            this.lblNameCharCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameCharCount.Name = "lblNameCharCount";
            this.lblNameCharCount.Size = new System.Drawing.Size(44, 18);
            this.lblNameCharCount.TabIndex = 72;
            this.lblNameCharCount.Text = "14/50";
            this.lblNameCharCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPkgPrice
            // 
            this.tbxPkgPrice.BackColor = System.Drawing.Color.White;
            this.tbxPkgPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.tbxPkgPrice.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxPkgPrice.Location = new System.Drawing.Point(6, 188);
            this.tbxPkgPrice.Name = "tbxPkgPrice";
            this.tbxPkgPrice.Size = new System.Drawing.Size(165, 30);
            this.tbxPkgPrice.TabIndex = 47;
            this.tbxPkgPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPkgPrice_Validating);
            this.tbxPkgPrice.Validated += new System.EventHandler(this.tbxPkgPrice_Validated);
            // 
            // tbxPkgName
            // 
            this.tbxPkgName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPkgName.BackColor = System.Drawing.Color.White;
            this.tbxPkgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.tbxPkgName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxPkgName.Location = new System.Drawing.Point(7, 43);
            this.tbxPkgName.Name = "tbxPkgName";
            this.tbxPkgName.Size = new System.Drawing.Size(404, 30);
            this.tbxPkgName.TabIndex = 45;
            this.tbxPkgName.Tag = "PackageControls";
            this.tbxPkgName.TextChanged += new System.EventHandler(this.tbxPkgName_TextChanged);
            this.tbxPkgName.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPkgName_Validating);
            this.tbxPkgName.Validated += new System.EventHandler(this.tbxPkgName_Validated);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // frmPackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.gbxPackageDetails);
            this.DoubleBuffered = true;
            this.Name = "frmPackageManager";
            this.Size = new System.Drawing.Size(1222, 739);
            this.UseStyleColors = true;
            this.Load += new System.EventHandler(this.frmPackageManager_Load);
            this.VisibleChanged += new System.EventHandler(this.frmPackageManager_VisibleChanged);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productExtendedBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.pnlProductDetails.ResumeLayout(false);
            this.pnlProductDetails.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.pnlPackage.ResumeLayout(false);
            this.pnlPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productExtendedBindingSource;
        private System.Windows.Forms.GroupBox gbxPackageDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSupplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbPackageIds;
        private System.Windows.Forms.Panel pnlPackage;
        private System.Windows.Forms.TextBox tbxPkgCommission;
        private System.Windows.Forms.Label lblDescCharCount;
        private System.Windows.Forms.TextBox tbxPkgDesc;
        private System.Windows.Forms.Label lblNameCharCount;
        private System.Windows.Forms.TextBox tbxPkgPrice;
        private System.Windows.Forms.TextBox tbxPkgName;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel pnlProductDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnClearEndDate;
        private MetroFramework.Controls.MetroButton btnClearStartDate;
        private MetroFramework.Controls.MetroButton btnNewPackage;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnRemove;
        private MetroFramework.Controls.MetroButton btnAddProduct;
        private System.Windows.Forms.Label lblPackageName;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox cmbProductList;
        private System.Windows.Forms.ComboBox cmbSuppliers;
    }
}

