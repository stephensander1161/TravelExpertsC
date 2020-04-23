using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//class written by Stephen Sander, used to update Customers to the DB
namespace WebAPP.Models
{
    public class UpdateCustomer
    {

        [Required]
        [StringLength(10)]
        [Display(Name = "First Name")]
        public string CustFirstName { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Last Name")]
        public string CustLastName { get; set; }


        [EmailAddress]
        [Display(Name = "Email")]
        public string CustEmail { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Address")]
        public string CustAddress { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "City")]
        public string CustCity { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Province")]
        public string CustProv { get; set; }

        [Required]
        [StringLength(7)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal Code")]
        public virtual string CustPostal { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Country")]
        public string CustCountry { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Home Phone")]
        public string CustHomePhone { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Business Phone")]
        public string CustBusPhone { get; set; }

        //[Required]
        [StringLength(10)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        //[Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
       // [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}