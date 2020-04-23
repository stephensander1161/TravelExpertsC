using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnector
{
    public class ProductExtendedDB
    {
        /// <summary>
        /// <Author>Brian Appleton</Author>
        /// Gets all products linked to a specific package
        /// </summary>
        /// <param name="packageId">package id to retrieve products for</param>
        /// <returns>returns a list of packages</returns>
        public static List<ProductExtended> GetPackageProductsById(int packageId)
        {
            List<ProductExtended> products = new List<ProductExtended>();

            SqlConnection con = TravelExpertsConnection.GetConnection();

            //sql command to get all products tied to a specific package
            string command =
                "SELECT pkg.PackageId, pro.ProductId, pro.ProdName, pps.ProductSupplierId, sup.SupName " +
                "FROM Packages AS pkg " +
                "JOIN Packages_Products_Suppliers as pps " +
                "ON pkg.PackageId = pps.PackageId " +
                "JOIN Products_Suppliers as s " +
                "ON s.ProductSupplierId = pps.ProductSupplierId " +
                "JOIN Products as pro " +
                "ON pro.ProductId = s.ProductId " +
                "JOIN Suppliers as sup " +
                "ON s.SupplierId = sup.SupplierId " +
                "WHERE pkg.PackageId = @PackageId";


            using (SqlCommand cmd = new SqlCommand(command, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@PackageId", packageId);

                using (SqlDataReader read = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            ProductExtended product = new ProductExtended()
                            {
                                ProductID = (int)read["ProductId"],
                                ProdName = read["ProdName"].ToString(),
                                ProductSupplierId = (int)read["ProductSupplierId"],
                                SupplierName = read["SupName"].ToString()
                            };
                            products.Add(product);
                        }
                    }

                }// close data reader
            }// close command
            return products;
        }

        /// <summary>
        /// <Author>Brian Appleton</Author>
        /// Deletes a product linked to a package
        /// </summary>
        public static bool DeletePackageProductsById(int packageId, int productSupplierID)
        {
            SqlConnection con = TravelExpertsConnection.GetConnection();
            string delete = "DELETE FROM Packages_Products_Suppliers " +
                                     "WHERE PackageId = @PackageId " +
                                     "AND ProductSupplierId = @ProductSupplierId ";

            using (SqlCommand cmd = new SqlCommand(delete, con))
            {
                cmd.Parameters.AddWithValue("@PackageId", packageId);
                cmd.Parameters.AddWithValue("@ProductSupplierId", productSupplierID);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                if (rowsAffected > 0)
                    return true;
                return false;
            }
        }

    }
}
