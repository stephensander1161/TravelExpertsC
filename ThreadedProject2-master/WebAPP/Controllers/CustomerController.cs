using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPP.Models;

namespace WebAPP.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        /// <summary> Muhammad Khalil
        /// Get customer details like user and email from the database,  validate for duplicates 
        /// Store the session varilables so they can be called later 
        /// Provide appropriate messages when users use the application 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>customer from the form</returns>
        [HttpPost]
        public ActionResult Register(Customers customer)
        {
            if (ModelState.IsValid)
            {
                int existingUsername = CustomersDB.GetUserDetails(customer.UserName);
                int existingEmail = CustomersDB.GetEmailDetails(customer.CustEmail);

                if (existingUsername == 0 && existingEmail == 0)
                {
                    CustomersDB.RegisterCustomers(customer);

                    Session["Username"] = customer.UserName;
                    Session["CustFirstName"] = customer.CustFirstName;
                    Session["CustLastName"] = customer.CustLastName;
                    ViewBag.firstName = Session["CustFirstName"];
                    ViewBag.lastName = Session["CustLastName"];
                    ViewBag.Message = "Valid User";

                    return RedirectToAction("Index", "Home");
                }
                else if (existingUsername > 0 || existingEmail > 0)
                {
                    if (existingUsername > 0)
                        ViewBag.UsernameMessage = "This username is already taken";
                    if (existingEmail > 0)
                        ViewBag.EmailMessage = "This email is already taken";
                }
            }


            return View();
        }

        public ViewResult Login()
        {
            return View();
        }
        /// <summary> Muhammad Khalil
        /// compare user details from the form with the database and provide appropriate
        /// messages when useers try to log in 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>customer from the form</returns>
        [HttpPost]
        public ActionResult Login(Customers customer)
        {
           Customers newCustomer =  CustomersDB.CheckLogin(customer);
           //Customers 
           if (newCustomer.UserName == customer.UserName)
            {
                Session["Username"] = customer.UserName;
                Session["CustFirstName"] = customer.CustFirstName;
                Session["CustLastName"] = customer.CustLastName;
                ViewBag.firstName = Session["CustFirstName"];
                ViewBag.lastName = Session["CustLastName"];
                ViewBag.Message = "Valid User";
                //return View();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Username either doesn't exist or Username and Password don't match ";
                return View();
            }

        }
        /// <summary>Muhammad Khalil
        /// Log out the customer and redirect to the appropriate page
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            Session["Username"] = null;
            //Session["Password"] = null;

            return RedirectToAction("Login", "Customer");
        }
       
        //GET
        //Retrieves existing customer from the database Author Stephen Sander
        public ActionResult GetCustomer(string username)
        {
            username = (string)Session["Username"];
            UpdateCustomer oldCust = CustomersDB.GetCustomer(username);
            return View(oldCust);
        }

        //POST
        //updates customer info and posts it to the DB Author Stephen Sander
        [HttpPost]
        public ActionResult GetCustomer( UpdateCustomer newCust)
        {
            string username = (string)Session["Username"];

            try
            {
                UpdateCustomer oldCust = CustomersDB.GetCustomer(username);
                //Thread.Sleep(10000)
                int count = CustomersDB.UpdateCustomer(oldCust, newCust);
                if (count == 0)// no update due to concurrency issue
                    TempData["errorMessage"] = "Update aborted. " +
                        "Another user changed or deleted this row";
                else
                    TempData["errorMessage"] = "";
                return RedirectToAction("Index", "Home");
            
            }
            catch
            {
                return View();
            }
        }

    }


}



    


 

     
