using System;
using System.Collections.Generic;
using System.ComponentModel;
using DBConnector;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//edit product form, author Stephen Sander
namespace ProductManager
{
    public partial class FrmUpdate : Form
    {
        public Product product; // current product
        public Product oldProduct; // original product data
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            //Name at the top of the form when it loads
            this.Text = "Edit Product Page";

            // bind the controls to the product object
            productBindingSource.Clear();
            productBindingSource.Add(product); // bind to the current product
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //tries adding the product to the DB
            bool success = ProductDB.UpdateProduct(oldProduct, product);
            if (success)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            //update failed
            {
                this.DialogResult = DialogResult.Retry;
            }

        }
        //closes the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
