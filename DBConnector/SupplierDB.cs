using DBConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//SupplierDB originally written by Stephen Sander
namespace DBConnector
{
    public class SupplierDB
    {
        /// <summary>
        /// <author>Stephen Sander</author>
        /// Get all suppliers, inner join with Products and Products_Suppliers
        /// to get the product names, but order by Product Name
        /// </summary>
        /// <returns></returns>
        public static List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            Supplier sup = null;
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string selectStatement = "SELECT s.SupplierID, s.SupName, p.ProdName, p.ProductID  " +
                                         "FROM Suppliers s " +
                                         "INNER JOIN Products_Suppliers ps " +
                                         "on s.SupplierID = ps.SupplierID " +
                                         "INNER JOIN Products p " +
                                         "on ps.ProductID = p.ProductID " +
                                         "ORDER BY p.ProdName";

            SqlCommand cmd = new SqlCommand(selectStatement, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // while there are suppliers
                {
                    sup = new Supplier();
                    sup.ProductID = (int)reader["ProductID"];
                    sup.SupplierID = (int)reader["SupplierID"];
                    sup.SupName = reader["SupName"].ToString();
                    sup.ProdName = reader["ProdName"].ToString();
                    suppliers.Add(sup);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return suppliers; 
            }

        /// <summary>
        /// <author>Stephen Sander</author>
        /// Gets all suppliers, inner join with Products and Products_Suppliers
        /// to get the product name, but orders them by Supplier Name
        /// </summary>
        /// <returns></returns>
        public static List<Supplier> GetAllSuppliersForList()
        {
            List<Supplier> suppliers = new List<Supplier>();
            Supplier sup = null;
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string selectStatement = "SELECT s.SupplierID, s.SupName, p.ProdName, p.ProductID  " +
                                         "FROM Suppliers s " +
                                         "INNER JOIN Products_Suppliers ps " +
                                         "on s.SupplierID = ps.SupplierID " +
                                         "INNER JOIN Products p " +
                                         "on ps.ProductID = p.ProductID " +
                                         "ORDER BY s.SupName";

            SqlCommand cmd = new SqlCommand(selectStatement, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // while there are suppliers
                {
                    sup = new Supplier();
                    sup.ProductID = (int)reader["ProductID"];
                    sup.SupplierID = (int)reader["SupplierID"];
                    sup.SupName = reader["SupName"].ToString();
                    sup.ProdName = reader["ProdName"].ToString();
                    suppliers.Add(sup);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return suppliers;
        }
        /// <summary>
        /// <author>Stephen Sander</author>
        /// Get all suppliers by themselves
        /// </summary>
        /// <returns></returns>
        public static List<Supplier> GetAllSupplierIDAndName()
        {
            List<Supplier> suppliers = new List<Supplier>();
            Supplier sup = null;
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string selectStatement = "SELECT SupName, SupplierId " +
                                         "FROM Suppliers  " +    
                                         "ORDER BY SupName";

            SqlCommand cmd = new SqlCommand(selectStatement, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // while there are suppliers
                {
                    sup = new Supplier();
                    sup.SupName = reader["SupName"].ToString();
                    sup.SupplierID = (int)reader["SupplierId"];

                    suppliers.Add(sup);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return suppliers;
        }

        /// <summary>
        /// <author>Stephen Sander </author>
        /// Selects Supplier by ID
        /// </summary>
        ///<param name="productID">passes supplier object to the function</param>
        /// <returns>list of suppliers with matching productID</returns>
        public static List<Supplier> GetSupplier(int productID)
        {
            List<Supplier> suppliers = new List<Supplier>();

            Supplier sup = null;
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string selectStatement = "SELECT s.SupplierID, s.SupName, p.ProdName, p.ProductID  " +
                                     "FROM Suppliers s " +
                                     "INNER JOIN Products_Suppliers ps " +
                                     "on s.SupplierID = ps.SupplierID " +
                                     "INNER JOIN Products p " +
                                     "on ps.ProductID = p.ProductID " +
                                     "WHERE p.ProductID = @ProductID";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@ProductID", productID); // value comes from the method's argument
            try
            {
                //add while loop in list form
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read()) // found a supplier
                {
                    sup = new Supplier();
                    sup.ProductID = (int)reader["ProductID"];

                    sup.SupplierID = (int)reader["SupplierID"];
                    sup.SupName = reader["SupName"].ToString();
                    sup.ProdName = reader["ProdName"].ToString();
                    suppliers.Add(sup);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return suppliers;
        }
        /// <summary>
        /// <author>Stephen Sander </author>
        /// Add a new supplier
        /// </summary>
        /// <param name="sup">passes supplier object to the function</param>
        /// <returns>SupplierID</returns>
        public static int AddSupplier(Supplier sup)
            {
                SqlConnection con = TravelExpertsConnection.GetConnection();
            string insertStatement = "INSERT INTO Suppliers (SupplierId, SupName, ProdName, ProductID) " +
                                         "VALUES(@SupplierId, @SupName, @ProdName, @ProductID)";
                SqlCommand cmd = new SqlCommand(insertStatement, con);
                cmd.Parameters.AddWithValue("@SupplierId", sup.SupplierID);
                cmd.Parameters.AddWithValue("@SupName", sup.SupName);
            cmd.Parameters.AddWithValue("@ProdName", sup.ProdName);

            cmd.Parameters.AddWithValue("@ProductID", sup.ProductID);


                con.Open();
                cmd.ExecuteNonQuery(); // run the insert command
                                       // get the generated ID - current identity value for  Customers table
                string selectQuery = "SELECT IDENT_CURRENT('Suppliers') FROM Suppliers";
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                int supplierID = Convert.ToInt32(selectCmd.ExecuteScalar()); // single value
                                                                             // typecase (int) does NOT work!
                return supplierID;
            }
        /// <summary>
        /// <Author>Stephen Sander</Author>
        /// Adds a product to a supplier
        /// </summary>
        /// <param name="sup">passes supplier object to the function</param>
        /// <returns>returns if the number of updated rows is more than 1</returns>
        /// <summary>
        /// <author>Stephen Sander </author>
       
        public static int AddProductToSupplier(Supplier sup)
        {
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string insertStatement = "INSERT INTO Products_Suppliers (SupplierId, ProductId, SupName, ProdName) " +
                                      "Values(@SupplierId, @ProductId, @SupName, @ProdName) ";
                                     


            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@SupplierId", sup.SupplierID);
            cmd.Parameters.AddWithValue("@SupName", sup.SupName);
            cmd.Parameters.AddWithValue("@ProdName", sup.ProdName);
            cmd.Parameters.AddWithValue("@ProductId", sup.ProductID);


            try
            {
                con.Open();
                                       // get the generated ID - current identity value for  Customers table
                int supplierID = Convert.ToInt32(cmd.ExecuteScalar()); // single value
                return supplierID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// <Author>Stephen Sander</Author>
        /// Gets all products linked to a specific package
        /// </summary>
        /// <param name="oldSup">old supplier before update</param>
        /// <param name="newSup">new supplier post update</param>
        /// <returns>returns if the number of updated rows is more than 1</returns>
        public static bool UpdateSupplier(Supplier oldSup, Supplier newSup)
        {
            int count;
            using (SqlConnection con = TravelExpertsConnection.GetConnection())
            {
                string updateStatement = "UPDATE Suppliers SET " +
                                         " SupName = @newSupName, " +
                                         " ProdName = @newProdName, " +
                                         " ProductID = @newProductID " +
                                         " WHERE SupplierId = @oldSupplierId " +
                                         " AND SupName = @oldSupName ";
                using (SqlCommand cmd = new SqlCommand(updateStatement, con))
                {
                    cmd.Parameters.AddWithValue("@newSupName", newSup.SupName);
                    cmd.Parameters.AddWithValue("@newProdName", newSup.ProdName);
                    cmd.Parameters.AddWithValue("@newProductID", newSup.ProductID);
                    cmd.Parameters.AddWithValue("@oldSupplierId", oldSup.SupplierID);
                    cmd.Parameters.AddWithValue("@oldSupName", oldSup.SupName);
                    cmd.Parameters.AddWithValue("@oldProdName", oldSup.ProdName);
                    cmd.Parameters.AddWithValue("@oldProductID", oldSup.ProductID);
                    con.Open();
                    count = cmd.ExecuteNonQuery(); // returns how many rows updated
                }
            }

            return (count > 0);
        }

        /// <summary>
        /// <auther>Muhammad Khalil</auther>
        /// retrieve each supplier and its elements
        /// </summary>
        /// <returns></returns>
        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>(); //empty list 
            Supplier supp; //aux for reading 


            using (SqlConnection connection = TravelExpertsConnection.GetConnection())
            {
                string query = "SELECT SupplierID, SupName " +
                                "FROM Suppliers " +
                                "ORDER BY SupplierID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (reader.Read())
                    {
                        supp = new Supplier();
                        supp.SupplierID = (int)reader["Supplierid"];
                        supp.SupName = (string)reader["SupName"];


                        suppliers.Add(supp);
                    }
                }
            }

            return suppliers;
        }

        /// <summary>
        /// <author> Brian Appleton</author>
        /// Gets all the suppliers attached to a specific product
        /// </summary>
        /// <param name="productId">the product id</param>
        /// <returns></returns>
        public static BindingList<Supplier> GetProductSuppliers(int productId)
        {
            BindingList<Supplier> suppliers = new BindingList<Supplier>();

            SqlConnection con = TravelExpertsConnection.GetConnection();

            string selectStatement = "SELECT s.SupName,s.SupplierId,pr.ProdName " +
                                    "FROM Products_Suppliers as p " +
                                    "JOIN Suppliers as s " +
                                    "ON s.SupplierId = p.SupplierId " +
                                    "JOIN Products as pr " +
                                    "ON pr.ProductId = p.ProductId " +
                                    "WHERE pr.ProductID = @ProductID";


            using (SqlCommand cmd = new SqlCommand(selectStatement, con))
            {
                cmd.Parameters.AddWithValue("@ProductID", productId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read()) // found a customer
                {
                    Supplier supplier = new Supplier()
                    {
                        SupName = (string)reader[0],
                        SupplierID = (int)reader[1],
                        ProdName = (string)reader[2],
                    };

                    suppliers.Add(supplier);
                }

                return suppliers;
            }
        }

        //retrieve the suppliers by supplierid through the query 
        public static List<Supplier> GetSupplierByID(int supplierID)
        {
            List<Supplier> suppliers = new List<Supplier>(); //empty list 
            Supplier supp; //aux for reading 

            using (SqlConnection connection = TravelExpertsConnection.GetConnection())
            {
                string query = "SELECT Supplierid, SupName " +
                                "FROM Suppliers " +
                                "WHERE Supplierid = @Supplierid " +
                                "ORDER BY Supplierid";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("Supplierid", supplierID);
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (reader.Read())
                    {
                        supp = new Supplier();
                        supp.SupplierID = (int)reader["Supplierid"];
                        supp.SupName = (string)reader["SupName"];


                        suppliers.Add(supp);
                    }
                }
            }

            return suppliers;
        }

        /// <summary>
        /// <auther>Muhammad Khalil</auther>
        /// check the database for existing supplier ids
        /// </summary>
        /// <param name="supplierID">Selected supplier id</param>
        /// <returns></returns>
        public static bool CheckDataBase(int supplierID)
        {
            bool success = false;
            int count = 0;


            SqlConnection connection = TravelExpertsConnection.GetConnection();

            string query = "SELECT Supplierid " +
                            "FROM Suppliers " +
                            "WHERE Supplierid = @Supplierid";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("Supplierid", supplierID);


            try
            {
                connection.Open();

                // execute the command
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }
                // check if successful
                if (count > 0)
                    success = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return success;
        }

        /// <summary>
        /// <auther>Muhammad Khalil</auther>
        /// using the selected supplierid, update the Supplier name 
        /// </summary>
        /// <param name="supplierID">Selected supplierID</param>
        /// <param name="supName">Supplier name from the textbox</param>
        public static void UpdateSuppliers(int supplierID, string supName)
        {

            using (SqlConnection connection = TravelExpertsConnection.GetConnection())
            {
                string updateStatement =
                   "UPDATE Suppliers SET " +
                   "SupName = @SupName " +
                   "WHERE Supplierid = @Supplierid";  // needed for identification


                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@SupName ", supName);
                    cmd.Parameters.AddWithValue("@Supplierid ", supplierID);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// <auther>Muhammad Khalil</auther>
        /// Insert an autogenerated Suipplier ID and add an assoociated supplier name into the database 
        /// </summary>
        /// <param name="supplierID"> Autogenerated ID</param>
        /// <param name="supName">Supplier name from the textbox</param>
        public static void InsertSupplier(int supplierID, string supName)
        {

            using (SqlConnection connection = TravelExpertsConnection.GetConnection())
            {
                string insertStatement =
                   "INSERT INTO Suppliers(SupName, Supplierid) " +
                   "VALUES (@SupName, @Supplierid)";


                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@SupName ", supName);
                    cmd.Parameters.AddWithValue("@Supplierid ", supplierID);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }
        
        /// <summary>
        /// <auther>Muhammad Khalil</auther>
        /// using the selected supplierid, delete the record from the database 
        /// this only works for added records not for original referenced records
        /// </summary>
        /// <param name="supplierID"></param>
        /// <param name="supName"></param>
        public static void DeleteSupplier(int supplierID, string supName)
        {

            using (SqlConnection connection = TravelExpertsConnection.GetConnection())
            {
                string insertStatement =
                   "DELETE FROM Suppliers " +
                   " Where Supplierid = @Supplierid";


                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@SupName ", supName);
                    cmd.Parameters.AddWithValue("@Supplierid ", supplierID);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }

    }
}

