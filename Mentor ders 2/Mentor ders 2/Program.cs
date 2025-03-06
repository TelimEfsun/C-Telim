using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor_ders_2
{
    class Program
    {
        static ArrayList BookList = new ArrayList();

        static void Main(string[] args)
        {
            Console.WriteLine("---Bookstore System---");           

            bool ff = true;

            while (ff)
            {
                DisplayMenu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    //case "2":
                    //    RemoveBook();
                    //    break;
                    case "3":
                        Calculate();
                        break;
                    case "4":
                        ff = false;
                        break;
                    default:
                        Console.WriteLine("Yalnis Operasiya");
                        break;
                }

            }

        }
        static void AddBook()
        {
            Console.WriteLine("BookTitle");
            string title = Console.ReadLine();
            Console.WriteLine("BookAuthor");
            string author = Console.ReadLine();
            Console.WriteLine("BookPrice");
            int price = Convert.ToInt32(Console.ReadLine());
            string BookInfo = $"{title}+{author}, ${price}";
            BookList.Add(BookInfo); 

        }
        //static void RemoveBook()
        //{
        //    Console.WriteLine("BookTitle");
        //    string title = Console.ReadLine();

        //    for (int i = 0; i < BookList.Count; i++)
        //    {
        //        if (BookList[i].)
        //        {

        //        }
        //    }            
        //}
        static void DisplayMenu()
        {
            Console.WriteLine("AddBook 1");
            Console.WriteLine("RemoveBook 2");
            Console.WriteLine("Calculate 3");
            Console.WriteLine("Exit 4");
        }

        static void Calculate()
        {
            Console.WriteLine("BookPrice");
            int TotalPrice = 0;

            foreach (string item in BookList)
            {
                string[] parts = item.ToString().Split('$');
                if (parts.Length > 1 && int.TryParse(parts[1].Trim(), out int price))
                {
                    TotalPrice += price;
                }
            }
            Console.WriteLine(TotalPrice);

           
        }
      


    }
}
