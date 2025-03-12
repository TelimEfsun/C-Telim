using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_4_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            Dictionary<string, string> Location = new Dictionary<string, string>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Zehmet olmasa ölke adi qeyd edin.");
                string country = Console.ReadLine();

                Console.WriteLine("Zehmet olmasa ölkeye aid paytaxt qeyd edin.");
                string capital = Console.ReadLine();

                Location[country] = capital;
            }
            while (true)
            {
                Console.WriteLine("Paytaxtini tapmaq istediyiniz olkeni qeyd edin.");
                string input = Console.ReadLine();

                if (input.ToLower() == "all")
                {
                    foreach (var item in Location)
                    {
                        Console.WriteLine(item.Key, item.Value);
                    }
                }
                else if (Location.ContainsKey(input))
                {
                    Console.WriteLine(Location[input]);
                }
                else
                {
                    Console.WriteLine("Bu olke tapilmadi");
                }
                Console.WriteLine("Yeni paytaxt axtarilsin ? Y/N");
                string answer = Console.ReadLine();

                if (answer == "N")
                {
                    break;
                }
            }
            #endregion
        }
    }
}
