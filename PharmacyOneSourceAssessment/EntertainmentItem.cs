using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyOneSourceAssessment
{
    class EntertainmentItem : Item
    {

    }
    class Book : EntertainmentItem
    {
        public Book()
        {
            SalesTaxExempt = true;
        }
    }
}
