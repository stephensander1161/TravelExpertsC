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

/*/*
 * WORKSHOP 4 - Threaded Project 2 
 * 
 * Course: CPRG-214
 * Author: Muhammad Khalil
 * Date: Feb 14, 2020
 * 
 * Description:
 * 
 * Form elements with all the necessary code
 * 
 * 
 */

namespace SupplierManager1
{
    public partial class frmSupplierManager : MetroFramework.Controls.MetroUserControl
    {

        private List<int> supplierIDs = new List<int>();
        List<Supplier> suppliers;

        //store the old Supplier name so it can be called later 
        string oldSupName;


        public frmSupplierManager()
        {
            InitializeComponent();
        }

        private void frmSupplierManager_Load_1(object sender, EventArgs e)
        {
            btnDeleteSupplier.Visible = false;
            btnUpdate.Visible = false;
            btnAddSupplier.Visible = false;

            suppliers = SupplierDB.GetSuppliers();
            dataGrid.DataSource = suppliers;
            DisplaySuppliers();
            cmbSupplierID.SelectedIndex = 0;

        }

        /// <summary>
        /// Get all the ids for the suppliers
        /// </summary>
        private void GetSupplierIDs()
        {
            try
            {
                suppliers = SupplierDB.GetSuppliers();

                supplierIDs.Clear();

                foreach (Supplier supplier in suppliers)
                {
                    supplierIDs.Add(supplier.SupplierID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        /// <summary>
        /// Get the supplier ids and populate the combobox with all the supplier ids 
        /// </summary>
        private void DisplaySuppliers()
        {
            GetSupplierIDs();
            cmbSupplierID.Items.Clear();
            foreach (int id in supplierIDs)
            {
                cmbSupplierID.Items.Add(id);
            }
        }

        /// <summary>
        /// Get the records for each supplier ID and populate the datagrid with the records from the database 
        /// </summary>
        /// <param name="supplierID">Selected supplier ID</param>
        private void RefreshRecords(int supplierID)
        {
            suppliers = SupplierDB.GetSupplierByID(supplierID);
            dataGrid.DataSource = suppliers;

            List<Supplier> supplierbyID = new List<Supplier>();

            supplierbyID = SupplierDB.GetSupplierByID(supplierID);

            foreach (Supplier supplier in supplierbyID) // go through the object data base and set each element from the table 
            {
                txtSupID.Text = Convert.ToString(supplier.SupplierID);
                txtSupName.Text = supplier.SupName;
            }
        }

        /// <summary>
        /// Set the supplierID txt box to the selected supplier ID from the combobox
        /// </summary>
        private void cmbSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int supplierID = Convert.ToInt32(cmbSupplierID.Text);
            RefreshRecords(supplierID);
        }

        /// <summary>
        /// Control the visibility of the Edit and New button and set the fields to empty when pressed
        /// Generate a supplierID using the last record in the database 
        /// </summary>
        private void btnNewSpplier_Click(object sender, EventArgs e)
        {
            btnEditSupplier.Visible = true;
            btnNewSpplier.Visible = false;
            lblFeedBack.Text = "New Supplier Mode: Once complete, click 'Add Supplier'";
            btnAddSupplier.Visible = true;

            txtSupName.Text = "";
            int highestID = 0;

            foreach (int num in supplierIDs)
            {
                if (highestID < num)
                {
                    highestID = num;
                }
            }
            highestID++;

            txtSupID.Text = Convert.ToString(highestID);
        }

        /// <summary>
        /// Set the fields 
        /// Check to see if the selected supplier ID already exists and whether the fields are empty 
        /// If conditions are met, insert a new supplier with an auto generated ID and specified supplier name into the database 
        /// </summary>
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            int supplierID = Convert.ToInt32(txtSupID.Text);
            string supName = txtSupName.Text;
            bool SupplierExists = SupplierDB.CheckDataBase(supplierID);


            if (supName == "" || supName == "")
            {
                MessageBox.Show("Please enter a name for the supplier");
                cmbSupplierID.SelectedIndex = 0;
            }

            else if (SupplierExists == false)
            {

                SupplierDB.InsertSupplier(supplierID, supName);

                MessageBox.Show("Supplier with ID: " + supplierID + " AND Suplier Name: " + supName + " Added");
                cmbSupplierID.SelectedItem = cmbSupplierID.Items[cmbSupplierID.Items.Count - 1];

            }

            else
            {
                MessageBox.Show("Supplier with ID: " + supplierID + " already exists");

            }
            RefreshRecords(supplierID);
            DisplaySuppliers();
            cmbSupplierID.SelectedItem = supplierID;

            btnAddSupplier.Visible = false;
            btnNewSpplier.Visible = true;
            lblFeedBack.Text = "";

        }

        /// <summary>
        /// Empty specified fields 
        /// check to see if a value has been selected from the combobox
        /// </summary>
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            btnNewSpplier.Visible = true;
            btnEditSupplier.Visible = false;
            lblFeedBack.Text = "Edit-Mode: Once complete, click 'Update Supplier' ";
            btnUpdate.Visible = true;

            if (cmbSupplierID.Text == "")
            {
                MessageBox.Show("Please select a supplier ID");
            }

            else
            {
                int supplierID = Convert.ToInt32(cmbSupplierID.Text);
                txtSupID.Text = Convert.ToString(supplierID);
                oldSupName = txtSupName.Text;

                txtSupName.Text = "";
            }
        }

        /// <summary>
        /// Check the fields to see if values exist, if not display appropriate messageboxes
        /// Update the database with the edited Supplier name, the supplierID cannot be edited 
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbSupplierID.Text == "")
            {
                MessageBox.Show("Please select a Supplier ID");
            }
            else if ((txtSupName.Text == "") || (txtSupName.Text == ""))
            {
                MessageBox.Show("Please enter a Supplier Name");
            }
            else
            {
                int supplierID = Convert.ToInt32(cmbSupplierID.Text);
                txtSupID.Text = Convert.ToString(supplierID);
                string supName = txtSupName.Text;
                SupplierDB.UpdateSuppliers(supplierID, supName);
                RefreshRecords(supplierID);
                MessageBox.Show("Supplier name has been changed from: " + oldSupName + " to: " + supName);
                cmbSupplierID.SelectedItem = supplierID;
            }

            btnUpdate.Visible = false;
            btnEditSupplier.Visible = true;
            lblFeedBack.Text = "";

        }
        /// <summary>
        /// set the specified fields 
        /// delete specified supplier 
        /// check to see if the deleted supplier has been actually deleted from the database 
        /// </summary>
        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            int supplierID = Convert.ToInt32(txtSupID.Text);
            string supName = txtSupName.Text;

            SupplierDB.DeleteSupplier(supplierID, supName);
            bool SupplierExists = SupplierDB.CheckDataBase(supplierID);

            if (SupplierExists == false)
            {
                txtSupID.Text = "";
                txtSupName.Text = "";
                RefreshRecords(supplierID + 2);
                MessageBox.Show("Supplier with ID: " + supplierID + " deleted");
            }

            else
                MessageBox.Show("Supplier with ID: " + supplierID + " was not deleted");

            DisplaySuppliers();
            cmbSupplierID.SelectedItem = supplierIDs[supplierIDs.Count - 1];


        }

        /// <summary>
        /// Reset the form to startup 
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Reset fields and buttons to default?", "Reset", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                btnEditSupplier.Visible = true;
                btnUpdate.Visible = false;

                btnNewSpplier.Visible = true;
                btnAddSupplier.Visible = false;

                lblFeedBack.Text = "";

                cmbSupplierID.SelectedIndex = 0;


            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
