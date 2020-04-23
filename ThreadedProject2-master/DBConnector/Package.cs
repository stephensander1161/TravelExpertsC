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
 * this class is for holdinmg product objects from a sql db
 *
 */

namespace DBConnector
{
    /// <summary>
    /// A class object representing a package from a database
    /// </summary>
    public class Package
    {
        /// <summary>
        /// The non-nullable package ID
        /// </summary>
        public int PackageId { get; set; }

        /// <summary>
        /// The non-nullable package name
        /// </summary>
        public string PkgName { get; set; }

        /// <summary>
        /// The start date of a package
        /// </summary>
        public DateTime? PkgStartDate { get; set; }

        /// <summary>
        /// The end date of a package
        /// </summary>
        public DateTime? PkgEndDate { get; set; }

        /// <summary>
        /// The package description
        /// </summary>
        public string  PkgDesc { get; set; }

        /// <summary>
        /// The non-nullable package price
        /// </summary>
        public decimal PkgBasePrice { get; set; }

        /// <summary>
        /// The commission value of the package
        /// </summary>
        public decimal? PkgAgencyCommission { get; set; }

        /// <summary>
        /// Compares this instance of a Package to the supplied Package Object to evaluate if their values
        /// are equivalent. If the objects match, return true.
        /// </summary>
        /// <param name="package">to package object to compare against</param>
        /// <returns></returns>
        public bool CompareTo(Package package)
        {
            if (this.PackageId == package.PackageId &&
                this.PkgAgencyCommission == package.PkgAgencyCommission &&
                this.PkgBasePrice == package.PkgBasePrice &&
                this.PkgDesc == package.PkgDesc &&
                this.PkgEndDate == package.PkgEndDate &&
                this.PkgName == package.PkgName &&
                this.PkgStartDate == package.PkgStartDate)
                return true;
            else
                return false;
        }
    }
}
