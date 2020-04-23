using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//entire class written by Stephen Sander
namespace DBConnector
{
    /// <summary>
    /// <Author>Stephen Sander</Author>
    /// product class, mirrors the products table in the database
    /// </summary>
    
    public class Product
    {
        //ID attribute
        public int ProductID { get; set; }

        //Name attribute
        public string ProdName { get; set; }

        /// <summary>
        /// <Author>Stephen Sander</Author>
        /// class used when updating products
        /// </summary>
        
        public Product CopyProduct()
        {
            Product copy = new Product();
            copy.ProductID = ProductID; ; // this customer's ID
            copy.ProdName = ProdName;
            return copy;
        }
    }
}
