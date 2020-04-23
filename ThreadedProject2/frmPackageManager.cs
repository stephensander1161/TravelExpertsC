
using DBConnector;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ThreadedProject2
{
    public partial class frmPackageManager : MetroFramework.Controls.MetroUserControl
    {

        /// <summary>
        /// The currently selected package
        /// </summary>
        private Package PackageSelected { get; set; }


        /// <summary>
        /// the binded list of package id's
        /// </summary>

        readonly BindingList<Package> PackageIds = new BindingList<Package>();

        /// <summary>
        /// the list of products attached to a package
        /// </summary>

        readonly BindingList<ProductExtended> PackageProducts = new BindingList<ProductExtended>();

        /// <summary>
        /// the list of products in the database
        /// </summary>
        readonly BindingList<Product> Products = new BindingList<Product>();

        /// <summary>
        /// The list of suppliers associated to a specific product
        /// </summary>
        BindingList<Supplier> Suppliers = new BindingList<Supplier>();

        public frmPackageManager()
        {
            InitializeComponent();
        }

        #region General Methods

        /// <summary>
        /// validated a input string field and sets the errorprovidor on errors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ValidateString(object sender, CancelEventArgs e)
        {
            int maxCharCount = 50;

            if (!PackageValidator.IsValidString((TextBox)sender, maxCharCount))
                e.Cancel = true;
        }


        private void InitializeFormData()
        {

            //bind combo box to package id's
            cmbPackageIds.DataSource = PackageIds;
            cmbPackageIds.DisplayMember = nameof(Package.PkgName);
            cmbPackageIds.ValueMember = nameof(Package.PackageId);

            //bind combo box to product names
            cmbProductList.DataSource = Products;
            cmbProductList.DisplayMember = nameof(Product.ProdName);
            cmbProductList.ValueMember = nameof(Product.ProductID);

            //bind combo box to suppliers
            cmbSuppliers.DataSource = Suppliers;
            cmbSuppliers.DisplayMember = nameof(Supplier.SupName);
            cmbSuppliers.ValueMember = nameof(Supplier.SupplierID);

            //Bind the datagrid to the list containing all relavent products
            dtgProducts.DataSource = PackageProducts;

            //get product and package data from db
            GetBindedProductsAll();
            GetBindedPackageIds(-1);

            //get product suppliers linked to the selected combo box product
            GetBindedProductSuppliers((int?)cmbProductList.SelectedValue);

            //display package and products
            if (PackageIds.Count > 0)
                DisplayPackageDetails(PackageIds[0]);

        }

        /// <summary>
        /// resolves issues with double buffering and flickering when shwoing the form
        /// <author> From StackOverflow </author>
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        #endregion General Methods

        #region Product Methods

        /// <summary>
        /// Saves the newly created product from the form into the database
        /// </summary>
        private void SaveNewProduct()
        {
            if (!ValidateNewProduct())
                return;

            try
            {
                int newPackageID = PackageDB.InsertPackage(GetPackageFromFields());
                Package package = PackageDB.GetById(newPackageID);

                GetBindedPackageIds(newPackageID);
                DisplayPackageDetails(package);
                HideNewPackageLayout(newPackageID);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        /// <summary>
        /// validates a new package 
        /// </summary>
        /// <returns></returns>
        private bool ValidateNewProduct()
        {
            bool validDesc = PackageValidator.IsValidString(tbxPkgDesc, 50);
            bool validName = PackageValidator.IsValidString(tbxPkgName, 50);
            bool validEndDate = PackageValidator.IsValidEndDate(dtpPkgEndDate, dtpPkgStartDate.Value);
            bool validCommission = PackageValidator.IsValidCommission(tbxPkgCommission, tbxPkgPrice);
            bool validPrice = PackageValidator.IsValidPrice(tbxPkgPrice);

            if (validDesc && validName && validEndDate && validCommission && validPrice)
                return true;
            else
                return false;


        }

        /// <summary>
        /// removes the selected datagrid product from the database
        /// </summary>
        private void RemoveProduct()
        {
            //nothing selected, return.
            if (dtgProducts.SelectedRows.Count == 0)
                return;

            ProductExtended product = (ProductExtended)dtgProducts.CurrentRow.DataBoundItem;

            try
            {
                ProductExtendedDB.DeletePackageProductsById(PackageSelected.PackageId, product.ProductSupplierId);
                GetBindedPackageProducts(PackageSelected.PackageId);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Unable to delete product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProduct()
        {
            //get from combo boxes
            Product product = (Product)cmbProductList.SelectedItem;
            Supplier supplier = (Supplier)cmbSuppliers.SelectedItem;

            try
            {
                AddProductToPackage(product.ProductID, supplier.SupplierID);
            }
            catch (Exception)
            {
                MessageBox.Show($"Unable to add product \"{product.ProdName.ToUpper()}\" with supplier: \"{supplier.SupName.ToUpper()}\" to package id \"{PackageSelected.PackageId}\"", "Unable to add product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add a product to the package
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="supplierId"></param>
        private void AddProductToPackage(int productId, int supplierId)
        {
            try
            {
                //get the productsupplier from db
                ProductSupplier productSupplier = ProductSupplierDB.GetProductSupplier(productId, supplierId);

                //create the PPS to be added to db
                PackageProductSupplier newPackagePS = new PackageProductSupplier()
                {
                    ProductSupplierId = productSupplier.ProductSupplierID,
                    PackageId = PackageSelected.PackageId
                };

                if (!PackageValidator.IsPackageProductSupplierExisting(newPackagePS))
                {
                    //add packageproductsupplier to db
                    PackageProductSupplierDB.Add(newPackagePS);
                    GetBindedPackageProducts(PackageSelected.PackageId);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Unable to add product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Gets all Suppliers linked to a specified product
        /// </summary>
        /// <param name="productId"></param>
        private void GetBindedProductSuppliers(int? productId)
        {
            if (Object.Equals(productId, null))
                return;

            Suppliers.Clear();

            try
            {
                foreach (Supplier supplier in SupplierDB.GetProductSuppliers((int)productId))
                    Suppliers.Add(supplier);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Unable to get product suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Displays products associated with a package
        /// </summary>
        /// <param name="packageID"></param>
        private void GetBindedPackageProducts(int packageID)
        {
            //clear any existing products attached to the package
            if (!Object.Equals(PackageProducts, null))
                PackageProducts.Clear();

            try
            {
                //get the products linked to the package
                foreach (ProductExtended product in ProductExtendedDB.GetPackageProductsById(packageID))
                    PackageProducts.Add(product);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Unable to get package products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Get the products for the package from the DB
        /// </summary>
        private void GetBindedProductsAll()
        {
            List<Product> productList = ProductDB.GetAllProducts();

            //clear existing products
            if (Products.Count > 0)
                Products.Clear();

            //get products and add to binding list
            foreach (Product product in productList)
                Products.Add(product);

        }

        #endregion Products Methods

        #region Package Methods

        //unsubscribe or subcribe to all package events
        private void ToggleEventsOn(bool toggleOn)
        {
            if (toggleOn)
            {
                //subscribe to updating events on control fields
                tbxPkgName.Validated += tbxPkgName_Validated;
                tbxPkgName.Validating += tbxPkgName_Validating;

                tbxPkgDesc.Validated += tbxPkgDesc_Validated;
                tbxPkgDesc.Validating += tbxPkgDesc_Validating;

                tbxPkgPrice.Validated += tbxPkgPrice_Validated;
                tbxPkgPrice.Validating += tbxPkgPrice_Validating;

                tbxPkgCommission.Validated += tbxPkgCommission_Validated;
                tbxPkgCommission.Validating += tbxPkgCommission_Validating;

                dtpPkgEndDate.ValueChanged += dtpPkgEndDate_ValueChanged;
                dtpPkgStartDate.ValueChanged += dtpPkgStartDate_ValueChanged;
            }
            else
            {
                //unsubscribe to updating events on control fields
                tbxPkgName.Validated -= tbxPkgName_Validated;
                tbxPkgName.Validating -= tbxPkgName_Validating;

                tbxPkgDesc.Validated -= tbxPkgDesc_Validated;
                tbxPkgDesc.Validating -= tbxPkgDesc_Validating;

                tbxPkgPrice.Validated -= tbxPkgPrice_Validated;
                tbxPkgPrice.Validating -= tbxPkgPrice_Validating;

                tbxPkgCommission.Validated -= tbxPkgCommission_Validated;
                tbxPkgCommission.Validating -= tbxPkgCommission_Validating;

                dtpPkgEndDate.ValueChanged -= dtpPkgEndDate_ValueChanged;
                dtpPkgStartDate.ValueChanged -= dtpPkgStartDate_ValueChanged;
            }
        }

        private void ToggleNewPackageControls(bool toggleOn)
        {
            if (toggleOn)
            {
                cmbPackageIds.Enabled = false;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                btnNewPackage.Enabled = false;
                pnlProductDetails.Visible = false;
                lblPackageName.Text = "New Package";

                lblPackageName.Tag = new Color[2] {
                    lblPackageName.BackColor,
                    lblPackageName.ForeColor
                };

                lblPackageName.BackColor = Color.PaleVioletRed;
                lblPackageName.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                cmbPackageIds.Enabled = true;
                btnSave.Visible = !btnSave.Visible;
                btnCancel.Visible = !btnCancel.Visible;
                btnNewPackage.Enabled = !btnNewPackage.Enabled;
                pnlProductDetails.Visible = true;
                lblPackageName.BackColor = ((Color[])lblPackageName.Tag)[0];
                lblPackageName.ForeColor = ((Color[])lblPackageName.Tag)[1];

                //deselect product and supplier
                cmbProductList.SelectedIndex = -1;
                cmbSuppliers.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Cancels the creation of a new package
        /// </summary>
        private void CancelNewPackageCreation()
        {
            ClearFormErrors();

            ToggleNewPackageControls(false);

            GetBindedPackageIds((cmbPackageIds.SelectedItem as Package).PackageId);
        }

        //clears all error providor messages on form.
        private void ClearFormErrors()
        {
            foreach (Control control in pnlPackage.Controls)
                PackageValidator.ClearErrors(control);

        }

        /// <summary>
        /// Get the package from the form
        /// </summary>
        /// <returns></returns>
        private Package GetPackageFromFields()
        {
            Package package = new Package
            {
                PackageId = (Object.Equals(cmbPackageIds.SelectedValue, null)) ? 0 : (int)cmbPackageIds.SelectedValue,
                PkgAgencyCommission = (String.IsNullOrEmpty(tbxPkgCommission.Text)) ? null : (decimal?)(Convert.ToDecimal(tbxPkgCommission.Text)),
                PkgBasePrice = Convert.ToDecimal(tbxPkgPrice.Text),
                PkgDesc = tbxPkgDesc.Text,
                PkgEndDate = (dtpPkgEndDate.CustomFormat == " ") ? null : (DateTime?)dtpPkgEndDate.Value,
                PkgStartDate = (dtpPkgStartDate.CustomFormat == " ") ? null : (DateTime?)dtpPkgStartDate.Value,
                PkgName = tbxPkgName.Text
            };

            return package;
        }

        private void DisplayCharCount(TextBox tb, Label label)
        {
            label.Text = $"{tb.Text.Length}/50";
        }

        /// <summary>
        /// Updates the Package Fields displayed on the form
        /// </summary>
        /// <param name="package"></param>
        private bool DisplayPackage(int packageId, bool isNewPackage = false)
        {
            //the package displayed is the same as the package selected from the drop down... do not redisplay.
            if (!Object.Equals(PackageSelected, null) &&
                packageId == PackageSelected.PackageId &&
                PackageSelected.PkgName == lblPackageName.Text)
                return false;

            if (isNewPackage)
            {
                PackageSelected = new Package()
                {
                    PackageId = -1,
                    PkgAgencyCommission = null,
                    PkgBasePrice = 0m,
                    PkgDesc = "",
                    PkgEndDate = DateTime.Today.AddDays(1),
                    PkgName = "",
                    PkgStartDate = DateTime.Today
                };
            }
            else
                PackageSelected = PackageDB.GetById(packageId);  //get the package data

            //Update properties
            tbxPkgName.Text
                = String.IsNullOrEmpty(PackageSelected.PkgName) ?
                String.Empty : PackageSelected.PkgName.ToString();

            tbxPkgPrice.Text = Decimal.Round(PackageSelected.PkgBasePrice, 2).ToString();

            tbxPkgCommission.Text =
                (PackageSelected.PkgAgencyCommission.HasValue) ?
                Decimal.Round((decimal)PackageSelected.PkgAgencyCommission, 2).ToString() : String.Empty;

            tbxPkgDesc.Text = String.IsNullOrEmpty(PackageSelected.PkgDesc) ?
                String.Empty : PackageSelected.PkgDesc.ToString();

            //start date is null, remove format
            if (Object.Equals(PackageSelected.PkgStartDate, null))
                ShowEmptyDate(dtpPkgStartDate, true);
            else
            {
                ShowEmptyDate(dtpPkgStartDate, false);
                dtpPkgStartDate.Text = PackageSelected.PkgStartDate.ToString();
            }

            //end date is null, remove format
            if (Object.Equals(PackageSelected.PkgEndDate, null))
                ShowEmptyDate(dtpPkgEndDate, true);
            else
            {
                ShowEmptyDate(dtpPkgEndDate, false);
                dtpPkgEndDate.Text = PackageSelected.PkgEndDate.ToString();
            }

            //update char count labels
            DisplayCharCount(tbxPkgDesc, lblDescCharCount);
            DisplayCharCount(tbxPkgName, lblNameCharCount);

            //If package name is updated, update related name controls ONLY
            if (PackageSelected.PkgName != lblPackageName.Text)
            {
                lblPackageName.Text = PackageSelected.PkgName.ToString();

            }

            return true;
        }


        private void DisplayNewPackageLayout()
        {
            tbxPkgName.Focus();
            DisplayPackage(-1, true);

            ToggleNewPackageControls(true);
            ToggleEventsOn(false);
        }

        private void HideNewPackageLayout(int packageIdToShow)
        {
            this.SuspendLayout();
            ToggleNewPackageControls(false);
            ToggleEventsOn(true);
            tbxPkgName.Focus();
            this.ResumeLayout();
        }

        private void DisplayPackageDetails(Package package, bool getUpdatedPackages = true)
        {
            if (Object.Equals(package, null))
                return;

            DisplayPackage(package.PackageId);
            GetBindedPackageProducts(package.PackageId);

            //deselect product and supplier
            cmbProductList.SelectedIndex = -1;
            cmbSuppliers.SelectedIndex = -1;
        }


        private void SetPackageName(string packageName)
        {
            //name hasnt changed. return
            if (packageName == PackageSelected.PkgName)
                return;

            PackageIds.Remove(PackageSelected);
            PackageSelected.PkgName = packageName;

            try
            {
                PackageDB.UpdatePropertyById(nameof(Package.PkgName), PackageSelected);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Unable to update package", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the package id's from the DB
        /// </summary>
        private void GetBindedPackageIds(int defaultPackageID = 0)
        {

            int selectedIndex;
            try
            {
                List<Package> Packages = PackageDB.GetAll();

                if (defaultPackageID >= 0) //store the current selected index of combo box
                    selectedIndex = Packages.FindIndex(x => x.PackageId == defaultPackageID);
                else  // select the first packageid in the index
                    selectedIndex = 0;

                //prevent firing of events when a packageId is provided
                if (defaultPackageID > 0)
                    cmbPackageIds.SelectedIndexChanged -= cmbPackageIds_SelectedIndexChanged;

                //set package ids datsource and index
                cmbPackageIds.DataSource = Packages;
                cmbPackageIds.SelectedIndex = selectedIndex;

                //resubscribe when a packageId is provided
                if (defaultPackageID > 0)
                    cmbPackageIds.SelectedIndexChanged += cmbPackageIds_SelectedIndexChanged;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Unable to get package id's", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void SetEndDate(bool removeDate = false)
        {
            if (removeDate)
            {
                dtpPkgEndDate.Value = DateTime.Now.AddDays(1);
                PackageSelected.PkgEndDate = null;
                ShowEmptyDate(dtpPkgEndDate, true);
            }
            else
            {
                PackageSelected.PkgEndDate = dtpPkgEndDate.Value;
                ShowEmptyDate(dtpPkgEndDate, false);
            }

            try
            {
                PackageDB.UpdatePropertyById(nameof(Package.PkgEndDate), PackageSelected);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Unable to update end date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ShowEmptyDate(DateTimePicker dtp, bool showEmptyDate)
        {
            if (showEmptyDate)
                dtp.CustomFormat = " ";
            else
                dtp.CustomFormat = "dd/MM/yyyy";
        }

        /// <summary>
        /// Sets the start date of the package
        /// </summary>
        /// <param name="dateTimePicker"></param>
        /// <param name="removeDate"></param>
        private void SetStartDate(bool removeDate = false)
        {

            //date field is cleared, display it as such and update DB, also remove end date
            if (removeDate)
            {
                //clear start date field and End Date Field and updated db
                ShowEmptyDate(dtpPkgStartDate, true);
                PackageSelected.PkgStartDate = null;
            }
            else //update display date and DB
            {
                ShowEmptyDate(dtpPkgStartDate, false);
                PackageSelected.PkgStartDate = dtpPkgStartDate.Value;
            }

            try
            {
                PackageDB.UpdatePropertyById(nameof(Package.PkgStartDate), PackageSelected);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Unable to update start date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion Package Methods

        #region Events

        /// <summary>
        /// Event occurs when form is first loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPackageManager_Load(object sender, EventArgs e)
        {
            InitializeFormData();

        }

        /// <summary>
        /// Event occurs when user presses clear on end date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearEndDate_Click(object sender, EventArgs e)
        {
            SetEndDate(true);
        }

        /// <summary>
        /// Event occurs when user presses clear on start date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearStartDate_Click(object sender, EventArgs e)
        {
            SetStartDate(true);
        }

        /// <summary>
        /// Event occurs when form visibility is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPackageManager_VisibleChanged(object sender, EventArgs e)
        {
            //refresh the Products list when current form is set to VISIBLE
            if (this.Visible)
            {
                GetBindedProductsAll();
                this.Invalidate();
                cmbPackageIds.Focus();
            }

        }

        /// <summary>
        /// event occurs when a product is selected from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductList_SelectedIndexChanged(object sender, EventArgs e)
        {

            GetBindedProductSuppliers((int?)(sender as ComboBox).SelectedValue);
        }

        /// <summary>
        /// event occurs when package name is validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgName_Validated(object sender, EventArgs e)
        {
            SetPackageName((sender as TextBox).Text);
            DisplayPackage(PackageSelected.PackageId);
            GetBindedPackageIds(PackageSelected.PackageId);
        }


        /// <summary>
        /// event occurs when package name is validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgName_Validating(object sender, CancelEventArgs e)
        {
            ValidateString(sender, e);
        }

        /// <summary>
        /// event occurs when description is validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgDesc_Validating(object sender, CancelEventArgs e)
        {
            ValidateString(sender, e);
        }

        /// <summary>
        /// event occurs when descript has been validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgDesc_Validated(object sender, EventArgs e)
        {
            PackageSelected.PkgDesc = (sender as TextBox).Text;
            try
            {
                PackageDB.UpdatePropertyById(nameof(Package.PkgDesc), PackageSelected);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "Unable to update package description", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// event occures when price has been validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgPrice_Validated(object sender, EventArgs e)
        {
            PackageSelected.PkgBasePrice = Convert.ToDecimal((sender as TextBox).Text);
            try
            {
            PackageDB.UpdatePropertyById(nameof(Package.PkgBasePrice), PackageSelected);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "Unable to update package price", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// event occurs when price is being validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!PackageValidator.IsValidMonetaryValue((TextBox)sender))
                e.Cancel = true;

        }

        /// <summary>
        /// Event after validating commission field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgCommission_Validated(object sender, EventArgs e)
        {
            string commission = (sender as TextBox).Text;

            PackageSelected.PkgAgencyCommission =
                (commission != null) ? Convert.ToDecimal(commission) : (decimal?)null;
            try
            {
                 PackageDB.UpdatePropertyById(nameof(Package.PkgAgencyCommission), PackageSelected);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "Unable to update package commission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// event after commission field is validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgCommission_Validating(object sender, CancelEventArgs e)
        {
            if (!PackageValidator.IsValidCommission((TextBox)sender, tbxPkgPrice))
                e.Cancel = true;
        }

        /// <summary>
        /// Event occurs when an end date is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpPkgEndDate_ValueChanged(object sender, EventArgs e)
        {
            bool validDate = PackageValidator.IsValidEndDate((DateTimePicker)sender, dtpPkgStartDate.Value);

            if (validDate)
                SetEndDate();
        }

        /// <summary>
        /// event occurs when a start date is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpPkgStartDate_ValueChanged(object sender, EventArgs e)
        {
            SetStartDate(false);
        }

        private void tbxPkgName_TextChanged(object sender, EventArgs e)
        {
            DisplayCharCount((TextBox)sender, lblNameCharCount);
        }

        private void tbxPkgDesc_TextChanged(object sender, EventArgs e)
        {
            DisplayCharCount((TextBox)sender, lblDescCharCount);
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            RemoveProduct();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelNewPackageCreation();
        }


        private void btnNewPackage_Click(object sender, EventArgs e)
        {
            DisplayNewPackageLayout();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveNewProduct();

        }

        /// <summary>
        /// Event occurs when user selects a package id from the combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPackageIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Display the package and products
            DisplayPackageDetails((Package)(sender as ComboBox).SelectedItem);
        }
        #endregion events
    }
}
