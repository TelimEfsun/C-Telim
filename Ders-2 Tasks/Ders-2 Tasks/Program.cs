using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_2_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 95, 85, 72, 60, 45, 88, 92, 76, 58, 100 }; // Nümunə qiymətlər
            Console.WriteLine("Student Grades:");

            foreach (int grade in grades)
            {
                string letterGrade = GetLetterGrade(grade);
                Console.WriteLine($"Numeric Grade: {grade} -> Letter Grade: {letterGrade}");
            }
        }

        static string GetLetterGrade(int grade)
        {
            switch (grade / 10)  // Qiyməti 10-a bölüb əsas qrup təyin edirik
            {
                case 10:
                case 9:
                    return "A";
                case 8:
                    return "B";
                case 7:
                    return "C";
                case 6:
                    return "D";
                default:
                    return "F";
            }
        }
    }
}
