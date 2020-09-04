﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Listings.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Country { get; set; }

        public virtual List<Listing> apartments { get; set; }
        public City()
        {
            apartments = new List<Listing>();
        }
    }
}