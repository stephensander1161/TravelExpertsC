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
//Form Add code, author Stephen Sander
namespace ProductManager
{
    public partial class frmAdd : Form
    {
        Product product; //declares product object

        public frmAdd()
        {
            InitializeComponent();
        }

       
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
         product = new Product(); //creates new product object
         this.PutProductData(product); //puts user data into the product object
        try
        {
        product.ProdName = ProductDB.AddProduct(product).ToString(); //adds product to the DB
        this.ClearControls(); // clears the textboxes to add another product
        }
        catch (Exception ex)
        {
        MessageBox.Show(ex.Message, ex.GetType().ToString()); //catches exception
        }
       }

        private void ClearControls() //wipes the textbox and puts focus on the add textbox
        {
            txtAdd.Text = "";
            txtAdd.Focus();
        }

        private void PutProductData(Product product) //puts the user info into the product object
        {
            product.ProdName = txtAdd.Text;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            this.Text = "Add Product"; //names the form when it loads

        }
    }
    }

