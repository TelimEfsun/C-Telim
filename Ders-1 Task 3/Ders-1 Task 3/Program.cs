using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_1_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nece yasiniz var ?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dogum gunune nece ay qalib ?");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sizin dogum gununuze gun qalib");
            int price = b * 30;
            Console.WriteLine(price);
        }
    }
}
