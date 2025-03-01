using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_2_Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };

            Console.WriteLine("4 reqeminin oldugu indexler");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 4)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
