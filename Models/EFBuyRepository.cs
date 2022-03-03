using Bookstore.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class EFBuyRepository : IBuyRepository
    {
        private BookstoreContext context;
        public EFBuyRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Buy> Buys => context.Buy.Include(x => x.Lines).ThenInclude(x => x.Book);

        public IQueryable<Buy> Buy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SaveBuy(Buy buy)
        {
            context.AttachRange(buy.Lines.Select(x => x.Book));
            if (buy.BuyId == 0)
            {
                context.Buy.Add(buy);
            }

            context.SaveChanges();
        }
    }
}
