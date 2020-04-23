using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Date: Jan 30, 2020
 * Author: Brian Appleton
 * 
 * Thread Project #2
 * 
 * this class is for updating and retrieve data from a sql db
 *
 *
 */

namespace DBConnector
{
    public static class PackageProductSupplierDB
    {
        /// <summary>
        /// Add a PackageProductSupplier to the DB
        /// </summary>
        /// <param name="packageId"></param>
        /// <param name="productSupplierId"></param>
        /// <returns></returns>
        public static bool Add(PackageProductSupplier packageProductSupplier)
        {

            if (Object.Equals(packageProductSupplier, null))
                return false;

            string query =
                "INSERT INTO Packages_Products_Suppliers(PackageId, ProductSupplierId) " +
                "Values(@PackageId,@ProductSupplierId)";

            int rowsUpdated;

            SqlConnection connect = TravelExpertsConnection.GetConnection();

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {


                cmd.Parameters.AddWithValue("@PackageId", packageProductSupplier.PackageId);
                cmd.Parameters.AddWithValue("@ProductSupplierId", packageProductSupplier.ProductSupplierId);

                connect.Open();

                rowsUpdated = cmd.ExecuteNonQuery();

                connect.Close();
            }

            //no rows updated.
            if (rowsUpdated == 0)
                return false;
            else
                return true;
        }

        public static PackageProductSupplier Get(PackageProductSupplier packageProductSupplier)
        {
            if (Object.Equals(packageProductSupplier, null))
                return null;

            PackageProductSupplier package = null;

            SqlConnection con = TravelExpertsConnection.GetConnection();

            string command =
                "SELECT PackageId, ProductSupplierId " +
                "FROM Packages_Products_Suppliers " +
                "WHERE PackageId = @PackageId " +
                "AND ProductSupplierId = @ProductSupplierId";

            using (SqlCommand cmd = new SqlCommand(command, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@PackageId", packageProductSupplier.PackageId);
                cmd.Parameters.AddWithValue("@ProductSupplierId", packageProductSupplier.ProductSupplierId);

                SqlDataReader read = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (read.Read())
                {
                    package = new PackageProductSupplier()
                    {
                        PackageId = (int)read["PackageId"],
                        ProductSupplierId = (int)read["ProductSupplierId"]
                    };
                } 
            } // close command
            return package;
        }
    }
}
