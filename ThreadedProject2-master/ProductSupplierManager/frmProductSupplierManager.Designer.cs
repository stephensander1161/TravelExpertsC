namespace ProductSupplierManager
{
    partial class frmProductSupplierManager
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
            System.Windows.Forms.Label lblProdName;
            System.Windows.Forms.Label lblSuppName;
            System.Windows.Forms.Label lblSuppID;
            System.Windows.Forms.Label productIDLabel;
            this.productSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboProdID = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboProdNames = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            lblProdName = new System.Windows.Forms.Label();
            lblSuppName = new System.Windows.Forms.Label();
            lblSuppID = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdName
            // 
            lblProdName.AutoSize = true;
            lblProdName.Location = new System.Drawing.Point(44, 104);
            lblProdName.Name = "lblProdName";
            lblProdName.Size = new System.Drawing.Size(83, 17);
            lblProdName.TabIndex = 7;
            lblProdName.Text = "Prod Name:";
            // 
            // lblSuppName
            // 
            lblSuppName.AutoSize = true;
            lblSuppName.Location = new System.Drawing.Point(44, 201);
            lblSuppName.Name = "lblSuppName";
            lblSuppName.Size = new System.Drawing.Size(78, 17);
            lblSuppName.TabIndex = 11;
            lblSuppName.Text = "Sup Name:";
            // 
            // lblSuppID
            // 
            lblSuppID.AutoSize = true;
            lblSuppID.Location = new System.Drawing.Point(44, 229);
            lblSuppID.Name = "lblSuppID";
            lblSuppID.Size = new System.Drawing.Size(81, 17);
            lblSuppID.TabIndex = 13;
            lblSuppID.Text = "Supplier ID:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(44, 153);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(78, 17);
            productIDLabel.TabIndex = 15;
            productIDLabel.Text = "Product ID:";
            // 
            // productSupplierBindingSource
            // 
            this.productSupplierBindingSource.DataSource = typeof(DBConnector.ProductSupplier);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(productIDLabel);
            this.panel1.Controls.Add(this.cboProdID);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(lblProdName);
            this.panel1.Controls.Add(this.cboProdNames);
            this.panel1.Controls.Add(lblSuppName);
            this.panel1.Controls.Add(this.txtSupName);
            this.panel1.Controls.Add(lblSuppID);
            this.panel1.Controls.Add(this.txtSupID);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 596);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cboProdID
            // 
            this.cboProdID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true));
            this.cboProdID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductID", true));
            this.cboProdID.DataSource = this.productBindingSource;
            this.cboProdID.DisplayMember = "ProductID";
            this.cboProdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProdID.FormattingEnabled = true;
            this.cboProdID.Location = new System.Drawing.Point(135, 143);
            this.cboProdID.Name = "cboProdID";
            this.cboProdID.Size = new System.Drawing.Size(121, 33);
            this.cboProdID.TabIndex = 16;
            this.cboProdID.ValueMember = "ProdName";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DBConnector.Product);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(133, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 39);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboProdNames
            // 
            this.cboProdNames.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "ProdName", true));
            this.cboProdNames.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProdName", true));
            this.cboProdNames.DataSource = this.productBindingSource;
            this.cboProdNames.DisplayMember = "ProdName";
            this.cboProdNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProdNames.FormattingEnabled = true;
            this.cboProdNames.Location = new System.Drawing.Point(133, 101);
            this.cboProdNames.Name = "cboProdNames";
            this.cboProdNames.Size = new System.Drawing.Size(153, 33);
            this.cboProdNames.TabIndex = 8;
            this.cboProdNames.ValueMember = "ProductID";
            this.cboProdNames.SelectedIndexChanged += new System.EventHandler(this.cboProdNames_SelectedIndexChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(DBConnector.Supplier);
            // 
            // txtSupName
            // 
            this.txtSupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupName", true));
            this.txtSupName.Location = new System.Drawing.Point(133, 198);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(373, 22);
            this.txtSupName.TabIndex = 12;
            // 
            // txtSupID
            // 
            this.txtSupID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupplierID", true));
            this.txtSupID.Location = new System.Drawing.Point(133, 226);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(198, 22);
            this.txtSupID.TabIndex = 14;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(29, 29);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(98, 17);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name";
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(DBConnector.Product);
            // 
            // frmProductSupplierManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 596);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(925, 643);
            this.Name = "frmProductSupplierManager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSupplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource productSupplierBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.ComboBox cboProdNames;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboProdID;
    }
}

