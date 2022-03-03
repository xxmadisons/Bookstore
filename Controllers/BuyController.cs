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
        public IActionResult Checkout()
        {
            return View(new Buy());
        }
    }
}
