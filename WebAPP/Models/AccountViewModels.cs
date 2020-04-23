﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPP.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {

        [Required]
        [StringLength(10)]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Province")]
        public string Province { get; set; }

        [Required]
        [StringLength(7)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal Code")]
        public virtual string PostalCode { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Business Phone")]
        public string BusPhone { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
