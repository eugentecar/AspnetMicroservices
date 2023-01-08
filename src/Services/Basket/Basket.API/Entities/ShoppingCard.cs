using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Entities
{
    public class ShoppingCard
    {
        public ShoppingCard()
        {
            
        }

        public ShoppingCard(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; set; }
        public List<ShoppingCardItem> Items { get; set; } = new List<ShoppingCardItem>();

        public decimal TotalPrice
        {
            get
            {
                decimal totalprice = 0;
                foreach (var item in Items)
                {
                    totalprice += item.Price * item.Quantity;
                }
                return totalprice;
            }
        }
    }
}
