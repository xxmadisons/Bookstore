using Bookstore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public interface IBuyRepository
    {
       public IQueryable<Buy> Buy { get; set; }

        public void SaveBuy(Buy buy);
    }
}
