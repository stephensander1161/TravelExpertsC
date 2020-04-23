using DBConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProductSupplierManager
{
    public partial class frmProductSupplierManager : Form
    {

        List<Product> Suppliers;
        public Supplier supplier;

        public frmProductSupplierManager()


        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Suppliers = ProductDB.GetAllProducts();
            cboProdNames.DataSource = Suppliers;
            cboProdID.DataSource = Suppliers;
        }

        private void inputSupplierData(Supplier supplier)
        {
            supplier.ProdName = cboProdNames.SelectedValue.ToString();
            supplier.ProductID = Convert.ToInt32(cboProdID.SelectedValue);
            supplier.SupName = txtSupName.Text;
            supplier.SupplierID = Convert.ToInt32(txtSupID.Text);
        }

        private void frmProductSupplierManager_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboProdNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            supplier = new Supplier();
            this.inputSupplierData(supplier);
            try
            {
                supplier.SupplierID = SupplierDB.AddSupplier(supplier);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}

