using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_4_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> Numbers = new SortedSet<int>(); 
            
            Console.WriteLine("Zehmet olmasa muxtelif ededler daxil edin.");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Eded {i+1}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Numbers.Add(num); 
            }

            Console.WriteLine(" Siralanmis ededler");
            foreach (var num in Numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
