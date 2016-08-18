using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyOneSourceAssessment
{
    abstract class Item
    {
        private string _name;
        private decimal _price;
        private bool _salesTaxExempt;
        private bool _imported;
        private decimal _salesTax;
        private decimal _priceWithTax;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public bool SalesTaxExempt
        {
            get { return _salesTaxExempt; }
            set { _salesTaxExempt = value; }
        }
        public bool Imported
        {
            get { return _imported; }
            set { _imported = value; }
        }
        public decimal SalesTax
        {
            get { return _salesTax; }
            set { _salesTax = value; }
        }
        public decimal PriceWithTax
        {
            get { return _priceWithTax; }
            set { _priceWithTax = value; }
        }
    }
}
