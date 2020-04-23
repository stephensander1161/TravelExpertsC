using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
    /// <summary>
    /// A class for CRUD operations on the package table
    /// </summary>
    public static class PackageDB
    {

        /// <summary>
        /// gets a package object by id from the database
        /// </summary>
        /// <param name="packageId"></param>
        /// <returns></returns>
        public static Package GetById(int packageId)
        {

            Package package = null;

            SqlConnection con = TravelExpertsConnection.GetConnection();
            string command =
                "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                "FROM Packages " +
                "Where PackageId = @PackageId";

            using (SqlCommand cmd = new SqlCommand(command, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@PackageId", packageId);

                SqlDataReader read = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (read.Read())
                {
                    package = new Package()
                    {
                        PackageId = (int)read["PackageId"],
                        PkgName = (string)read["PkgName"],
                        PkgStartDate = (read["PkgStartDate"] == DBNull.Value) ? (DateTime?)null : (DateTime)read["PkgStartDate"],
                        PkgEndDate = (read["PkgEndDate"] == DBNull.Value) ? (DateTime?)null : (DateTime)read["PkgEndDate"],
                        PkgDesc = (read["PkgDesc"] == DBNull.Value) ? String.Empty : (string)read["PkgDesc"],
                        PkgBasePrice = (decimal)read["PkgBasePrice"],
                        PkgAgencyCommission = (read["PkgAgencyCommission"] == DBNull.Value) ? (decimal?)null : (decimal)read["PkgAgencyCommission"],
                    };
                } //close while
            } // close command
            return package;
        }

        /// <summary>
        /// gets a package object without an Id
        /// </summary>
        /// <param name="packageId"></param>
        /// <returns></returns>
        public static Package GetWithoutId(Package package)
        {

            SqlConnection con = TravelExpertsConnection.GetConnection();
            string command =
                "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                "FROM Packages " +
                "Where PkgName = @PkgName AND " +
                "PkgDesc = @PkgDesc AND " +
                "PkgBasePrice = @PkgBasePrice ";


            using (SqlCommand cmd = new SqlCommand(command, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@PkgName", package.PkgName);
                cmd.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
                cmd.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);

                SqlDataReader read = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (read.Read())
                {
                    package = new Package()
                    {
                        PackageId = (int)read["PackageId"],
                        PkgName = (string)read["PkgName"],
                        PkgStartDate = (read["PkgStartDate"] == DBNull.Value) ? (DateTime?)null : (DateTime)read["PkgStartDate"],
                        PkgEndDate = (read["PkgEndDate"] == DBNull.Value) ? (DateTime?)null : (DateTime)read["PkgEndDate"],
                        PkgDesc = (read["PkgDesc"] == DBNull.Value) ? String.Empty : (string)read["PkgDesc"],
                        PkgBasePrice = (decimal)read["PkgBasePrice"],
                        PkgAgencyCommission = (read["PkgAgencyCommission"] == DBNull.Value) ? (decimal?)null : (decimal)read["PkgAgencyCommission"],
                    };
                } //close while
            } // close command
            return package;
        }

        /// <summary>
        /// Gets all package ids and names
        /// </summary>
        /// <returns></returns>
        public static List<Package> GetAll()
        {
            List<Package> package = new List<Package>();

            SqlConnection con = TravelExpertsConnection.GetConnection();
            string command = "SELECT PackageId, PkgName FROM Packages ORDER BY PkgName";

            using (SqlCommand cmd = new SqlCommand(command, con))
            {
                con.Open();
                SqlDataReader read = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (read.Read())

                    package.Add(new Package()
                    {
                        PackageId = (int)read["PackageId"],
                        PkgName = (string)read["PkgName"],
                    });

            } // close command

            return package;
        }



        /// <summary>
        /// Updates a package by id in the database
        /// </summary>
        /// <param name="packageId">the package id to be updated</param>
        /// <returns></returns>
        public static bool Update(Package package)
        {
            Package oldPackage = GetById(package.PackageId);

            //given package is null or no id
            if (Object.Equals(package, null) || package.PackageId == 0 || oldPackage.CompareTo(package))
                return false;

            string query =
                "Update Packages " +
                "SET PkgName = @PkgName " +
                "SET PkgStartDate = @PkgStartDate " +
                "SET PkgEndDate = @PkgEndDate " +
                "SET PkgDesc = @PkgDesc " +
                "SET PkgBasePrice = @PkgBasePrice " +
                "SET PkgAgencyCommission = @PkgAgencyCommission " +
                "WHERE PackageId = @PackageId";

            int rowsUpdated;

            SqlConnection connect = TravelExpertsConnection.GetConnection();

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                connect.Open();

                //Non-nullable params
                cmd.Parameters.AddWithValue("@PkgName", package.PkgName);
                cmd.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
                cmd.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);

                //nullable params
                if (Object.Equals(package.PkgAgencyCommission, null))
                    cmd.Parameters.AddWithValue("@PkgAgencyCommission", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);
                if (Object.Equals(package.PkgStartDate, null))
                    cmd.Parameters.AddWithValue("@PkgStartDate", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
                if (Object.Equals(package.PkgEndDate, null))
                    cmd.Parameters.AddWithValue("@PkgEndDate", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);

                rowsUpdated = cmd.ExecuteNonQuery();

                connect.Close();
            }

            //no rows updated.
            if (rowsUpdated == 0)
                return false;
            else
                return true;
        }

        public static int InsertPackage(Package package)
        {
            //given package is null or no id
            if (Object.Equals(package, null))
                return 0;

            string query =
                "INSERT INTO Packages " +
                "(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission) ";

            SqlConnection connect = TravelExpertsConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand(query, connect))
            {

                cmd.Parameters.AddWithValue("@PkgName", package.PkgName);
                cmd.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
                cmd.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);

                if (Object.Equals(package.PkgAgencyCommission, null))
                    cmd.Parameters.AddWithValue("@PkgAgencyCommission", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);

                if (Object.Equals(package.PkgEndDate, null))
                    cmd.Parameters.AddWithValue("@PkgEndDate", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);

                if (Object.Equals(package.PkgStartDate, null))
                    cmd.Parameters.AddWithValue("@PkgStartDate", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);

                connect.Open();
                int rowsUpdated = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                if (rowsUpdated == 0)
                    return 0;
                else
                    return GetWithoutId(package).PackageId;
                    

            }
        }


        /// <summary>
        /// Updates a specific package property
        /// </summary>
        /// <param name="packageId">the package id to be updated</param>
        /// <returns></returns>
        public static bool UpdatePropertyById(string propertyNameToUpdate, Package package)
        {
            //given package is null or no id
            if (Object.Equals(package, null) || package.PackageId <= 0)
                return false;

            SqlConnection connect = TravelExpertsConnection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@PackageId", package.PackageId);

            string query = String.Empty;

            switch (propertyNameToUpdate)
            {
                case nameof(Package.PkgAgencyCommission):
                    query = "Update Packages SET PkgAgencyCommission = @PkgAgencyCommission WHERE PackageId = @PackageId";
                    if (Object.Equals(package.PkgAgencyCommission, null))
                        cmd.Parameters.AddWithValue("@PkgAgencyCommission", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);
                    break;

                case nameof(Package.PkgBasePrice):
                    query = "Update Packages SET PkgBasePrice = @PkgBasePrice WHERE PackageId = @PackageId";
                    cmd.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
                    break;

                case nameof(Package.PkgDesc):
                    query = "Update Packages SET PkgDesc = @PkgDesc WHERE PackageId = @PackageId";
                    cmd.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
                    break;

                case nameof(Package.PkgEndDate):
                    query = "Update Packages SET PkgEndDate = @PkgEndDate WHERE PackageId = @PackageId";
                    if (Object.Equals(package.PkgEndDate, null))
                        cmd.Parameters.AddWithValue("@PkgEndDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);
                    break;

                case nameof(Package.PkgName):
                    query = "Update Packages SET PkgName = @PkgName WHERE PackageId = @PackageId";
                    cmd.Parameters.AddWithValue("@PkgName", package.PkgName);
                    break;

                case nameof(Package.PkgStartDate):
                    query = "Update Packages SET PkgStartDate = @PkgStartDate WHERE PackageId = @PackageId";
                    if (Object.Equals(package.PkgStartDate, null))
                        cmd.Parameters.AddWithValue("@PkgStartDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
                    break;

                default:
                    return false;
            }

            cmd.CommandText = query;
            cmd.Connection = connect;

            connect.Open();
            int rowsUpdated = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            //no rows updated.
            if (rowsUpdated == 0)
                return false;
            else
                return true;
        }
    }
}
