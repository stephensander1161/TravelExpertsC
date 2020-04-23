//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



/* Date: Jan 30, 2020
 * Author: Brian Appleton
 * 
 * Thread Project #2
 * 
 * class for bookingdetail model
 *
 */

namespace WebAPP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class BookingDetail
    {

        [Display(Name = "Details Id")]
        public int BookingDetailId { get; set; }

        [Display(Name = "Itinerary No")]
        public Nullable<double> ItineraryNo { get; set; }

        [Display(Name = "From")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> TripStart { get; set; }

        [Display(Name = "To")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> TripEnd { get; set; }
        public string Description { get; set; }
        public string Destination { get; set; }

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public Nullable<decimal> BasePrice { get; set; }

        [Display(Name = "Agency Fee")]
        [DataType(DataType.Currency)]
        public Nullable<decimal> AgencyCommission { get; set; }

        [Display(Name = "Booking #")]
        public Nullable<int> BookingId { get; set; }
        public string RegionId { get; set; }
        public string ClassId { get; set; }
        public string FeeId { get; set; }
        public Nullable<int> ProductSupplierId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Fee Fee { get; set; }
        public virtual Products_Suppliers Products_Suppliers { get; set; }
        public virtual Class Class { get; set; }

        /// <summary>
        /// the total price of this object including fee's, excluding traveler count multiplication
        /// </summary>
        [DataType(DataType.Currency)]
        [Display(Name = "Total")]
        public decimal LineTotal
        {
            get
            {
                decimal basePriceTotal = 0m;
                decimal feeTotal = 0m;
                decimal commissionTotal = 0m;

                if (this.BasePrice.HasValue)
                    basePriceTotal = this.BasePrice.Value;

                if (this.Fee.FeeAmt > 0)
                    feeTotal = this.Fee.FeeAmt;

                if (this.AgencyCommission.HasValue)
                    commissionTotal = this.AgencyCommission.Value;

                return (basePriceTotal + feeTotal + commissionTotal);
            }
        }
        /// <summary>
        /// the total price of all fees for a booking, excluding traveler count multiplication
        /// </summary>
        [DataType(DataType.Currency)]
        [Display(Name = "Fee")]
        public decimal FeeTotal
        {
            get
            {
                if (this.AgencyCommission.HasValue)
                    return this.AgencyCommission.Value + this.Fee.FeeAmt;
                else
                    return this.Fee.FeeAmt;
            }
        }

        /// <summary>
        /// The quantity of each product purchased, obtained from the travelers count
        /// </summary>
        [Display(Name = "Qty")]
        public int Quantity
        {
            get
            {
                if (this.Booking.TravelerCount.HasValue)
                    return (int)this.Booking.TravelerCount.Value;
                else
                    return 1;
            }
        }

        /// <summary>
        /// The total price of this object including fees and traveler count multiplication
        /// </summary>
        [Display(Name = "Total")]
        [DataType(DataType.Currency)]
        public decimal ExtendedLineTotal
        {
            get
            {
                return this.LineTotal * this.Quantity;
            }
        }

        /// <summary>
        /// The total product price of this object, including traveler count multiplication
        /// </summary>
        [Display(Name = "SubTotal")]
        [DataType(DataType.Currency)]
        public decimal ExtendedSubTotal
        {
            get
            {
                if (this.BasePrice.HasValue)
                    return this.BasePrice.Value * this.Quantity;
                else
                    return 0;
            }
        }


        /// <summary>
        /// the total price of all fees for a booking, including traveler count multiplication
        /// </summary>
        [DataType(DataType.Currency)]
        [Display(Name = "Fees")]
        public decimal ExtendedFeeTotal
        {
            get
            {
                if (this.FeeTotal > 0)
                    return this.FeeTotal * this.Quantity;
                else
                    return 0;
            }
        }

    }
}
