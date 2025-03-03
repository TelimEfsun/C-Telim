using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ders_2_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Topladiginiz bali qeyd edin");
            int score = Convert.ToInt32(Console.ReadLine());

            switch (score / 10)
            {
                case 1:
                case 2:
                    Console.WriteLine("Qiymet A");
                    break;
                case 3:
                    Console.WriteLine("Qiymet B");
                    break;
                case 4:
                    Console.WriteLine("Qiymet C");
                    break;
                case 5:
                    Console.WriteLine("Qiymet D");
                    break;
                case 6:
                    Console.WriteLine("Qiymet E");
                    break;
                default:
                    Console.WriteLine("Qiymet F kesildiniz");
                    break;



                    //case int n when (n >= 91 && n <= 100):
                    //    Console.WriteLine("Qiymet: A");
                    //    break;
                    //case int n when (n >= 81 && n <= 90):
                    //    Console.WriteLine("Qiymet: B");
                    //    break;
                    //case int n when (n >= 71 && n <= 80):
                    //    Console.WriteLine("Qiymet: C");
                    //    break;
                    //case int n when (n >= 61 && n <= 70):
                    //    Console.WriteLine("Qiymet: D");
                    //    break;
                    //case int n when (n >= 51 && n <= 60):
                    //    Console.WriteLine("Qiymet E");
                    //    break;
                    //default:
                    //    Console.WriteLine("Qiymet: F");
                    //    break;




            }
        }
    }
}
