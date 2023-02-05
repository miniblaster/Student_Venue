using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SA223A1.Models
{
    public class VenueEditFormViewModel : VenueEditViewModel
    {

        public string TicketSalePassword { get; set; }

        public string PromoCode { get; set; }

        public int? Capacity { get; set; }

    }
}