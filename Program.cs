using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_3_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {            
            ArrayList shoppingList = new ArrayList();

            while (true) 
            {
                
                Console.WriteLine("Shopping List");
                Console.WriteLine("1.Add product");
                Console.WriteLine("2.Show list");
                Console.WriteLine("3.Product availability");
                Console.WriteLine("4.Exit");
                Console.Write("Seçiminizi daxil edin:");

                string choice = Console.ReadLine(); 

                switch (choice)
                {
                    case "1": 
                        Console.WriteLine("ELave etmek istediyiniz mehsulu yazin");
                        string product = Console.ReadLine();
                        shoppingList.Add(product); 
                        Console.WriteLine($"{product} elave edildi!");
                        break;

                    case "2": 
                        Console.WriteLine("Your shopping list:");
                        if (shoppingList.Count == 0)
                        {
                            Console.WriteLine("Siyahi bosdur.");
                        }
                        else
                        {
                            foreach (string item in shoppingList)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;

                    case "3": 
                        Console.WriteLine("Enter the product you want to search for:");
                        string searchProduct = Console.ReadLine();
                        if (shoppingList.Contains(searchProduct))
                        {
                            Console.WriteLine($"{searchProduct} siyahida movcuddur.");
                        }
                        else
                        {
                            Console.WriteLine($"{searchProduct} siyahida tapilmadi.");
                        }
                        break;

                    case "4": 
                        Console.WriteLine("Exiting the program...");
                        return; 

                    default:
                        Console.WriteLine("Yanlis secim! Zehmet olmasa, 1-4 arasi reqem daxil edin.");
                        break;
                }
            }
        }
    }
}
