using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_1_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hansi temperatur vahidinine cevrilsin ? ( C yaxud F) ");
            string temperature = Console.ReadLine();

            Console.WriteLine("Temperatur qiymetini yazin");
            int a = Convert.ToInt32(Console.ReadLine());

            if (temperature == "C")
            {
                Console.WriteLine((a - 32) * 5 / 9);
            }
            else if (temperature == "F")
            {
                Console.WriteLine((a * 9 / 5) + 32);
            }

        }
    }
}
