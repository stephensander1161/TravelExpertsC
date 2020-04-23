using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ProductSupplierDB written by Brian Appleton
namespace DBConnector
{
    public class ProductSupplierDB
    {

        /// <summary>
        /// <author>Brian Appleton</author>
        /// Gets a product supplier from a product id and supplier id
        /// </summary>
        /// <returns></returns>
        public static ProductSupplier GetProductSupplier(int productId, int supplierId)
        {
            ProductSupplier productSupplier = null;

            SqlConnection con = TravelExpertsConnection.GetConnection();

            string selectStatement = "SELECT ProductSupplierID, ProductID, SupplierID " +
                                     "FROM Products_Suppliers " +
                                     "WHERE ProductID = @ProductID AND " +
                                     "SupplierID = @SupplierID";


            using (SqlCommand cmd = new SqlCommand(selectStatement, con))
            {
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@SupplierID", supplierId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);


                if (reader.Read()) // found a customer
                {
                    productSupplier = new ProductSupplier
                    {
                        ProductSupplierID = (int)reader["ProductSupplierID"],
                        ProductID = (int)reader["ProductID"],
                        SupplierID = (int)reader["SupplierID"]
                    };
                }
                con.Close();
            }
            return productSupplier;
        }
    }
}
