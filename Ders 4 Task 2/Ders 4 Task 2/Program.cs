using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_4_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> message = new Queue<string>();
            message.Enqueue("Barcelona");
            message.Enqueue("Real Madrid");
            message.Enqueue("Liverpool");
            message.Enqueue("Arsenal");
            message.Enqueue("B.Munih");
            message.Enqueue("PSG");
            message.Enqueue("Espanyol");
            message.Enqueue("Qarabag");
            message.Enqueue("Ajax");
            message.Enqueue("Benfica");

            message.Dequeue();

            message.Enqueue("Chelsea");


            foreach (var msg in message)
            {
                Console.WriteLine(msg);
            }
        }
    }
}
