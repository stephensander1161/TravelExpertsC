using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Date: Jan 30, 2020
 * Author: Brian Appleton
 * 
 * Thread Project #2
 * 
 * this class is for holding Package_Product_Supplier objects from a sql db
 *
 */
namespace DBConnector
{
    public class PackageProductSupplier
    {

        public int PackageId { get; set; }

        public int ProductSupplierId { get; set; }
    }
}
