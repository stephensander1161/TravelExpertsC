using DBConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add Products To Suppliers, Author Stephen Sander
namespace ProductManager
{
    public partial class frmAddProductsToSuppliers : Form
    {
        List<Supplier> suppliers; //declares suppliers list
        List<Product> products; //declares products list
        Supplier supplier; //declares supplier object
        List<Supplier> suppliersList; //declares list supplierList
        public frmAddProductsToSuppliers()
        {
            InitializeComponent();
        }
        //adds all the user info into the supplier product
        private void PutProductAndSupplierData(Supplier supplier)
        {
            supplier.ProdName = prodNameComboBox.SelectedValue.ToString();
            supplier.ProductID = Convert.ToInt32(productIDComboBox.SelectedValue);
            supplier.SupplierID = Convert.ToInt32(supplierIDComboBox.SelectedValue);
            supplier.SupName = supNameComboBox.SelectedValue.ToString();

        }
        //On load event
        private void frmAddProductsToSuppliers_Load(object sender, EventArgs e)
        {
            this.Text = "Add Products to Suppliers"; //names the form when it loads

            try
            {
                //Gets all suppliers for the suppliersList object
                suppliersList = SupplierDB.GetAllSuppliersForList();
                //Gets all products for the products object
                products = ProductDB.GetAllProducts();
                //gets all suppliers for suppliers object
                suppliers = SupplierDB.GetAllSupplierIDAndName();

                //gives the supplierdatagridview to the suppliers object
                SupplierGrid.DataSource = suppliersList;
                //gives the productID combobox to the products object
                productIDComboBox.DataSource = products;
                //gives the Product Name combobox to the products object
                prodNameComboBox.DataSource = products;
                //gives the Supplier Name combobox to the suppliers object
                supNameComboBox.DataSource = suppliers;
                //gives the SupplierID combobox to the suppliers object
                supplierIDComboBox.DataSource = suppliers;

            }
            catch (Exception ex) //throws exception if it can't assign data sources
            {
                MessageBox.Show("Error while loading Products data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            supplier = new Supplier(); //declares a new supplier object
            this.PutProductAndSupplierData(supplier); //puts the user inputs into the supplier object
            try
            {
                //tries addeding product to supplier
                supplier.SupplierID = SupplierDB.AddProductToSupplier(supplier);
            }
            catch (Exception ex) //if it fails, throw exception
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            //Gets all suppliers for the suppliersList object
            suppliersList = SupplierDB.GetAllSuppliersForList();
            //Gets all products for the products object
            products = ProductDB.GetAllProducts();
            //gets all suppliers for suppliers object
            suppliers = SupplierDB.GetAllSupplierIDAndName();

            //gives the supplierdatagridview to the suppliers object
            SupplierGrid.DataSource = suppliersList;
            //gives the productID combobox to the products object
            productIDComboBox.DataSource = products;
            //gives the Product Name combobox to the products object
            prodNameComboBox.DataSource = products;
            //gives the Supplier Name combobox to the suppliers object
            supNameComboBox.DataSource = suppliers;
            //gives the SupplierID combobox to the suppliers object
            supplierIDComboBox.DataSource = suppliers;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }
    }
    }

