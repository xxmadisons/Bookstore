using Bookstore.Models;
using Bookstore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class BuyController : Controller
    {
        private IBuyRepository repo { get; set; }
        private Basket basket { get; set; }
        public BuyController (IBuyRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        public IActionResult Checkout()
        {
            return View(new Buy());
        }

        [HttpPost]
        public IActionResult Checkout(Buy buy)
        {
            if (basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Your basket is empty.");
            }

            if (ModelState.IsValid)
            {
                buy.Lines = basket.Items.ToArray();
                repo.SaveBuy(buy);
                basket.ClearBasket();

                return RedirectToPage("/BuyCompleted");
            }

            else
            {
                return View();
            }
        }
    }
}
