using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterSort
{  
    class Program
    {
        static Random rand = new Random();
        static List<char> charList = new List<char>();
        public static char GenerateChar()
        {
            int num = rand.Next(0, 26);
            char random = (char)('a' + num);
            return random;
        }

        public static void AddChars(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                charList.Add(GenerateChar());
            }
        }

        public static void SortAsc()
        {
            /*
            var sortedAsc =
                from e in charList
                orderby e.ToString() ascending
                select e;
   
            foreach (var element in sortedAsc)
            {
                Console.WriteLine(element);
            }*/

            var newlist = charList.OrderBy(e => e);
            foreach (var element in newlist)
            {
                Console.WriteLine(element);
            }
        }

        public static void SortDesc()
        {
           /*
           var sortedDesc =
                from e in charList
                orderby e.ToString() descending
                select e;
  
            
            foreach (var element in sortedDesc)
            {
                Console.WriteLine(element);
            }
            */ 
            var newlist = charList.OrderByDescending(e => e);
            foreach (var element in newlist)
            {
                Console.WriteLine(element);
            }
        }

        public static void SortAscUnique()
        {
            /*
            var sortedAsc =
                from e in charList
                orderby e.ToString() ascending
                select e;

            foreach (var element in sortedAsc.Distinct())
            {
                Console.WriteLine(element);
            }*/
            var newlist = charList.OrderBy(e => e);
            foreach (var element in newlist.Distinct())
            {
                Console.WriteLine(element);
            }
        }
    }
}
