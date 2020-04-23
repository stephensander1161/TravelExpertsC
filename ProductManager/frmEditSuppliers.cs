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
//Edit Suppliers Page author Stephen Sander
namespace ProductManager
{
    public partial class frmEditSuppliers : Form
    {
        public Supplier supplier; //declares supplier object
        public Supplier oldSupplier; //declares old supplier object
        

       

        public frmEditSuppliers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            //attempts to update the supplier, passing the old and new supplier objects
            bool success = SupplierDB.UpdateSupplier(oldSupplier, supplier);
            if (success)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Retry;
            }


        }

        private void frmEditSuppliers_Load(object sender, EventArgs e)
        {
            //Name at the top of the form when it loads
            this.Text = "Edit Supplier Page";

            // bind the controls to the product object
            supplierBindingSource.Clear();
            supplierBindingSource.Add(supplier); // bind to the current product
            

        }
    }
}
