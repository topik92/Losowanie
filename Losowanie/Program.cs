using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Losowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wylosowano pytania:\n");
                foreach (var item in Losój())
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n\nNacisnij dowlny klawisz aby losowac ponownie...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private static IEnumerable<int> Losój()
        {
            HashSet<int> numbers = new HashSet<int>();
            Random rnd = new Random();
            while(numbers.Count<5)
            {
               var no = rnd.Next(25)+1;
               if (!numbers.Contains(no))
                   numbers.Add(no);
            }
            return numbers;
        }
    }
}
