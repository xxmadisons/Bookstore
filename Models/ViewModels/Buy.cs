using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models.ViewModels
{
    public class Buy
    {
        [Key]
        [BindNever]
        public int BuyId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }
        [Required(ErrorMessage = "Please enter name:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Address:")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter city:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter state:")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter Zipcode:")]
        public string Zipcode { get; set; }

        [Required(ErrorMessage = "Please enter Country:")]
        public string Country { get; set; }

    }
}
