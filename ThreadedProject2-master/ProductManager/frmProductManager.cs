using DBConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
//Product Manager page, Author Stephen Sander
namespace ProductManager
{
    public partial class frmProductManager : MetroFramework.Controls.MetroUserControl
    {

        List<Product> products; // list of all products
        List<Supplier> suppliers; // list of all suppliers
        const int EDIT_BUTTON_INDX = 2; // column in the product grid that contains Edit button
        const int EDITSUPPLIERS_BUTTON_INDX = 2; //column in the suppliers grid that contains Edit button
        Product oldProduct; //declares old product object (used for updating/editing)
        Supplier oldSupplier; //declares old supplier object (used for updating/editing)
       
        public frmProductManager()
        {
            InitializeComponent();
        }

        private void frmProductManager_Load(object sender, EventArgs e)
        {
            // names the form on load
            this.Text = "Product Information Page";

            try
            {
                //gets all products and puts in products list object
                products = ProductDB.GetAllProducts();
                //gives the list of products to the Products Name combobox
                productComboBox.DataSource = products;
                //gives the list of products to the Products gridbox
                ProductGridView.DataSource = products;
            }
            catch (Exception ex)
            {
                //if try fails, throws this exception
                MessageBox.Show("Error while loading Products data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void btnRefreshSuppliers_Click(object sender, EventArgs e)
        { //refreshes the page (same code as page load)
            try
            {  
                products = ProductDB.GetAllProducts();
                productComboBox.DataSource = products;
                ProductGridView.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading Products data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }
       
        //method activates when user selects a different product from the list
        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedValue == null)
                return;
            //gets supplier from DB based on which product selected from combobox
            suppliers = SupplierDB.GetSupplier((int)cmb.SelectedValue);
            //assigns the suppliers list to the Grid (that corresponds to the selection from combobox)
            SupplierDataGridView.DataSource = suppliers;
        }
     
        private void btnRefreshSupplies_Click(object sender, EventArgs e)
        {
            //refreshes the page, same code as frm load function
            try
            {
                products = ProductDB.GetAllProducts();
                productComboBox.DataSource = products;
                ProductGridView.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading Products data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void btnAddProductToSupplier_Click(object sender, EventArgs e)
        {
            //opens the AddProductsToSuppliers form
            frmAddProductsToSuppliers f2 = new frmAddProductsToSuppliers();
            f2.ShowDialog(); 
        }

        private void btnAddANewProduct_Click(object sender, EventArgs e)
        {
            //opens the add a new product form
            frmAdd f3 = new frmAdd();
            f3.ShowDialog(); // Shows add form
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //refreshes the page, same code as frm load function
            try
            {
                products = ProductDB.GetAllProducts();
                productComboBox.DataSource = products;
                ProductGridView.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading Products data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void ProductGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //method that activates when edit button clicked in the grid
            if (e.ColumnIndex == EDIT_BUTTON_INDX)
            {
                oldProduct = products[e.RowIndex].CopyProduct(); // make a  separate copy before update
                FrmUpdate updateForm = new FrmUpdate(); //opens the update form
                updateForm.product = products[e.RowIndex]; // "pass" current product to the form
                updateForm.oldProduct = oldProduct;        // same for the original product data
                DialogResult result = updateForm.ShowDialog(); // display modal second form
                if (result == DialogResult.OK) // update accepted
                {
                    // refresh the grid view
                    CurrencyManager cm = (CurrencyManager)ProductGridView.BindingContext[products];
                    cm.Refresh();
                }
                else // update cancelled
                {
                    products[e.RowIndex] = oldProduct; // revert to the old values
                }
            }
        }

        private void SupplierDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if edit button selected
            if (e.ColumnIndex == EDITSUPPLIERS_BUTTON_INDX)
            {


                oldSupplier = suppliers[e.RowIndex].CopySupplier(); // make a  separate copy before update
                frmEditSuppliers updateForm = new frmEditSuppliers();
                updateForm.supplier = suppliers[e.RowIndex]; // "pass" current supplier to the form
                updateForm.oldSupplier = oldSupplier;        // same for the original supplier data
                DialogResult result = updateForm.ShowDialog(); // display modal second form
                if (result == DialogResult.OK) // update accepted
                {
                    // refresh the grid view
                    CurrencyManager cm = (CurrencyManager)ProductGridView.BindingContext[products];
                    cm.Refresh();
                }
                else // update cancelled
                {
                    suppliers[e.RowIndex] = oldSupplier; // revert to the old values
                }
            }
        }
    }

}
