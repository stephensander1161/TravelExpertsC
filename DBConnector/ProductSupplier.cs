using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ProductSupplier class written by Stephen Sander
namespace DBConnector
{
    public class ProductSupplier
    {
        //ProductSupplierID attribute
        public int ProductSupplierID { get; set; }
        //ProductID attribute, links to the Product Table in the DB
        public int ProductID { get; set; }
        //SupplierID attribute, links to the Supplier Table in the DB
        public int SupplierID { get; set; }
    }
}
