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
 * an extended class containing products and supplier info
 *
 */

namespace DBConnector
{
    /// <summary>
    /// An extended class of product which contains the linked supplier fields
    /// </summary>
    public class ProductExtended : Product
    {
        public int ProductSupplierId { get; set; }

        public string SupplierName { get; set; }
    }
}
