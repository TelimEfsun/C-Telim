using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_2_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
            int maxnumber = arr[0];
            int count = 0;

            foreach (var num in arr)
            {
                if (num > maxnumber)
                {
                    maxnumber = num;
                }
            }
            
            foreach (var num in arr)
            {
                if (maxnumber == num)
                {
                    count++;
                }
            }
            Console.WriteLine($"En boyuk eded {maxnumber} - dir");
            Console.WriteLine($"Bu eded {count} defe tekrarlanib");
        }
    }
}
