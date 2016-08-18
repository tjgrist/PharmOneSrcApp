using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyOneSourceAssessment
{
    class Receipt
    {
        private ShoppingCart _cart;
        private decimal _totalSalesTax;
        private TaxCalculator _taxCalulator;


        public Receipt(ShoppingCart cart)
        {
            _taxCalulator = new TaxCalculator(cart);
            this._cart = cart;
        }
        
        public void Print()
        {
            foreach(Item item in _cart.Items)
            {
                Console.WriteLine(CheckImportStatus(item) + item.Name + " : " + item.PriceWithTax);
                _totalSalesTax += item.SalesTax;
            }
            Console.WriteLine("----------\nSales Taxes: " + _totalSalesTax);
            Console.WriteLine("Total: " + GetTotal());
        }

        private string CheckImportStatus(Item item)
        {
            if (item.Imported)
                return "1 imported ";
            else
                return "1 ";
        }

        private decimal GetTotal()
        {
            return _cart.Subtotal + _totalSalesTax;
        }
    }
}
