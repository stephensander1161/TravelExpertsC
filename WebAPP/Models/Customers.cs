using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPP.Models
{
    /// <summary> Muhammad Khalil
    /// All the get, set properties for retriving appropriate data from the form 
    /// </summary>
    public class Customers 
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
        [RegularExpression(@"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$", ErrorMessage = "Please enter correct email address")]
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
        [StringLength(2, ErrorMessage = "Province Only takes 2 characters")]
        [Display(Name = "Province")]
        public string CustProv { get; set; }

        [Required]
        [StringLength(7)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal Code")]
        [RegularExpression(@"^[ABCEGHJ-NPRSTVXYabceghj-nprstvxy][0-9][ABCEGHJ-NPRSTV-Zabceghj-nprstv-z] ?[0-9][ABCEGHJ-NPRSTV-Zabceghj-nprstv-z][0-9]$",
            ErrorMessage = "Invalid format (A1A 1A1)")]
        public virtual string CustPostal { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Country")]
        public string CustCountry { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Home Phone")]
        [RegularExpression(@"([0-9]{10})$", ErrorMessage = "Invalid Phone Number")]
        public string CustHomePhone { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Business Phone")]
        [RegularExpression(@"([0-9]{10})$", ErrorMessage = "Invalid Phone Number")]
        public string CustBusPhone { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Minimum length of 6 characters required", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}