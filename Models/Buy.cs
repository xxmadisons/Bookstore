using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Buy
    {
        [Key]
        [BindNever]
        public int BuyId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter name.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please enter address.")]
        public string AddressLine1 { get; set; }


        public string AddressLine2 { get; set; }


        [Required(ErrorMessage = "Please enter city.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter zipcode.")]
        public string Zipcode { get; set; }


        [Required(ErrorMessage = "Please enter state.")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter country.")]
        public string Country { get; set; }

        [BindNever]
        public bool BuyReceived { get; set; } = false;
    }
}
