using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyOneSourceAssessment
{
    class ShoppingCart
    {
        private decimal _subTotal;
        public List<Item> Items { get; set; }
        public decimal Subtotal
        {
            get 
            {
                return _subTotal = Items.Sum(item => item.Price);
            }
        }
                   
        public ShoppingCart()
        {
            Items = new List<Item>();
        }

    }
}
