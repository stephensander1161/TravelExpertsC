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

/* Date: Jan 30, 2020
    * Author: Brian Appleton
    *
    * Thread Project #2
    *
    * this is the controller for the booking details view
    *
    *
    */

namespace WebAPP.Controllers
{
    public class BookingDetailsController : Controller
    {
        private readonly TravelExpertsEntities db = new TravelExpertsEntities();


        // GET: BookingDetails/Details/5
        /// <summary>
        /// Booking details for specific booking id of a customer
        /// </summary>
        /// <param name="id">The booking id</param>
        /// <returns></returns>
        public ActionResult Details(int? id)
        {
            //no id provided, return bad request
            if (id == null )
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (Object.Equals(Session["Username"], null))
            {
                return View("Login", "Customer", "Customer");
            }

            var username = (string)Session["Username"];

            //get booking details given a booking id
            var bookingDetail = (from b in db.BookingDetails
                                 where b.BookingId == id 
                                 orderby b.BookingDetailId, b.Products_Suppliers.ProductId
                                 select b);


            //no booking details found, provide customize error page
            if (bookingDetail == null || bookingDetail.ToList().Count < 1)
            {
                ViewBag.Error = "Hmmmm... It Appears You Havent Booked Anything Yet. ";
                ViewBag.BackText = "Back To Bookings";
                ViewBag.BackActionName = "Index";
                ViewBag.BackControllerName = "Bookings";

                return View("~/Views/Error/NotFound.cshtml");
            }


            return View(bookingDetail.ToList());
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
