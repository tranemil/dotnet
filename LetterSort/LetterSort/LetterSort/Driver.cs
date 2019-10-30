using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterSort
{
    class Driver
    {     
        static void Main(string[] args)
        {
            Program.GenerateChar();
            Program.AddChars(30);

            Console.WriteLine("sort by descending");
            Program.SortDesc();
   
            Console.WriteLine("sort by ascending");
            Program.SortAsc();

            Console.WriteLine("sort ascending unique");
            Program.SortAscUnique();
        }
    }
}
