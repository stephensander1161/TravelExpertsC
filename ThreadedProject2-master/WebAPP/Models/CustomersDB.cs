using DBConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebAPP.Models
{
    public static class CustomersDB
    {
        //Update customer method, takes the original customer and updates in DB with new 
        //Values Author Stephen Sander
       public static int UpdateCustomer(UpdateCustomer oldCust, UpdateCustomer newCust)
        {

            int count; // how many rows updated
            using (SqlConnection connection = TravelExpertsConnection.GetConnection())
            {
                string updateStatement =
                    "UPDATE Customers SET " +
                    " CustFirstName = @newCustFirstName, " +
                    " CustLastName = @newCustLastName, " +
                    " CustAddress = @newCustAddress, " +
                    " CustCity = @newCustCity, " +
                    " CustProv = @newCustProv, " +
                    " CustPostal = @newCustPostal, " +
                    " CustCountry = @newCustCountry, " +
                    " CustHomePhone = @newCustHomePhone, " +
                    " CustBusPhone = @newCustBusPhone, " +
                    " CustEmail = @newCustEmail " +

                    "WHERE Username = @oldUsername " + // to identify record
                " AND CustLastName = @oldCustLastName " + // remaining conditions - otimistic concurrency
                " AND CustAddress = @oldCustAddress " +
                " AND CustCity = @oldCustCity " +
                " AND CustProv = @oldCustProv " +
                " AND CustPostal = @oldCustPostal" +
                " AND CustCountry = @oldCustCountry" +
                " AND CustHomePhone = @oldCustHomePhone" +
                " AND CustBusPhone = @oldCustBusPhone" +
                " AND CustEmail = @oldCustEmail";



                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@newCustFirstName", newCust.CustFirstName);
                    cmd.Parameters.AddWithValue("@newCustLastName", newCust.CustLastName);
                    cmd.Parameters.AddWithValue("@newCustAddress", newCust.CustAddress);
                    cmd.Parameters.AddWithValue("@newCustCity", newCust.CustCity);
                    cmd.Parameters.AddWithValue("@newCustProv", newCust.CustProv);
                    cmd.Parameters.AddWithValue("@newCustPostal", newCust.CustPostal);
                    cmd.Parameters.AddWithValue("@newCustCountry", newCust.CustCountry);
                    cmd.Parameters.AddWithValue("@newCustHomePhone", newCust.CustHomePhone);
                    cmd.Parameters.AddWithValue("@newCustBusPhone", newCust.CustBusPhone);
                    cmd.Parameters.AddWithValue("@newCustEmail", newCust.CustEmail);

                    cmd.Parameters.AddWithValue("@oldUsername", oldCust.UserName);
                    cmd.Parameters.AddWithValue("@oldCustFirstName", oldCust.CustFirstName);
                    cmd.Parameters.AddWithValue("@oldCustLastName", oldCust.CustLastName);
                    cmd.Parameters.AddWithValue("@oldCustAddress", oldCust.CustAddress);
                    cmd.Parameters.AddWithValue("@oldCustCity", oldCust.CustCity);
                    cmd.Parameters.AddWithValue("@oldCustProv", oldCust.CustProv);
                    cmd.Parameters.AddWithValue("@oldCustPostal", oldCust.CustPostal);
                    cmd.Parameters.AddWithValue("@oldCustCountry", newCust.CustCountry);
                    cmd.Parameters.AddWithValue("@oldCustHomePhone", oldCust.CustHomePhone);
                    cmd.Parameters.AddWithValue("@oldCustBusPhone", oldCust.CustBusPhone);
                    cmd.Parameters.AddWithValue("@oldCustEmail", oldCust.CustEmail);

                    connection.Open();
                    count = cmd.ExecuteNonQuery(); // returns how many rows updated
                }
            }

            return count;
        }
        
        /// <summary> Muhammad Khalil
        /// Get the customer email for the appropriate username
        /// </summary>
        /// <param name="Username"></param>
        /// <returns>username from the database</returns>
        public static string GetCustomerEmail(string Username)
        {
            string Email = "";
            try
            {
                using (SqlConnection connection = TravelExpertsConnection.GetConnection())
                {
                    string query = "SELECT CustEmail " +
                                    "FROM Customers " +
                                    "WHERE Username = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        cmd.Parameters.AddWithValue("Username", Username);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Email = reader[0].ToString();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return Email;
        }

        //selects customer by username in the DB Author Stephen Sander
    public static UpdateCustomer GetCustomer(string username)
        {
            UpdateCustomer cust = null;
            using (SqlConnection connection = TravelExpertsConnection.GetConnection())
            {
                string query = " SELECT CustFirstName, CustLastName, CustAddress, CustCity, CustProv, " +
                                    " CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail, Username, Password " +
                               " FROM Customers " +
                               " WHERE Username = @Username ";
                              
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read()) // if there is data
                        {
                            cust = new UpdateCustomer();
                            cust.CustFirstName = reader["CustFirstName"].ToString();
                            cust.CustLastName = reader["CustLastName"].ToString();
                            cust.CustAddress = reader["CustAddress"].ToString();
                            cust.CustCity = reader["CustCity"].ToString();
                            cust.CustProv = reader["CustProv"].ToString();
                            cust.CustPostal = reader["CustPostal"].ToString();
                            cust.CustCountry = reader["CustCountry"].ToString();
                            cust.CustHomePhone = reader["CustHomePhone"].ToString();
                            cust.CustBusPhone = reader["CustBusPhone"].ToString();
                            cust.CustEmail = reader["CustEmail"].ToString();
                            cust.UserName = reader["Username"].ToString();
                        }
                    }
                }
            }
            return cust;
        } // end GetCustomer method

        /// <summary>
        /// Insert all the data from the registration form into the database
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>Customer from the registration form</returns>
        public static Customers RegisterCustomers(Customers customer)
        {
            try
            {
                using (SqlConnection connection = TravelExpertsConnection.GetConnection())
                {
                    string query = "INSERT into Customers(CustFirstName, CustLastName, CustAddress, CustCity, CustProv, " +
                                    "CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail, Username, Password) " +
                                    "VALUES(@CustFirstName, @CustLastName, @CustAddress, @CustCity, @CustProv, @CustPostal, " +
                                    "@CustCountry, @CustHomePhone, @CustBusPhone, @CustEmail, @Username, @Password)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.Parameters.AddWithValue("CustFirstName", customer.CustFirstName);
                        cmd.Parameters.AddWithValue("CustLastName", customer.CustLastName);
                        cmd.Parameters.AddWithValue("CustAddress", customer.CustAddress);
                        cmd.Parameters.AddWithValue("CustCity", customer.CustCity);
                        cmd.Parameters.AddWithValue("CustProv", customer.CustProv);
                        cmd.Parameters.AddWithValue("CustPostal", customer.CustPostal);
                        cmd.Parameters.AddWithValue("CustCountry", customer.CustCountry);
                        if (customer.CustHomePhone == null)
                        {
                            cmd.Parameters.AddWithValue("CustHomePhone", " ");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("CustHomePhone", customer.CustHomePhone);
                        }
                        if (customer.CustBusPhone == null)
                        {
                            cmd.Parameters.AddWithValue("CustBusPhone", " ");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("CustBusPhone", customer.CustBusPhone);
                        }
                        if (customer.CustEmail == null)
                        {
                            cmd.Parameters.AddWithValue("CustEmail", " ");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("CustEmail", customer.CustEmail);
                        }

                        cmd.Parameters.AddWithValue("Username", customer.UserName);
                        cmd.Parameters.AddWithValue("Password", Encryption.Encrypt(customer.Password));
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return customer;

        }

        /// <summary> Muhammad Khalil
        /// Compare the login info from the form to the database
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>from log in form</returns>
        public static Customers CheckLogin(Customers customer)
        {
            int count = 0;
            try
            {
                using (SqlConnection connection = TravelExpertsConnection.GetConnection())
                {
                    string query = "SELECT Username, Password " +
                                    "FROM Customers " +
                                    "WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        
                        cmd.Parameters.AddWithValue("Username", customer.UserName);
                        cmd.Parameters.AddWithValue("Password", Encryption.Encrypt(customer.Password));

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            count++;
                        }

                        if (count == 0)
                        {
                            return new Customers { UserName = "", Password = "" };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return customer;

        }

        /// <summary>Muhammad Khalil
        /// Get username from the form and compare it with the username from the database
        /// validation for duplicates
        /// </summary>
        /// <param name="Username"></param>
        /// <returns>username from the form</returns>
        public static int GetUserDetails(string Username)
        {
            int count = 0;
            
            Customers customer = new Customers();
            try
            {

                using (SqlConnection connection = TravelExpertsConnection.GetConnection())
                {
                    string query = "SELECT Username " +
                                    "FROM Customers " +
                                    "WHERE Username = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        cmd.Parameters.AddWithValue("Username", Username);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            count++;
                            
                            customer.UserName = reader[0].ToString();
                            

                        }
                        reader.Close();

                    }
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return count;
        }

        /// <summary>Muhammad Khalil
        /// Get email and compare with the database
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static int GetEmailDetails(string email)
        {
            int count = 0;
            
            Customers customer = new Customers();
            try
            {
                using (SqlConnection connection = TravelExpertsConnection.GetConnection())
                {
                    string query = "SELECT CustEmail " +
                                    "FROM Customers " +
                                    "WHERE custEmail = @email";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        cmd.Parameters.AddWithValue("email", email);

                        SqlDataReader reader = cmd.ExecuteReader();

                        //Customers customer;
                        while (reader.Read())
                        {
                            count++;
                            customer.CustEmail = reader[0].ToString();
                            

                        }
                        reader.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return count;
        }

        //author stephen sander 
        public static int UpdatePassword(UpdateCustomer oldCust, UpdateCustomer newCust)
        {
            int count; // how many rows updated
            using (SqlConnection connection = TravelExpertsConnection.GetConnection())
            {
                string updateStatement =
                    "UPDATE Customers SET " +
                    " Password = @newPassword " +
                    "WHERE Username = @oldUsername "; // to identify record
                   
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@newPassword", newCust.Password); 
                    cmd.Parameters.AddWithValue("@oldUsername", oldCust.UserName);
                    connection.Open();
                    count = cmd.ExecuteNonQuery(); // returns how many rows updated
                }
            }

            return count;
        

    } // end class
      //author stephen sander
    public static UpdateCustomer GetPassword(string password)
        {
            UpdateCustomer cust = null;
            using (SqlConnection connection = TravelExpertsConnection.GetConnection())
            {
                string query = "SELECT Password " +
                               "FROM Customers " +
                               "WHERE Password = @Password"; // query w/parameter
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Password", password);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read()) // if there is data
                        {
                            cust = new UpdateCustomer();
                            cust.Password = (string)reader["Password"];
                           
                        }
                    }
                }
            }
            return cust;
        } // end GetCustomer method
    }

    public static class Encryption
    {
        public static string hash = "h*DH#13F5*&s@d2@#9*H#(*HD[(*H)*FG#&DJ()!@)(JPUDOIUD#O*";

        public static string Decrypt(string text)
        {
            string decrypt = "";

            byte[] data = Convert.FromBase64String(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES =
                            new TripleDESCryptoServiceProvider()
                            {
                                Key = key,
                                Mode = CipherMode.ECB,
                                Padding = PaddingMode.PKCS7
                            }
                      )
                {
                    ICryptoTransform transform = tripleDES.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    decrypt = UTF8Encoding.UTF8.GetString(result);

                }
            }
            return decrypt;
        }
        public static string Encrypt(string text)
        {
            string encrypt = "";
            byte[] data = UTF8Encoding.UTF8.GetBytes(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES =
                            new TripleDESCryptoServiceProvider()
                            {
                                Key = key,
                                Mode = CipherMode.ECB,
                                Padding = PaddingMode.PKCS7
                            }
                      )
                {
                    ICryptoTransform transform = tripleDES.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    encrypt = Convert.ToBase64String(result, 0, result.Length);
                }
            }
            return encrypt;
        }
    }
    
}