namespace ProductManager
{
    partial class frmEditSuppliers
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
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.Label supplierIDLabel;
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.editSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.supNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            prodNameLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prodNameLabel.Location = new System.Drawing.Point(55, 119);
            prodNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(283, 48);
            prodNameLabel.TabIndex = 10;
            prodNameLabel.Text = "Product Name:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productIDLabel.Location = new System.Drawing.Point(55, 227);
            productIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(222, 48);
            productIDLabel.TabIndex = 12;
            productIDLabel.Text = "Product ID:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supNameLabel.Location = new System.Drawing.Point(55, 341);
            supNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(291, 48);
            supNameLabel.TabIndex = 14;
            supNameLabel.Text = "Supplier Name:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplierIDLabel.Location = new System.Drawing.Point(55, 459);
            supplierIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(230, 48);
            supplierIDLabel.TabIndex = 16;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(63, 588);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 107);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Accept";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(690, 588);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(240, 107);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "ProdName", true));
            this.prodNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameTextBox.Location = new System.Drawing.Point(63, 172);
            this.prodNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.ReadOnly = true;
            this.prodNameTextBox.Size = new System.Drawing.Size(867, 38);
            this.prodNameTextBox.TabIndex = 11;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(DBConnector.Supplier);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "ProductID", true));
            this.productIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDTextBox.Location = new System.Drawing.Point(63, 280);
            this.productIDTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(867, 38);
            this.productIDTextBox.TabIndex = 13;
            // 
            // supNameTextBox
            // 
            this.supNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupName", true));
            this.supNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supNameTextBox.Location = new System.Drawing.Point(63, 394);
            this.supNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.supNameTextBox.Name = "supNameTextBox";
            this.supNameTextBox.Size = new System.Drawing.Size(867, 38);
            this.supNameTextBox.TabIndex = 15;
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupplierID", true));
            this.supplierIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierIDTextBox.Location = new System.Drawing.Point(63, 512);
            this.supplierIDTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.ReadOnly = true;
            this.supplierIDTextBox.Size = new System.Drawing.Size(867, 38);
            this.supplierIDTextBox.TabIndex = 17;
            // 
            // frmEditSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1300, 1055);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.prodNameTextBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(supNameLabel);
            this.Controls.Add(this.supNameTextBox);
            this.Controls.Add(supplierIDLabel);
            this.Controls.Add(this.supplierIDTextBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmEditSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditSuppliers";
            this.Load += new System.EventHandler(this.frmEditSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource editSupplierBindingSource;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox supNameTextBox;
        private System.Windows.Forms.TextBox supplierIDTextBox;
    }
}