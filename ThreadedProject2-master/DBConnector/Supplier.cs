using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnector
{
    //Supplier Class - added ProdName and ProductID attributes 
    //(which aren't found in Supplier DB) -original author Stephen Sander 

   public class Supplier
    {
        //ProductID, used when inserting suppliers but not tied to any other tables in DB
        public int ProductID { get; set; }
        //SupplierID, PK of supplier table, linked to the Products_Suppliers Table
        public int SupplierID { get; set; }
        //Supplier Name attribute
        public string SupName { get; set; }
        //ProductName attribute, only used when linking Supplier and Product objects
        public string ProdName { get; set; }

        /// <summary>
        /// <author>Stephen Sander</author>
        /// method used when editing suppliers at the edit suppliers button on products page
        /// </summary>
        /// <returns></returns>
        public Supplier CopySupplier()
        {
            Supplier copy = new Supplier();
            copy.ProductID = ProductID;  //The ProductID of the Product linked to this supplier
            copy.SupplierID = SupplierID;  // This Supplier's ID
            copy.SupName = SupName; //This supplier's Supplier Name 
            copy.ProdName = ProdName; //The Product Name of the Product linked to this supplier
            return copy;
        }

       
    }
    }

