using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_1_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int var;
            Console.WriteLine("1-den 10-a qeder olan gizli nomreni texmin et");
            var = Int32.Parse(Console.ReadLine());
            while (true)
            {
                if (var <= 10)
                {
                    if (var == 7)
                    {
                        Console.WriteLine("Tebrikler qazandiniz duzdu.");
                        break;
                    }
                    else if (var < 7)
                    {
                        Console.WriteLine("Cox asagi");
                        Console.Write("Yeniden texmin edin : ");
                        var = Int32.Parse(Console.ReadLine());
                    }
                    else if (var > 7)
                    {
                        Console.WriteLine("Cox yuksek");
                        Console.Write("Yeniden texmin edin : ");
                        var = Int32.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Yalnis texmin");
                }
            }
        }

    }
}
