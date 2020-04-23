namespace ProductManager
{
    partial class frmProductManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSupplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SupplierDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.btnRefreshSupplies = new MetroFramework.Controls.MetroButton();
            this.btnAddProductToSupplier = new MetroFramework.Controls.MetroButton();
            this.btnAddANewProduct = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.lblSuppliersPerProduct = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.productComboBox = new MetroFramework.Controls.MetroComboBox();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditName = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_Name = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DBConnector.Product);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(DBConnector.Supplier);
            // 
            // productSupplierBindingSource
            // 
            this.productSupplierBindingSource.DataSource = typeof(DBConnector.ProductSupplier);
            // 
            // productDBBindingSource
            // 
            this.productDBBindingSource.DataSource = typeof(DBConnector.ProductDB);
            // 
            // productSupplierBindingSource1
            // 
            this.productSupplierBindingSource1.DataSource = this.productSupplierBindingSource;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroPanel1.Controls.Add(this.SupplierDataGridView);
            this.metroPanel1.Controls.Add(this.ProductGridView);
            this.metroPanel1.Controls.Add(this.btnRefreshSupplies);
            this.metroPanel1.Controls.Add(this.btnAddProductToSupplier);
            this.metroPanel1.Controls.Add(this.btnAddANewProduct);
            this.metroPanel1.Controls.Add(this.btnRefresh);
            this.metroPanel1.Controls.Add(this.lblSuppliersPerProduct);
            this.metroPanel1.Controls.Add(this.lblProductName);
            this.metroPanel1.Controls.Add(this.productComboBox);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(108, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1605, 754);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // SupplierDataGridView
            // 
            this.SupplierDataGridView.AutoGenerateColumns = false;
            this.SupplierDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SupplierDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.EditName});
            this.SupplierDataGridView.DataSource = this.supplierBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplierDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.SupplierDataGridView.Location = new System.Drawing.Point(719, 204);
            this.SupplierDataGridView.Name = "SupplierDataGridView";
            this.SupplierDataGridView.RowHeadersVisible = false;
            this.SupplierDataGridView.RowHeadersWidth = 51;
            this.SupplierDataGridView.RowTemplate.Height = 24;
            this.SupplierDataGridView.Size = new System.Drawing.Size(506, 418);
            this.SupplierDataGridView.TabIndex = 73;
            this.SupplierDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierDataGridView_CellContentClick_1);
            // 
            // ProductGridView
            // 
            this.ProductGridView.AutoGenerateColumns = false;
            this.ProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGridView.BackgroundColor = System.Drawing.Color.White;
            this.ProductGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Edit_Name});
            this.ProductGridView.DataSource = this.productBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProductGridView.Location = new System.Drawing.Point(69, 204);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowHeadersVisible = false;
            this.ProductGridView.RowHeadersWidth = 51;
            this.ProductGridView.RowTemplate.Height = 24;
            this.ProductGridView.Size = new System.Drawing.Size(596, 418);
            this.ProductGridView.TabIndex = 72;
            this.ProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellContentClick_1);
            // 
            // btnRefreshSupplies
            // 
            this.btnRefreshSupplies.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRefreshSupplies.Location = new System.Drawing.Point(1049, 643);
            this.btnRefreshSupplies.Name = "btnRefreshSupplies";
            this.btnRefreshSupplies.Size = new System.Drawing.Size(201, 73);
            this.btnRefreshSupplies.TabIndex = 71;
            this.btnRefreshSupplies.Text = "Refresh Suppliers";
            this.btnRefreshSupplies.UseSelectable = true;
            this.btnRefreshSupplies.Click += new System.EventHandler(this.btnRefreshSupplies_Click);
            // 
            // btnAddProductToSupplier
            // 
            this.btnAddProductToSupplier.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddProductToSupplier.Location = new System.Drawing.Point(931, 22);
            this.btnAddProductToSupplier.Name = "btnAddProductToSupplier";
            this.btnAddProductToSupplier.Size = new System.Drawing.Size(347, 88);
            this.btnAddProductToSupplier.TabIndex = 69;
            this.btnAddProductToSupplier.Text = "Add a Product to a Supplier";
            this.btnAddProductToSupplier.UseSelectable = true;
            this.btnAddProductToSupplier.Click += new System.EventHandler(this.btnAddProductToSupplier_Click);
            // 
            // btnAddANewProduct
            // 
            this.btnAddANewProduct.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddANewProduct.Location = new System.Drawing.Point(597, 22);
            this.btnAddANewProduct.Name = "btnAddANewProduct";
            this.btnAddANewProduct.Size = new System.Drawing.Size(265, 88);
            this.btnAddANewProduct.TabIndex = 68;
            this.btnAddANewProduct.Text = "Add a New Product";
            this.btnAddANewProduct.UseSelectable = true;
            this.btnAddANewProduct.Click += new System.EventHandler(this.btnAddANewProduct_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRefresh.Location = new System.Drawing.Point(647, 643);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(201, 73);
            this.btnRefresh.TabIndex = 67;
            this.btnRefresh.Text = "Refresh Products";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSuppliersPerProduct
            // 
            this.lblSuppliersPerProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuppliersPerProduct.AutoEllipsis = true;
            this.lblSuppliersPerProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblSuppliersPerProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.lblSuppliersPerProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSuppliersPerProduct.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersPerProduct.ForeColor = System.Drawing.Color.Black;
            this.lblSuppliersPerProduct.Location = new System.Drawing.Point(641, 144);
            this.lblSuppliersPerProduct.Name = "lblSuppliersPerProduct";
            this.lblSuppliersPerProduct.Size = new System.Drawing.Size(464, 57);
            this.lblSuppliersPerProduct.TabIndex = 66;
            this.lblSuppliersPerProduct.Text = "Suppliers per Product";
            this.lblSuppliersPerProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductName.AutoEllipsis = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.lblProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.Black;
            this.lblProductName.Location = new System.Drawing.Point(22, 82);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(301, 59);
            this.lblProductName.TabIndex = 65;
            this.lblProductName.Text = "Product Name:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productComboBox
            // 
            this.productComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierBindingSource, "ProductID", true));
            this.productComboBox.DataSource = this.productBindingSource;
            this.productComboBox.DisplayMember = "ProdName";
            this.productComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.ItemHeight = 29;
            this.productComboBox.Location = new System.Drawing.Point(69, 144);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(277, 35);
            this.productComboBox.TabIndex = 14;
            this.productComboBox.UseSelectable = true;
            this.productComboBox.ValueMember = "ProductID";
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn12.HeaderText = "Supplier Name";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn13.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // EditName
            // 
            this.EditName.HeaderText = "Edit Name";
            this.EditName.MinimumWidth = 6;
            this.EditName.Name = "EditName";
            this.EditName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditName.Text = "Edit Name";
            this.EditName.UseColumnTextForButtonValue = true;
            this.EditName.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Edit_Name
            // 
            this.Edit_Name.HeaderText = "Edit Name";
            this.Edit_Name.MinimumWidth = 6;
            this.Edit_Name.Name = "Edit_Name";
            this.Edit_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit_Name.Text = "Edit Name";
            this.Edit_Name.UseColumnTextForButtonValue = true;
            // 
            // frmProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProductManager";
            this.Size = new System.Drawing.Size(1569, 754);
            this.Load += new System.EventHandler(this.frmProductManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productDBBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource productSupplierBindingSource;
        private System.Windows.Forms.BindingSource productSupplierBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox productComboBox;
        private MetroFramework.Controls.MetroButton btnRefreshSupplies;
        private MetroFramework.Controls.MetroButton btnAddProductToSupplier;
        private MetroFramework.Controls.MetroButton btnAddANewProduct;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.Label lblSuppliersPerProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.DataGridView SupplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewButtonColumn EditName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn Edit_Name;
    }
}

