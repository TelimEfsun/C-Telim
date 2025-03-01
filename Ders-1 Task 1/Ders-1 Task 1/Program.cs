using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_1_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-ci ededi daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-ci ededi daxil edin");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İsareni daxil edin");
            string sign = Console.ReadLine();

            if (sign == "+")
            {
                Console.WriteLine(a + b);
            }
            else if (sign == "-")
            {
                Console.WriteLine(a - b);
            }
            else if (sign == "*")
            {
                Console.WriteLine(a * b);
            }
            else if (sign == "/")
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
