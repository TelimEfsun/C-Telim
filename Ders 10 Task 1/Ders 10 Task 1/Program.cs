using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_10_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public interface IFiqure
        {
            double CalculateArea();
            double CalculatePerimeter();
        }

        public class Rectangle : IFiqure
        {
            public double CalculateArea()
            {
                throw new NotImplementedException();
            }

            public double CalculatePerimeter()
            {
                throw new NotImplementedException();
            }
        }

        public class Circle : IFiqure
        {
            public double CalculateArea()
            {
                throw new NotImplementedException();
            }

            public double CalculatePerimeter()
            {
                throw new NotImplementedException();
            }
        }
        public class Triangle : IFiqure
        {
            public double CalculateArea()
            {
                throw new NotImplementedException();
            }

            public double CalculatePerimeter()
            {
                throw new NotImplementedException();
            }
        }
        public class Square : IFiqure
        {
            public double CalculateArea()
            {
                throw new NotImplementedException();
            }

            public double CalculatePerimeter()
            {
                throw new NotImplementedException();
            }
        }
    }
}
