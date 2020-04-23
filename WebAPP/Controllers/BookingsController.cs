using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAPP;

namespace WebAPP.Controllers
{
    public class BookingsController : Controller
    {
        private TravelExpertsEntities db = new TravelExpertsEntities();


        // GET: Bookings for customer logged in
        public ActionResult Index(string searchBy, string search)
        {

            //get email of user
            string username = (string)Session["Username"];

            if (Object.Equals(Session["Username"], null))
            {
                return View("Login", "Customer", "Customer");
            }

            //get bookings for customer
            var bookings = db.Bookings.Include(b => b.Customer).Include(b => b.Package).Where(x => x.Customer.Username == username);

            return View(bookings.ToList());

        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
