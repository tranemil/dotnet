using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Driver
    {
        static void Main(string[] args)
        {
            Sorting.SortByPartsDescription();
            Sorting.SortByPrice();
            Sorting.SortByQty();
            Sorting.SortByInvoiceTotal();
            Sorting.SortByInvoiceBetween(200, 500);
        }
    }
}
