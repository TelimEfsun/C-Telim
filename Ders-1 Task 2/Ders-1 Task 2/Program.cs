using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_1_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Emek haqqiniz ne qederdir ?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiraye xerciniz ?");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Magaza xercleriniz ne qederdir ?");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Neqliyyat xerciniz ?");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qaliq");
            int price = a - b - c - d;
            Console.WriteLine(price);
        }
    }
}
