using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateRemoval
{
    class Program
    {
        static String[] arraySentence;
        public static String[] PromptInput()
        {
            Console.WriteLine("Enter a sentence");
            arraySentence = Console.ReadLine().Split();
            return arraySentence;
        }

        public static void Sort()
        {
            var sorted =
                from value in arraySentence
                orderby value
                select value.ToLower();

            foreach (var element in sorted.Distinct())
            {
                Console.WriteLine(element);
            }
        }

        public static void Continue()
        {
            Console.WriteLine("Continue? Type END to exit");
            String again = Console.ReadLine().ToLower();

            if (again.Equals("end"))
            {
                Environment.Exit(1);
            }
        }
    }
}
