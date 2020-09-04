using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Listings.Models
{
    public class Listing
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, Display(Name = "Опис")]
        public string Description { get; set; }
        [Required, MinLength(12), MaxLength(100)]
        public string Address { get; set; }
        public float PricePerDay { get; set; }
        public string Image { get; set; }
        public bool IsAvailable { get; set; }
    }
}