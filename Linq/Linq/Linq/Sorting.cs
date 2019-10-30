using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Sorting
    {
        public static Invoice[] Parts { get; set; } =
        {
            new Invoice(83, "Electric sander", 7, 57.98m),
            new Invoice(24, "Power saw", 18, 99.99m),
            new Invoice(7, "Sledge hammer", 11, 21.5m),
            new Invoice(77, "Hammer", 76, 11.99m),
            new Invoice(39, "Lawn mower", 3, 79.50m),
            new Invoice(68, "Screwdriver", 106, 6.99m),
            new Invoice(56, "Jig saw", 21, 11.00m),
            new Invoice(3, "Wrench", 34, 7.50m)
        };

        public static void SortByPartsDescription()       
        {
            var orderedByPartDesc =
                from e in Parts
                orderby e.PartDescription
                select e;

            Console.WriteLine("Ordered by parts description");
            foreach (var element in orderedByPartDesc)
            {
                Console.WriteLine(element);
            }
        }
        

        public static void SortByPrice()
        {
            var orderedByPrice =
               from e in Parts
               orderby e.Price
               select e;

            Console.WriteLine("\nOrdered by price");
            foreach (var element in orderedByPrice)
            {
                Console.WriteLine(element);
            }
        }

        public static void SortByQty()
        {
            var orderedByQty =
                from e in Parts
                orderby e.Quantity
                select new { e.PartDescription, e.Quantity };

            Console.WriteLine("\nSorted by quantity");
            foreach (var element in orderedByQty)
            {
                Console.WriteLine($"{element.PartDescription,-20:F2} {element.Quantity,6}");
            }
        }

        public static void SortByInvoiceTotal()
        {
            var orderedByInvoiceTotal =
                from e in Parts
                let InvoiceTotal = e.Quantity * e.Price
                orderby InvoiceTotal
                select new { e.PartDescription, InvoiceTotal };

            Console.WriteLine("\nSorted by Invoice Total");
            foreach (var element in orderedByInvoiceTotal)
            {
                Console.WriteLine($"{element.PartDescription,-20:F2} ${element.InvoiceTotal,6:F2}");
            }
        }

        public static void SortByInvoiceBetween(int x, int y)
        {
            var between =
                from e in Parts
                let InvoiceTotal = e.Quantity * e.Price
                orderby InvoiceTotal
                where (InvoiceTotal >= x && InvoiceTotal <= y)
                select new { e.PartDescription, InvoiceTotal };

            Console.WriteLine($"\nInvoice total between {x} and {y}");
            foreach (var element in between)
            {
                Console.WriteLine($"{element.PartDescription,-20:F2} ${element.InvoiceTotal,6:F2}");
            }
        }
    }
}
