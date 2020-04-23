
using MetroFramework.Controls;
using MetroFramework.Forms;
using ProductManager;
using SupplierManager1;
using System;
using System.Drawing;
using System.Windows.Forms;
using ThreadedProject2;

/* Date: Jan 30, 2020
 * Author: Brian Appleton
 * 
 * Thread Project #2
 * 
 * this class is the main entry point to the app and creates the uniform layout and menus for all forms
 *
 *
 */

namespace MainApp
{

  
    public partial class frmMainView : MetroForm
    {
        MetroUserControl PackageManager;
        MetroUserControl ProductManager;
        MetroUserControl SupplierManager;

        public frmMainView()
        {
            InitializeComponent();

             PackageManager = new frmPackageManager();
             ProductManager = new frmProductManager();
             SupplierManager = new frmSupplierManager();
             this.BackColor = Color.Gray;

        }

        ///resolves issues with double buffering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }

        }

        private void frmMainView_Load(object sender, EventArgs e)
        {
            InitializeUserControl(PackageManager);
            InitializeUserControl(SupplierManager);
            InitializeUserControl(ProductManager);

        }

        private void InitializeUserControl(MetroUserControl metroUserControl)
        {
            metroUserControl.Dock = DockStyle.Fill;
            metroPanel2.Controls.Add(metroUserControl);
        }



        private void metroTile1_Click(object sender, EventArgs e)
        {
            ShowUserControl(PackageManager);
        }

        private void ShowUserControl(MetroUserControl control)
        {
            
           SupplierManager.Hide();
           ProductManager.Hide();
           PackageManager.Hide();

            control.Show();
        }


        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            ShowUserControl(ProductManager);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ShowUserControl(SupplierManager);
        }
    }
}
