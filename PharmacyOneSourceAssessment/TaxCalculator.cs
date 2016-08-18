using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyOneSourceAssessment
{
    class TaxCalculator
    {
        private decimal _unroundedTax;
        private decimal _roundedTax;
        private double _importTaxPercentage = 0.05;
        private double _salesTaxPercentage = 0.10;


        public TaxCalculator(ShoppingCart cart)
        {
            Checkout(cart);
        }

        private void Checkout(ShoppingCart cart)
        {
            foreach (Item item in cart.Items)
            {
                CalculateAllTaxes(item);
            }

        }

        private void CalculateAllTaxes(Item item)
        {
            if (item.Imported)
            {
                CalculateTax(item, _importTaxPercentage);
            }
            if(!item.SalesTaxExempt)
            {
                CalculateTax(item, _salesTaxPercentage);
            }
            CalculatePriceWithTax(item);
        }

        private void CalculateTax(Item item, double taxAmount)
        {
            _unroundedTax = Convert.ToDecimal((taxAmount * (double)item.Price));
            _roundedTax = CalculateRoundedTax(_unroundedTax);
            item.SalesTax += _roundedTax;
        }

        private decimal CalculateRoundedTax(decimal unroundedTax)
        {
            return Math.Ceiling(unroundedTax * 20) / 20;
        }

        private void CalculatePriceWithTax(Item item)
        {
            item.PriceWithTax = item.Price + item.SalesTax;
        }
    }
}
