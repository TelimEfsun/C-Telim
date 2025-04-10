 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_10_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();

            Console.WriteLine("Sum" + " "+ Calc.Sum(10,20,30));
            Console.WriteLine("Multiply" + " " + Calc.Multiply(2,3,4));
            Console.WriteLine("Difference" + " " + Calc.Difference(100,20,5));
            Console.WriteLine("Divide" + " " + Calc.Divide(100,2,5));
        }

        public interface ISum
        {
            double Sum(params double[] numbers);
        }
        public interface IMultiply
        {
            double Multiply(params double[] numbers);
        }
        public interface IDifference
        {
            double Difference(params double[] numbers);
        }
        public interface IDivide
        {
            double Divide(params double[] numbers);
        }

        public class Calculator : ISum, IMultiply, IDifference, IDivide
        {
            public double Difference(params double[] numbers)
            {
                if (numbers.Length == 0) return 0;

                double result = numbers[0];

                foreach (var num in numbers.Skip(1)) // baxilmali
                {
                    result -= num;
                }

                return result;
            }

            public double Divide(params double[] numbers)
            {
                if (numbers.Length == 0) return 0;

                double result = numbers[0];

                foreach (var num in numbers.Skip(1))
                {
                    if (num == 0)
                        return double.NaN;

                    result /= num;
                }

                return result;
            }

            public double Multiply(params double[] numbers)
            {
                double result = 1;

                foreach (var vurma in numbers)
                {
                    result *= vurma;
                }
                return result;
            }

            public double Sum(params double[] numbers)
            {
                double result = 0;

                foreach (var cem in numbers)
                {
                    result += cem;
                }
                return result;
            }
        }
    }
}
