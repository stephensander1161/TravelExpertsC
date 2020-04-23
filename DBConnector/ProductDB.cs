using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//entire class written by Stephen Sander (I think?)
namespace DBConnector
{
    public class ProductDB
    {
        /// <summary>
        /// <Author>Stephen Sander</Author>
        /// Selects all products and puts them in a list, used 
        /// for populating comboboxes and grid views
        /// </summary>

        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            Product prod = null;
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string selectStatement = "SELECT ProductID, ProdName " +
                                     "FROM Products " +
                                     "ORDER BY ProdName";
            SqlCommand cmd = new SqlCommand(selectStatement, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // while there are customers
                {
                    prod = new Product();
                    prod.ProductID = (int)reader["ProductID"];
                    prod.ProdName = reader["ProdName"].ToString();
                    products.Add(prod);
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
            return products;
        }
        /// <summary>
        /// Updates existing customer record
        /// </summary>
        /// <param name="productId">ID used to retrieve product</param>
        /// <returns>indicator of success</returns>
        public static Product GetProductById(int productId)
        {
            Product prod = null;
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string selectStatement = "SELECT ProductID, ProdName " +
                                     "FROM Products " +
                                     "WHERE ProductID = @ProductID";

            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@ProductID", productId); // value comes from the method's argument
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read()) // found a customer
                {
                    prod = new Product();
                    prod.ProductID = (int)reader["ProductID"];
                    prod.ProdName = reader["ProdName"].ToString();
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
            return prod;
        }

        /// <summary>
        /// Adds a new customer to the Customers table in TravelExperts database
        /// </summary>
        /// <param name="prod"> Customer object that cotaing data for the new record</param>
        /// <returns>generated CustomerID</returns>
        public static int AddProduct(Product prod)
        {
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string insertStatement = "INSERT INTO Products (ProdName) " +
                                     "VALUES(@ProdName)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@ProdName", prod.ProdName);
            
            try
            {
                con.Open();
                cmd.ExecuteNonQuery(); // run the insert command
                // get the generated ID - current identity value for  Customers table
                string selectQuery = "SELECT IDENT_CURRENT('Products') FROM Products";
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                int productID = Convert.ToInt32(selectCmd.ExecuteScalar()); // single value
                                                                             // typecase (int) does NOT work!
                return productID;
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
        /// Updates existing customer record
        /// </summary>
        /// <param name="oldProd">data before update</param>
        /// <param name="newProd">new data for the update</param>
        /// <returns>indicator of success</returns>
        public static bool UpdateProduct(Product oldProd, Product newProd)
        {
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string updateStatement = "UPDATE Products " +
                                     "SET ProdName = @NewProdName " +
                                     "WHERE ProductID = @OldProductID ";
                                     
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            cmd.Parameters.AddWithValue("@NewProductID", newProd.ProductID);
            cmd.Parameters.AddWithValue("@NewProdName", newProd.ProdName);
            cmd.Parameters.AddWithValue("@OldProductID", oldProd.ProductID);
            cmd.Parameters.AddWithValue("@OldProdName", oldProd.ProdName);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
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

    }
}
