using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_4_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();

            Console.WriteLine("10 muxtelif eded daxil edin");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Eded {i + 1}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Numbers.Add(num);
            }

            int say = Numbers.Count;
            for (int i = 0; i < 5; i++)
            {
                int var = Numbers[i];
                Numbers[i] = Numbers[say - 5 + i];
                Numbers[say - 5 + i] = var;
            }

            Console.WriteLine("Yeni list");
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
