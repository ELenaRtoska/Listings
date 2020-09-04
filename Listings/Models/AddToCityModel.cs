using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Listings.Models
{
    public class AddToCityModel
    {
        public int cityId { get; set; }
        public int listingId { get; set; }
        public List<Listing> listings { get; set; }
        public AddToCityModel()
        {
            listings = new List<Listing>();
        }
    }
}