using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyOneSourceAssessment
{
    class FoodItem : Item
    {
        public FoodItem()
        {
            SalesTaxExempt = true;
        }
    }
    class Candy : FoodItem
    {
        public Candy()
        {

        }
    }
}
